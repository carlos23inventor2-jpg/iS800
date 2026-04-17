#!/usr/bin/env python3
import os
import re
import glob

def fix_size_location_references(content):
    """Corrige todas as referências incorretas a size e location"""
    # Remove declarações desnecessárias
    content = re.sub(r'^\s*global::System\.Drawing\.Point location;\s*$', '', content, flags=re.MULTILINE)
    content = re.sub(r'^\s*global::System\.Drawing\.Size size;\s*$', '', content, flags=re.MULTILINE)

    # Corrigir atribuições que usam variáveis locais incorretas
    content = re.sub(r'location\s*=\s*new\s+global::System\.Drawing\.Point\s*\(([^)]+)\);', r'Location = new global::System.Drawing.Point(\1);', content)
    content = re.sub(r'size\s*=\s*new\s+global::System\.Drawing\.Size\s*\(([^)]+)\);', r'Size = new global::System.Drawing.Size(\1);', content)

    # Corrigir referências a variáveis locais
    content = re.sub(r'=\s*location\s*;', '= Location;', content)
    content = re.sub(r'=\s*size\s*;', '= Size;', content)

    # Corrigir casos onde location/size são usados como tipos incorretos
    content = re.sub(r'new\s+location\s*\(', 'new Point(', content)
    content = re.sub(r'new\s+size\s*\(', 'new Size(', content)

    return content

def fix_horizontal_alignment_enum(content):
    """Corrige referências ao enum HorizontalAlignment"""
    content = re.sub(r'HorizontalAlignment\s*=\s*([^;]+);', r'HorizontalAlignment = (System.Windows.Forms.HorizontalAlignment)\1;', content)
    return content

def fix_datagridview_casts_remaining(content):
    """Adiciona casts restantes para DataGridView enums"""
    # DataGridViewContentAlignment - casos restantes
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.Windows.Forms.DataGridViewContentAlignment){m.group(2)};" if any(keyword in m.group(1).lower() for keyword in ['align', 'content', 'defaultcellstyle']) else m.group(0),
        content
    )

    # DataGridViewTriState - casos restantes
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.Windows.Forms.DataGridViewTriState){m.group(2)};" if any(keyword in m.group(1).lower() for keyword in ['visible', 'enabled', 'readonly', 'resizable']) else m.group(0),
        content
    )

    return content

def fix_font_constructor_args(content):
    """Corrige argumentos do construtor Font"""
    # Font com 4 argumentos onde o último deveria ser GraphicsUnit
    content = re.sub(
        r'new\s+global::System\.Drawing\.Font\s*\(\s*([^,]+),\s*([^,]+),\s*([^,]+),\s*(\d+)\s*\)',
        r'new global::System.Drawing.Font(\1, \2, \3, (System.Drawing.GraphicsUnit)\4)',
        content
    )

    # Font com 3 argumentos onde o último deveria ser FontStyle
    content = re.sub(
        r'new\s+global::System\.Drawing\.Font\s*\(\s*([^,]+),\s*([^,]+),\s*(\d+)\s*\)',
        r'new global::System.Drawing.Font(\1, \2, (System.Drawing.FontStyle)\3)',
        content
    )

    return content

def fix_color_from_known_color(content):
    """Corrige chamada Color.FromKnownColor"""
    content = re.sub(
        r'global::System\.Drawing\.Color\.FromKnownColor\s*\(\s*(\d+)\s*\)',
        r'global::System.Drawing.Color.FromKnownColor((System.Drawing.KnownColor)\1)',
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
        content = fix_size_location_references(content)
        content = fix_horizontal_alignment_enum(content)
        content = fix_datagridview_casts_remaining(content)
        content = fix_font_constructor_args(content)
        content = fix_color_from_known_color(content)

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