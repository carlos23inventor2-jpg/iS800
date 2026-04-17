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
    """Corrige tipos location e size para Location e Size"""
    # Corrigir em contextos de propriedade
    content = re.sub(r'\.location\s*=', r'.Location =', content)
    content = re.sub(r'\.size\s*=', r'.Size =', content)

    # Corrigir em chamadas de construtor
    content = re.sub(r'new Point\(\s*location\s*\)', r'new Point(Location)', content)
    content = re.sub(r'new Size\(\s*size\s*\)', r'new Size(Size)', content)

    return content

def fix_parity_stopbits_casts(content):
    """Adiciona casts para Parity e StopBits"""
    # Parity
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.IO.Ports.Parity){m.group(2)};" if 'parity' in m.group(1).lower() else m.group(0),
        content
    )

    # StopBits
    content = re.sub(
        r'(\w+)\s*=\s*(\d+)\s*;',
        lambda m: f"{m.group(1)} = (System.IO.Ports.StopBits){m.group(2)};" if 'stopbits' in m.group(1).lower() else m.group(0),
        content
    )

    return content

def fix_static_member_access(content):
    """Corrige acesso a membros estáticos"""
    # AutoScaleMode.Font
    content = re.sub(
        r'(\w+)\.AutoScaleMode\s*=\s*Font\s*;',
        r'\1.AutoScaleMode = AutoScaleMode.Font;',
        content
    )

    # FormBorderStyle.None
    content = re.sub(
        r'(\w+)\.FormBorderStyle\s*=\s*None\s*;',
        r'\1.FormBorderStyle = FormBorderStyle.None;',
        content
    )

    return content

def fix_sizegripstyle_cast(content):
    """Adiciona cast para SizeGripStyle"""
    content = re.sub(
        r'(\w+)\.SizeGripStyle\s*=\s*(\d+)\s*;',
        r'\1.SizeGripStyle = (SizeGripStyle)\2;',
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
        content = fix_static_member_access(content)
        content = fix_sizegripstyle_cast(content)

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