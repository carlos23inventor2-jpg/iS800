#!/usr/bin/env python3
import os
import re
import glob

def fix_size_location_types(content):
    """Corrige tipos size e location incorretos"""
    # Corrigir em declarações de variáveis
    content = re.sub(r'\bPoint\s+location\s*;', '', content)
    content = re.sub(r'\bSize\s+size\s*;', '', content)

    # Corrigir em atribuições
    content = re.sub(r'location\s*=\s*new\s+Point\s*\(', 'Location = new Point(', content)
    content = re.sub(r'size\s*=\s*new\s+Size\s*\(', 'Size = new Size(', content)

    # Corrigir referências
    content = re.sub(r'=\s*location\s*;', '= Location;', content)
    content = re.sub(r'=\s*size\s*;', '= Size;', content)

    return content

def fix_datagridview_casts(content):
    """Adiciona casts para DataGridView enums"""
    # DataGridViewContentAlignment
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.Windows.Forms.DataGridViewContentAlignment){m.group(2)};" if 'alignment' in m.group(1).lower() or 'contentalignment' in m.group(1).lower() else m.group(0),
        content
    )

    # DataGridViewTriState
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.Windows.Forms.DataGridViewTriState){m.group(2)};" if 'tristate' in m.group(1).lower() or 'tri' in m.group(1).lower() else m.group(0),
        content
    )

    return content

def fix_horizontal_alignment(content):
    """Corrige HorizontalAlignment referências"""
    content = re.sub(r'HorizontalAlignment\s*=\s*([^;]+);', r'HorizontalAlignment = (System.Windows.Forms.HorizontalAlignment)\1;', content)
    return content

def fix_graphics_unit_cast(content):
    """Adiciona cast para GraphicsUnit"""
    content = re.sub(
        r'new\s+Font\s*\(\s*([^,]+),\s*([^,]+),\s*([^,]+),\s*(\d+)\s*\)',
        r'new Font(\1, \2, \3, (System.Drawing.GraphicsUnit)\4)',
        content
    )
    return content

def fix_font_style_cast(content):
    """Adiciona cast para FontStyle"""
    content = re.sub(
        r'new\s+Font\s*\(\s*([^,]+),\s*([^,]+),\s*(\d+)\s*\)',
        r'new Font(\1, \2, (System.Drawing.FontStyle)\3)',
        content
    )
    return content

def fix_openmode_cast(content):
    """Corrige conversão de OpenMode para int"""
    content = re.sub(
        r'(\w+)\s*\(\s*([^,]+),\s*([^,]+),\s*([^,]+),\s*([^)]+)\)',
        lambda m: f"{m.group(1)}({m.group(2)}, {m.group(3)}, {m.group(4)}, (int){m.group(5)})" if 'OpenMode' in m.group(5) else m.group(0),
        content
    )
    return content

def process_file(filepath):
    """Processa um arquivo aplicando todas as correções"""
    try:
        with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
            content = f.read()

        original_content = content

        # Aplicar correções
        content = fix_size_location_types(content)
        content = fix_datagridview_casts(content)
        content = fix_horizontal_alignment(content)
        content = fix_graphics_unit_cast(content)
        content = fix_font_style_cast(content)
        content = fix_openmode_cast(content)

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