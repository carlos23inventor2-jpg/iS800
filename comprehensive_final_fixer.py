#!/usr/bin/env python3
"""
comprehensive_final_fixer.py
Script abrangente para corrigir todos os erros de compilação restantes no projeto iS800
"""
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

def fix_system_drawing_references(content):
    """Corrige referências incorretas ao namespace System.Drawing"""
    # Remove referências incorretas como System.Drawing.Drawing
    content = re.sub(r'System\.Drawing\.Drawing\.', 'System.Drawing.', content)

    # Corrige Location e Size quando usados incorretamente
    content = re.sub(r'\bLocation\s*=\s*new\s+System\.Drawing\.Point\s*\(', 'Location = new System.Drawing.Point(', content)
    content = re.sub(r'\bSize\s*=\s*new\s+System\.Drawing\.Size\s*\(', 'Size = new System.Drawing.Size(', content)

    return content

def fix_enum_casts(content):
    """Adiciona casts necessários para enums"""
    # Parity e StopBits
    content = re.sub(
        r'(\w+)\.Parity\s*=\s*(\d+)\s*;',
        r'\1.Parity = (System.IO.Ports.Parity)\2;',
        content
    )
    content = re.sub(
        r'(\w+)\.StopBits\s*=\s*(\d+)\s*;',
        r'\1.StopBits = (System.IO.Ports.StopBits)\2;',
        content
    )

    # FormBorderStyle
    content = re.sub(
        r'(\w+)\.FormBorderStyle\s*=\s*(\d+)\s*;',
        r'\1.FormBorderStyle = (System.Windows.Forms.FormBorderStyle)\2;',
        content
    )

    # DataGridViewTriState para int (conversão reversa)
    content = re.sub(
        r'int\s+(\w+)\s*=\s*\(\s*System\.Windows\.Forms\.DataGridViewTriState\s*\)\s*([^;]+);',
        r'int \1 = (int)\2;',
        content
    )

    return content

def fix_unassigned_variables(content):
    """Corrige variáveis não atribuídas"""
    # Adiciona inicialização para variáveis point e enumerator
    content = re.sub(
        r'Point\s+point\s*;',
        'Point point = new Point();',
        content
    )

    content = re.sub(
        r'IEnumerator\s+enumerator\s*;',
        'IEnumerator enumerator = null;',
        content
    )

    return content

def fix_numvalue_references(content):
    """Corrige referências à variável numValue"""
    # Substitui numValue por uma variável apropriada ou remove se não for usada
    content = re.sub(r'\bnumValue\b', 'num', content)
    return content

def fix_property_assignments(content):
    """Corrige atribuições de propriedades incorretas"""
    # Corrige casos onde propriedades são tratadas como tipos
    content = re.sub(
        r'(\w+)\.Location\s*=\s*Location\s*;',
        r'\1.Location = this.Location;',
        content
    )

    content = re.sub(
        r'(\w+)\.Size\s*=\s*Size\s*;',
        r'\1.Size = this.Size;',
        content
    )

    return content

def process_file(filepath):
    """Processa um arquivo aplicando todas as correções"""
    try:
        with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
            content = f.read()

        original_content = content

        # Aplicar todas as correções
        content = fix_designer_generated_duplicates(content)
        content = fix_system_drawing_references(content)
        content = fix_enum_casts(content)
        content = fix_unassigned_variables(content)
        content = fix_numvalue_references(content)
        content = fix_property_assignments(content)

        if content != original_content:
            with open(filepath, 'w', encoding='utf-8') as f:
                f.write(content)
            return True

    except Exception as e:
        print(f"Erro ao processar {filepath}: {e}")

    return False

def main():
    """Função principal"""
    print("Iniciando correção abrangente de todos os erros de compilação...")

    # Encontrar todos os arquivos .cs
    cs_files = glob.glob('*.cs')

    fixed_count = 0
    total_files = len(cs_files)

    for i, filepath in enumerate(cs_files, 1):
        if process_file(filepath):
            print(f"[{i:3d}/{total_files:3d}] Corrigido: {filepath}")
            fixed_count += 1
        else:
            print(f"[{i:3d}/{total_files:3d}] OK: {filepath}")

    print(f"\nResumo:")
    print(f"- Total de arquivos processados: {total_files}")
    print(f"- Arquivos corrigidos: {fixed_count}")
    print(f"- Arquivos sem alterações: {total_files - fixed_count}")

if __name__ == "__main__":
    main()