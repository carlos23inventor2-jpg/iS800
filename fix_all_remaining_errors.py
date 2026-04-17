#!/usr/bin/env python3
"""
Script abrangente para corrigir erros de compilação C# em lote
Foca nos padrões mais comuns encontrados no projeto iS800
"""
import re
import os
from pathlib import Path

def fix_horizontal_to_datagridview(content):
    """Corrige HorizontalAlignment → DataGridViewContentAlignment"""
    # Padrão: (HorizontalAlignment)(HorizontalAlignment)(DataGridViewContentAlignment)value
    content = re.sub(
        r'\(System\.Windows\.Forms\.HorizontalAlignment\)\s*\(System\.Windows\.Forms\.HorizontalAlignment\)\(System\.Windows\.Forms\.DataGridViewContentAlignment\)(\d+)',
        r'(System.Windows.Forms.DataGridViewContentAlignment)\1',
        content
    )
    return content

def fix_int_to_enum_casts(content):
    """Corrige conversões int → enum específicas"""
    # DataGridViewColumnHeadersHeightSizeMode
    content = re.sub(
        r'\.ColumnHeadersHeightSizeMode\s*=\s*(\d+)',
        lambda m: f'.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode){m.group(1)}',
        content
    )

    # DataGridViewRowHeadersWidthSizeMode
    content = re.sub(
        r'\.RowHeadersWidthSizeMode\s*=\s*(\d+)',
        lambda m: f'.RowHeadersWidthSizeMode = (System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode){m.group(1)}',
        content
    )

    # DataGridViewColumnSortMode
    content = re.sub(
        r'\.SortMode\s*=\s*(\d+)',
        lambda m: f'.SortMode = (System.Windows.Forms.DataGridViewColumnSortMode){m.group(1)}',
        content
    )

    # TabAppearance
    content = re.sub(
        r'\.Appearance\s*=\s*(\d+)',
        lambda m: f'.Appearance = (System.Windows.Forms.TabAppearance){m.group(1)}',
        content
    )

    # TabSizeMode
    content = re.sub(
        r'\.SizeMode\s*=\s*\(System\.Windows\.Forms\.PictureBoxSizeMode\)\s*\(System\.Windows\.Forms\.PictureBoxSizeMode\)(\d+)',
        r'.SizeMode = (System.Windows.Forms.TabSizeMode)\1',
        content
    )

    return content

def fix_display_style_casts(content):
    """Corrige ToolStripItemDisplayStyle → DataGridViewComboBoxDisplayStyle"""
    content = re.sub(
        r'\.DisplayStyle\s*=\s*\(System\.Windows\.Forms\.ToolStripItemDisplayStyle\)\s*\(System\.Windows\.Forms\.ToolStripItemDisplayStyle\)(\d+)',
        r'.DisplayStyle = (System.Windows.Forms.DataGridViewComboBoxDisplayStyle)\1',
        content
    )
    return content

def fix_unassigned_variables(content):
    """Corrige variáveis não inicializadas"""
    # Padrões comuns de variáveis não inicializadas
    patterns = [
        (r'\bint\s+(num|num2|num3|num4|num5|num6|num7|num8|result|integer_ictel|enumerator)\s*;(?!\s*=)',
         r'int \1 = 0;'),
        (r'\blong\s+(num|valor|result)\s*;(?!\s*=)',
         r'long \1 = 0L;'),
        (r'\bIEnumerator\s+(\w+)\s*;',
         r'IEnumerator \1 = null;'),
    ]

    for pattern, replacement in patterns:
        content = re.sub(pattern, replacement, content)

    return content

def fix_font_style_casts(content):
    """Corrige Font() com FontStyle como int"""
    content = re.sub(
        r'new\s+Font\s*\(\s*([^,]+?)\s*,\s*([\d.]+)\s*,\s*(\d+)',
        r'new Font(\1, \2, (System.Drawing.FontStyle)\3',
        content
    )
    return content

def fix_method_overloads(content):
    """Corrige sobrecargas de métodos"""
    # InStr com CompareMethod
    content = re.sub(
        r'InStr\(\s*(\d+),\s*(.*?),\s*(.*?),\s*(\d+)\)',
        lambda m: f'InStr({m.group(1)}, {m.group(2)}, {m.group(3)}, (Microsoft.VisualBasic.CompareMethod){m.group(4)})',
        content
    )

    # FormatDateTime com DateFormat
    content = re.sub(
        r'FormatDateTime\((.*?),\s*(\d+)\)',
        lambda m: f'FormatDateTime({m.group(1)}, (Microsoft.VisualBasic.DateFormat){m.group(2)})',
        content
    )

    return content

def process_all_files():
    """Processa todos os arquivos .cs no projeto"""
    base_dir = Path('.')
    processed = 0
    total_changes = 0

    # Processar apenas arquivos .cs (não .Designer.cs por enquanto)
    for cs_file in base_dir.glob('*.cs'):
        if 'obj' in str(cs_file) or 'Designer.cs' in str(cs_file):
            continue

        try:
            with open(cs_file, 'r', encoding='utf-8-sig') as f:
                content = f.read()

            original = content

            # Aplicar todas as correções
            content = fix_horizontal_to_datagridview(content)
            content = fix_int_to_enum_casts(content)
            content = fix_display_style_casts(content)
            content = fix_unassigned_variables(content)
            content = fix_font_style_casts(content)
            content = fix_method_overloads(content)

            if content != original:
                with open(cs_file, 'w', encoding='utf-8') as f:
                    f.write(content)
                processed += 1
                changes = content.count('\n') - original.count('\n')
                total_changes += abs(changes)
                print(f'✓ {cs_file.name} ({abs(changes)} mudanças)')

        except Exception as e:
            print(f'✗ Erro em {cs_file.name}: {e}')

    print(f'\n✅ Processados {processed} arquivos com {total_changes} mudanças totais')

if __name__ == '__main__':
    process_all_files()
