#!/usr/bin/env python3
import os
import re
import glob

def add_missing_usings(content):
    """Adiciona using directives faltantes"""
    lines = content.split('\n')

    # Encontrar onde inserir os usings (após o último using existente)
    insert_index = 0
    has_system_drawing = False
    has_system_windows_forms = False

    for i, line in enumerate(lines):
        stripped = line.strip()
        if stripped.startswith('using '):
            insert_index = i + 1
            if 'System.Drawing' in stripped:
                has_system_drawing = True
            if 'System.Windows.Forms' in stripped:
                has_system_windows_forms = True
        elif stripped and not stripped.startswith('//') and not stripped.startswith('/*'):
            # Encontrou o fim dos usings
            break

    # Adicionar usings faltantes
    usings_to_add = []
    if not has_system_drawing:
        usings_to_add.append('using System.Drawing;')
    if not has_system_windows_forms:
        usings_to_add.append('using System.Windows.Forms;')

    if usings_to_add:
        # Inserir após o último using
        lines.insert(insert_index, '\n'.join(usings_to_add))
        return '\n'.join(lines)

    return content

def fix_property_type_conflicts(content):
    """Corrige conflitos onde propriedades são usadas como tipos"""
    # Quando Size é usado como tipo mas deveria ser System.Drawing.Size
    content = re.sub(r'\bSize\s*\(\s*([^)]+)\s*\)', r'System.Drawing.Size(\1)', content)

    # Quando Location é usado como tipo mas deveria ser System.Drawing.Point
    content = re.sub(r'\bLocation\s*\(\s*([^)]+)\s*\)', r'System.Drawing.Point(\1)', content)

    return content

def process_file(filepath):
    """Processa um arquivo aplicando todas as correções"""
    try:
        with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
            content = f.read()

        original_content = content

        # Aplicar correções
        content = add_missing_usings(content)
        content = fix_property_type_conflicts(content)

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