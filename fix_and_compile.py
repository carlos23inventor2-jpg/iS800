#!/usr/bin/env python3
"""
fix_and_compile.py
Script único para corrigir padrões comuns de código C# quebrado e compilar o projeto iS800.
"""
import glob
import os
import re
import subprocess
import sys

DIALOG_RESULT_MAP = {
    1: 'OK',
    2: 'Cancel',
    3: 'Abort',
    4: 'Retry',
    5: 'Ignore',
    6: 'Yes',
    7: 'No',
}

ENUM_PROPERTY_CASTS = {
    'Dock': 'System.Windows.Forms.DockStyle',
    'DockStyle': 'System.Windows.Forms.DockStyle',
    'ToolStripLayoutStyle': 'System.Windows.Forms.ToolStripLayoutStyle',
    'LayoutStyle': 'System.Windows.Forms.ToolStripLayoutStyle',
    'TabAppearance': 'System.Windows.Forms.TabAppearance',
    'TabSizeMode': 'System.Windows.Forms.TabSizeMode',
    'DataGridViewColumnHeadersHeightSizeMode': 'System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode',
    'DataGridViewAutoSizeColumnMode': 'System.Windows.Forms.DataGridViewAutoSizeColumnMode',
    'AutoSizeMode': 'System.Windows.Forms.DataGridViewAutoSizeColumnMode',
    'DataGridViewRowHeadersWidthSizeMode': 'System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode',
    'DataGridViewColumnSortMode': 'System.Windows.Forms.DataGridViewColumnSortMode',
    'DataGridViewContentAlignment': 'System.Windows.Forms.DataGridViewContentAlignment',
    'AlingColuna': 'System.Windows.Forms.DataGridViewContentAlignment',
    'SizeMode': 'System.Windows.Forms.PictureBoxSizeMode',
    'PictureBoxSizeMode': 'System.Windows.Forms.PictureBoxSizeMode',
    'SelectionMode': 'System.Windows.Forms.SelectionMode',
    'ScrollBars': 'System.Windows.Forms.ScrollBars',
    'WrapMode': 'System.Windows.Forms.DataGridViewTriState',
    'ToolStripItemDisplayStyle': 'System.Windows.Forms.ToolStripItemDisplayStyle',
    'DisplayStyle': 'System.Windows.Forms.ToolStripItemDisplayStyle',
    'Alignment': 'System.Windows.Forms.HorizontalAlignment',
    'DataGridViewTriState': 'System.Windows.Forms.DataGridViewTriState',
    'StopBits': 'System.IO.Ports.StopBits',
    'Parity': 'System.IO.Ports.Parity',
    'FontStyle': 'System.Drawing.FontStyle',
}

REPAIR_PATTERNS = [
    (r'global::System\.Windows\.Forms\.global::System\.Windows\.Forms', 'global::System.Windows.Forms'),
    (r'System\.Windows\.Forms\.global::System\.Windows\.Forms', 'System.Windows.Forms'),
    (r'(?:global::)?System\.Windows\.Forms(?:\.(?:global::)?System\.Windows\.Forms)+', 'global::System.Windows.Forms'),
    (r'System\.Windows\.Forms(?:\.(?:global::)?System\.Windows\.Forms)+', 'System.Windows.Forms'),
    (r'(?:global::)?System\.Windows(?:\.(?:global::)?System\.Windows)+', 'global::System.Windows'),
    (r'System\.Windows(?:\.(?:global::)?System\.Windows)+', 'System.Windows'),
    (r'(?:global::)?System\.Windows\.Form\.AutoScaleMode\.Font', 'global::System.Windows.Forms.AutoScaleMode.Font'),
    (r'System\.Windows\.Form\.AutoScaleMode\.Font', 'System.Windows.Forms.AutoScaleMode.Font'),
    (r'System\.Windows\.Forms\.Form\.AutoScaleMode\.Font', 'System.Windows.Forms.AutoScaleMode.Font'),
    (r'(?:global::)?System\.Drawing(?:\.global::System\.Drawing)+', 'global::System.Drawing'),
    (r'System\.Drawing(?:\.global::System\.Drawing)+', 'System.Drawing'),
    (r'global::System\.Windows\.Form\.', 'global::System.Windows.Forms.'),
    (r'System\.Windows\.Form\.', 'System.Windows.Forms.'),
]


def dedupe_usings(content):
    lines = content.splitlines(keepends=True)
    output = []
    seen = set()
    i = 0
    while i < len(lines):
        stripped = lines[i].lstrip('\ufeff').strip()
        if stripped.startswith('using '):
            if stripped not in seen:
                seen.add(stripped)
                output.append(lines[i])
            i += 1
            continue
        if stripped == '':
            output.append(lines[i])
            i += 1
            continue
        break
    if i == 0:
        return content
    output.extend(lines[i:])
    return ''.join(output)


def remove_duplicate_designer_attribute(filename, content):
    base, ext = os.path.splitext(filename)
    if ext.lower() != '.cs' or filename.endswith('.Designer.cs'):
        return content

    designer_file = f'{base}.Designer.cs'
    if os.path.exists(designer_file):
        content = re.sub(r'^[ \t]*\[global::Microsoft\.VisualBasic\.CompilerServices\.DesignerGenerated\][ \t]*\r?\n?', '', content, flags=re.MULTILINE)
        content = re.sub(r'^[ \t]*\[DesignerGenerated\][ \t]*\r?\n?', '', content, flags=re.MULTILINE)
    return content


def repair_broken_draw_properties(content):
    def repl_draw(match):
        prop = match.group('prop')
        typ = match.group('typ')
        args = match.group('args')
        var = match.group('var')
        return f'{var}.{prop} = new global::System.Drawing.{typ}({args});'

    content = re.sub(
        r'global::System\.Drawing\.\s*\r?\n\s*(?P<prop>Location|Size)\s*=\s*new\s+global::System\.Drawing\.(?P<typ>Point|Size)\((?P<args>[^;]+?)\);\s*\r?\n\s*(?P<var>[A-Za-z_][A-Za-z0-9_]*)\.(?P=prop)\s*=\s*this\.(?P=prop);',
        repl_draw,
        content,
        flags=re.DOTALL,
    )

    content = re.sub(
        r'^(?P<indent>[ \t]*)?(?P<prop>Location|Size)\s*=\s*new\s+(?:global::System\.Drawing\.)?(?P<typ>Point|Size)\((?P<args>[^;]+?)\);\s*\r?\n\s*(?P<var>[A-Za-z_][A-Za-z0-9_]*)\.(?P=prop)\s*=\s*this\.(?P=prop);',
        lambda m: f'{m.group("var")}.{m.group("prop")} = new global::System.Drawing.{m.group("typ")}({m.group("args")});',
        content,
        flags=re.DOTALL | re.MULTILINE,
    )

    return content


def repair_msgbox_style(content):
    msgbox_style_map = {
        0: 'OkOnly',
        1: 'OkCancel',
        2: 'AbortRetryIgnore',
        3: 'YesNoCancel',
        4: 'YesNo',
        5: 'RetryCancel',
        16: 'Critical',
        32: 'Question',
        48: 'Exclamation',
        64: 'Information',
    }

    def numeric_repl(match):
        expr = match.group(1)
        num = int(match.group(2))
        style = msgbox_style_map.get(num)
        if style:
            return f'Interaction.MsgBox({expr}, MsgBoxStyle.{style},'
        return match.group(0)

    content = re.sub(
        r'Interaction\.MsgBox\(\s*([^,]+?)\s*,\s*(\d+)\s*,',
        numeric_repl,
        content,
    )

    content = re.sub(
        r'Interaction\.MsgBox\(\s*([^,]+?)\s*,\s*(?!MsgBoxStyle\b|\(MsgBoxStyle\b)([A-Za-z_][A-Za-z0-9_]*)\s*,',
        r'Interaction.MsgBox(\1, (MsgBoxStyle)\2,',
        content,
    )

    return content


def repair_open_calls(content):
    def fix_fileopen(match):
        arg1 = match.group(1)
        arg2 = match.group(2)
        arg3 = match.group(3)
        arg4 = match.group(4)
        arg5 = match.group(5)
        return f'FileSystem.FileOpen({arg1}, {arg2}, (OpenMode){arg3}, (OpenAccess){arg4}, (OpenShare){arg5},'

    content = re.sub(
        r'FileSystem\.FileOpen\(\s*([^,]+),\s*([^,]+),\s*([^,]+),\s*([^,]+),\s*([^,]+),',
        fix_fileopen,
        content,
    )
    return content


def repair_open_mode_method_calls(content):
    content = re.sub(
        r'(\b(?:this\.)?(?:Mensagem|AtualizaMsgTela)[A-Za-z0-9_]*\([^,]+,\s*)(OpenMode\.[A-Za-z_][A-Za-z0-9_]*)(\s*\))',
        r'\1(int)\2\3',
        content,
    )
    return content


def ensure_vb_using_for_openmode(content):
    if 'OpenMode.' in content and 'using Microsoft.VisualBasic;' not in content:
        using_block = re.match(r'^(?:using [^\r\n]+\r?\n)+', content)
        if using_block:
            block = using_block.group(0)
            if 'using Microsoft.VisualBasic;' not in block:
                content = block + 'using Microsoft.VisualBasic;\n' + content[len(block):]
    return content


def repair_invalid_msgbox_style_names(content):
    content = re.sub(r'MsgBoxStyle\.([A-Za-z_]+)\d+', r'MsgBoxStyle.\1', content)
    return content


def repair_string_alignment_casts(content):
    content = re.sub(
        r'stringFormat\.Alignment\s*=\s*\(System\.Windows\.Forms\.HorizontalAlignment\)\s*\(System\.Windows\.Forms\.HorizontalAlignment\)\s*StringAlignment\.([A-Za-z_][A-Za-z0-9_]*);',
        r'stringFormat.Alignment = (System.Drawing.StringAlignment)StringAlignment.\1;',
        content,
    )
    content = re.sub(
        r'([A-Za-z0-9_\.]+\s*=\s*)(?!\(\s*System\.Drawing\.StringAlignment\s*\))(System\.Windows\.Forms\.HorizontalAlignment\.[A-Za-z_][A-Za-z0-9_]*);',
        r'\1(System.Drawing.StringAlignment)\2;',
        content,
    )
    return content


def repair_commit_edit_calls(content):
    return re.sub(
        r'(\bCommitEdit\(\s*)(\d+)(\s*\))',
        r'\1(System.Windows.Forms.DataGridViewDataErrorContexts)\2\3',
        content,
    )


def repair_color_from_known_color_casts(content):
    return re.sub(
        r'(\bColor\.FromKnownColor\(\s*)(\d+)(\s*\))',
        r'\1(System.Drawing.KnownColor)\2\3',
        content,
    )


def repair_font_style_casts(content):
    content = re.sub(
        r'(new\s+Font\([^,]+,\s*[^,]+,\s*)(?!\(\s*System\.Drawing\.FontStyle\s*\))([^,\)\s]+)(\s*\))',
        r'\1(System.Drawing.FontStyle)\2\3',
        content,
    )
    content = re.sub(
        r'(new\s+Font\([^,]+,\s*[^,]+,\s*)(?!\(\s*System\.Drawing\.FontStyle\s*\))([^,\)\s]+)(\s*,\s*[A-Za-z0-9_\.]+\))',
        r'\1(System.Drawing.FontStyle)\2\3',
        content,
    )
    return content


def repair_alignment_casts(content):
    content = re.sub(
        r'([A-Za-z0-9_\.]+\.AlingColuna\s*=\s*)(\d+);',
        r'\1(System.Windows.Forms.DataGridViewContentAlignment)\2;',
        content,
    )
    content = re.sub(
        r'([A-Za-z0-9_\.]+\.AlingColuna\s*=\s*)(System\.Windows\.Forms\.HorizontalAlignment\.[A-Za-z_][A-Za-z0-9_]*);',
        r'\1(System.Windows.Forms.DataGridViewContentAlignment)\2;',
        content,
    )
    # content = re.sub(
    #     r'([A-Za-z0-9_\.]+\.Alignment\s*=\s*)(System\.Windows\.Forms\.DataGridViewContentAlignment\.[A-Za-z_][A-Za-z0-9_]*);',
    #     r'\1(System.Windows.Forms.HorizontalAlignment)\2;',
    #     content,
    # )
    return content


def repair_enum_casts(content):
    content = re.sub(
        r'([A-Za-z0-9_\.]+\.Parity\s*=\s*)(?!\(System\.IO\.Ports\.Parity\))([^;\n]+);',
        r'\1(System.IO.Ports.Parity)\2;',
        content,
    )
    content = re.sub(
        r'([A-Za-z0-9_\.]+\.StopBits\s*=\s*)(?!\(System\.IO\.Ports\.StopBits\))([^;\n]+);',
        r'\1(System.IO.Ports.StopBits)\2;',
        content,
    )
    content = re.sub(
        r'([A-Za-z0-9_\.]+\s*=\s*)(?!\(int\))(System\.IO\.Ports\.Parity\.[A-Za-z_][A-Za-z0-9_]*);',
        r'\1(int)\2;',
        content,
    )
    content = re.sub(
        r'([A-Za-z0-9_\.]+\s*=\s*)(?!\(int\))(System\.IO\.Ports\.StopBits\.[A-Za-z_][A-Za-z0-9_]*);',
        r'\1(int)\2;',
        content,
    )
    for prop, enum_type in ENUM_PROPERTY_CASTS.items():
        content = re.sub(
            rf'([A-Za-z0-9_\.]+\.{prop}\s*=\s*)(?!\(\s*{re.escape(enum_type)}\s*\))([^;\n]+);',
            fr'\1({enum_type})\2;',
            content,
        )
    content = repair_scrollbars_type_names(content)
    content = repair_commit_edit_calls(content)
    content = repair_color_from_known_color_casts(content)
    content = repair_font_style_casts(content)
    content = repair_alignment_casts(content)
    return content


def compress_redundant_casts(content):
    replacements = [
        (r'(?:\(System\.IO\.Ports\.Parity\))+', '(System.IO.Ports.Parity)'),
        (r'(?:\(System\.IO\.Ports\.StopBits\))+', '(System.IO.Ports.StopBits)'),
        (r'(?:\(OpenMode\))+', '(OpenMode)'),
        (r'(?:\(OpenAccess\))+', '(OpenAccess)'),
        (r'(?:\(OpenShare\))+', '(OpenShare)'),
        (r'(?:\(MsgBoxStyle\))+', '(MsgBoxStyle)'),
    ]
    for pattern, replacement in replacements:
        content = re.sub(pattern, replacement, content)
    content = re.sub(r'\(OpenAccess\)-([0-9]+)', r'(OpenAccess)(-\1)', content)
    content = re.sub(r'\(OpenShare\)-([0-9]+)', r'(OpenShare)(-\1)', content)
    content = re.sub(r'\(OpenMode\)-([0-9]+)', r'(OpenMode)(-\1)', content)
    return content


def repair_new_decimal_constructors(content):
    return re.sub(r'new\s+(?:num|maximum|min(?:imum)?|decimal)\(', 'new decimal(', content)


def repair_broken_word_assignments(content):
    content = re.sub(
        r'\bmaximum\s*=\s*new decimal\(',
        'maximum = new decimal(',
        content,
    )
    content = re.sub(
        r'\bminimum\s*=\s*new decimal\(',
        'minimum = new decimal(',
        content,
    )
    return content


def repair_special_patterns(content):
    content = repair_broken_draw_properties(content)
    content = repair_msgbox_style(content)
    content = repair_invalid_msgbox_style_names(content)
    content = repair_open_calls(content)
    content = repair_open_mode_method_calls(content)
    content = ensure_vb_using_for_openmode(content)
    content = repair_scrollbars_type_names(content)
    content = repair_enum_casts(content)
    content = compress_redundant_casts(content)
    content = repair_new_decimal_constructors(content)
    content = repair_broken_word_assignments(content)
    content = repair_string_alignment_casts(content)
    content = re.sub(r'RT_geral\.Ctrl_erro\s+result\s*;', 'RT_geral.Ctrl_erro result = new RT_geral.Ctrl_erro();', content)
    content = re.sub(r'WrapMode\s*=\s*0;', 'WrapMode = System.Windows.Forms.DataGridViewTriState.NotSet;', content)
    content = re.sub(r'WrapMode\s*=\s*1;', 'WrapMode = System.Windows.Forms.DataGridViewTriState.True;', content)
    content = re.sub(r'WrapMode\s*=\s*2;', 'WrapMode = System.Windows.Forms.DataGridViewTriState.False;', content)
    return content


def repair_content(filename, content):
    original = content
    content = dedupe_usings(content)
    content = remove_duplicate_designer_attribute(filename, content)
    for pattern, replacement in REPAIR_PATTERNS:
        while True:
            new_content = re.sub(pattern, replacement, content)
            if new_content == content:
                break
            content = new_content
    for _ in range(3):
        new_content = repair_special_patterns(content)
        if new_content == content:
            break
        content = new_content
    return content if content != original else None


def fix_files():
    cs_files = sorted(glob.glob('**/*.cs', recursive=True))
    modified_files = []
    for filepath in cs_files:
        if filepath.startswith('obj' + os.sep) or filepath.startswith('My' + os.sep):
            continue
        try:
            with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
                content = f.read()
            repaired = repair_content(filepath, content)
            if repaired is not None:
                with open(filepath, 'w', encoding='utf-8') as f:
                    f.write(repaired)
                modified_files.append(filepath)
                print(f'Fixed: {filepath}')
        except Exception as exc:
            print(f'Error processing {filepath}: {exc}')
    return modified_files


def compile_project():
    print('\nStarting compilation with xbuild...')
    output_path = os.path.join(SCRIPT_DIR, 'build_output.log')
    command = ['xbuild', 'iS800.csproj', '/p:Configuration=Debug', '/p:Platform=x64']
    result = subprocess.run(command, cwd=SCRIPT_DIR, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, text=True)
    with open(output_path, 'w', encoding='utf-8') as f:
        f.write(result.stdout)
    print(result.stdout)
    return result.returncode


def main():
    global SCRIPT_DIR
    SCRIPT_DIR = os.path.abspath(os.path.dirname(__file__))
    os.chdir(SCRIPT_DIR)
    print('Running unified fix script for iS800...')
    fixed_files = fix_files()
    print('\nFix completed.')
    print(f'Files modified: {len(fixed_files)}')
    for filepath in fixed_files:
        print(f' - {filepath}')
    rc = compile_project()
    print(f'\nCompilation exit code: {rc}')
    if rc == 0:
        print('\n✅ Compilation succeeded.')
    else:
        print('\n❌ Compilation failed. Review build_output.log for details.')
    return rc


if __name__ == '__main__':
    sys.exit(main())
