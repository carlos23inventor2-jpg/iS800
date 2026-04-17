#!/usr/bin/env python3
import os
import re
import glob

def fix_designer_generated_duplicates(content):
    """Remove atributos DesignerGenerated duplicados"""
    lines = content.split('\n')
    seen_lines = set()
    new_lines = []

    for line in lines:
        stripped = line.strip()
        if '[assembly: Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute()]' in stripped:
            if stripped not in seen_lines:
                seen_lines.add(stripped)
                new_lines.append(line)
        else:
            new_lines.append(line)

    return '\n'.join(new_lines)

def fix_location_size_types(content):
    """Corrige tipos location e size para Location e Size apenas em contextos específicos"""
    # Apenas corrigir quando são parâmetros ou tipos, não em expressões
    content = re.sub(r'\bPoint\s*\(\s*location\s*\)', r'Point(Location)', content)
    content = re.sub(r'\bSize\s*\(\s*size\s*\)', r'Size(Size)', content)
    content = re.sub(r'\blocation\s*=', r'Location =', content)
    content = re.sub(r'\bsize\s*=', r'Size =', content)
    return content

def fix_parity_stopbits_casts(content):
    """Adiciona casts específicos para Parity e StopBits"""
    # Parity assignments
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.IO.Ports.Parity){m.group(2)};" if 'parity' in m.group(1).lower() and m.group(2).isdigit() else m.group(0),
        content
    )

    # StopBits assignments
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.IO.Ports.StopBits){m.group(2)};" if 'stopbits' in m.group(1).lower() and m.group(2).isdigit() else m.group(0),
        content
    )

    return content

def fix_string_to_int_conversions(content):
    """Adiciona conversões de string para int apenas em casos específicos"""
    # Apenas para variáveis int recebendo strings que parecem ser números
    content = re.sub(
        r'int\s+(\w+)\s*=\s*"(\d+)"\s*;',
        r'int \1 = Convert.ToInt32("\2");',
        content
    )

    # Para variáveis que recebem valores de configuração que são strings
    content = re.sub(
        r'int\s+(\w+)\s*=\s*([a-zA-Z_][a-zA-Z0-9_]*)\s*;',
        lambda m: f'int {m.group(1)} = Convert.ToInt32({m.group(2)});' if 'text' in m.group(2).lower() or 'value' in m.group(2).lower() else m.group(0),
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
        content = fix_designer_generated_duplicates(content)
        content = fix_location_size_types(content)
        content = fix_parity_stopbits_casts(content)
        content = fix_string_to_int_conversions(content)

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