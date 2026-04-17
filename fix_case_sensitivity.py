#!/usr/bin/env python3
import os
import re
import glob

def fix_size_location_case(content):
    """Corrige maiúsculas/minúsculas de Size e Location"""
    # Substituir todas as ocorrências incorretas
    content = re.sub(r'\bsize\b', 'Size', content)
    content = re.sub(r'\blocation\b', 'Location', content)

    # Mas não substituir quando são nomes de variáveis ou parâmetros válidos
    # Reverter casos onde "size" é parte de outras palavras
    content = re.sub(r'\bSizes\b', 'size', content)
    content = re.sub(r'\bLocations\b', 'location', content)
    content = re.sub(r'\bSizeType\b', 'sizetype', content)
    content = re.sub(r'\bLocationType\b', 'locationtype', content)

    return content

def fix_remaining_datagridview_casts(content):
    """Adiciona casts finais para DataGridView"""
    # Casos mais específicos
    content = re.sub(
        r'DefaultCellStyle\.Alignment\s*=\s*(\d+)\s*;',
        r'DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)\1;',
        content
    )

    content = re.sub(
        r'Resizable\s*=\s*(\d+)\s*;',
        r'Resizable = (System.Windows.Forms.DataGridViewTriState)\1;',
        content
    )

    content = re.sub(
        r'Visible\s*=\s*(\d+)\s*;',
        r'Visible = (System.Windows.Forms.DataGridViewTriState)\1;',
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
        content = fix_size_location_case(content)
        content = fix_remaining_datagridview_casts(content)

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