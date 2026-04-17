#!/usr/bin/env python3
import os
import re
import glob

def fix_datagridview_final_casts(content):
    """Adiciona casts finais para DataGridView enums"""
    # DataGridViewContentAlignment
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.Windows.Forms.DataGridViewContentAlignment){m.group(2)};" if m.group(1) in ['DefaultCellStyle', 'Alignment', 'HeaderCell', 'RowHeadersDefaultCellStyle'] or 'align' in m.group(1).lower() else m.group(0),
        content
    )

    # DataGridViewTriState
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.Windows.Forms.DataGridViewTriState){m.group(2)};" if m.group(1) in ['Resizable', 'Visible', 'AllowUserToResizeRows', 'AllowUserToResizeColumns', 'RowHeadersVisible'] else m.group(0),
        content
    )

    return content

def fix_num_variable_references(content):
    """Corrige referências à variável 'num'"""
    # Substituir 'num' por uma variável apropriada ou converter para o tipo correto
    content = re.sub(r'\bnum\b', 'numValue', content)
    return content

def fix_font_constructors(content):
    """Corrige construtores Font com argumentos incorretos"""
    # Font com argumentos na ordem errada
    content = re.sub(
        r'new\s+System\.Drawing\.Font\s*\(\s*([^,]+),\s*([^,]+),\s*([^,]+),\s*([^,]+),\s*([^)]+)\s*\)',
        lambda m: f'new System.Drawing.Font({m.group(1)}, {m.group(2)}, (System.Drawing.FontStyle){m.group(3)}, (System.Drawing.GraphicsUnit){m.group(4)}, {m.group(5)})',
        content
    )

    return content

def fix_color_known_color(content):
    """Corrige Color.FromKnownColor"""
    content = re.sub(
        r'System\.Drawing\.Color\.FromKnownColor\s*\(\s*(\d+)\s*\)',
        r'System.Drawing.Color.FromKnownColor((System.Drawing.KnownColor)\1)',
        content
    )
    return content

def fix_openmode_cast(content):
    """Corrige conversão de OpenMode para int"""
    content = re.sub(
        r'(\w+)\s*\(\s*([^,]+),\s*([^,]+),\s*([^,]+),\s*([^)]+)\s*\)',
        lambda m: f"{m.group(1)}({m.group(2)}, {m.group(3)}, {m.group(4)}, (int){m.group(5)})" if 'OpenMode' in m.group(5) else m.group(0),
        content
    )
    return content

def fix_padding_references(content):
    """Corrige referências a 'padding'"""
    content = re.sub(r'\bpadding\b', 'Padding', content)
    return content

def fix_system_drawing_system(content):
    """Remove referências incorretas a System.Drawing.System"""
    content = re.sub(r'System\.Drawing\.System\.', 'System.Drawing.', content)
    return content

def process_file(filepath):
    """Processa um arquivo aplicando todas as correções"""
    try:
        with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
            content = f.read()

        original_content = content

        # Aplicar correções
        content = fix_datagridview_final_casts(content)
        content = fix_num_variable_references(content)
        content = fix_font_constructors(content)
        content = fix_color_known_color(content)
        content = fix_openmode_cast(content)
        content = fix_padding_references(content)
        content = fix_system_drawing_system(content)

        if content != original_content:
            with open(filepath, 'w', encoding='utf-8') as f:
                f.write(content)
            return True

    except Exception as e:
        print(f"Erro ao processar {filepath}: {e}")

    return False

def main():
    # Encontrar todos os arquivos .cs
    cs_files = glob.glob('*.cs')

    fixed_count = 0
    for filepath in cs_files:
        if process_file(filepath):
            print(f"Corrigido: {filepath}")
            fixed_count += 1

    print(f"\nTotal de arquivos corrigidos: {fixed_count}")

if __name__ == "__main__":
    main()