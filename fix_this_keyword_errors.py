#!/usr/bin/env python3
"""
fix_this_keyword_errors.py
Corrige erros onde 'this.' é usado incorretamente antes de comentários ou outros elementos inválidos
"""
import os
import re
import glob

def fix_this_keyword_errors(content):
    """Corrige usos incorretos da palavra-chave 'this'"""
    # Remove 'this.' seguido de comentário
    content = re.sub(r'this\.//\s+.*', '', content)

    # Remove 'this.' seguido de comentário de linha
    content = re.sub(r'this\.//.*', '', content)

    # Corrige casos onde 'this.' é usado antes de código inválido
    content = re.sub(r'this\.\s*//.*', '', content)

    # Remove linhas que contenham apenas 'this.' inválido
    content = re.sub(r'^\s*;\s*$', '', content, flags=re.MULTILINE)

    return content

def fix_unexpected_symbol_errors(content):
    """Corrige erros de símbolo inesperado '::'"""
    # Remove usos incorretos de '::'
    content = re.sub(r'::\s*::', ':', content)

    # Corrige namespaces incorretos
    content = re.sub(r'System::', 'System.', content)

    return content

def process_file(filepath):
    """Processa um arquivo aplicando todas as correções"""
    try:
        with open(filepath, 'r', encoding='utf-8', errors='ignore') as f:
            content = f.read()

        original_content = content

        # Aplicar correções
        content = fix_this_keyword_errors(content)
        content = fix_unexpected_symbol_errors(content)

        if content != original_content:
            with open(filepath, 'w', encoding='utf-8') as f:
                f.write(content)
            return True

    except Exception as e:
        print(f"Erro ao processar {filepath}: {e}")

    return False

def main():
    """Função principal"""
    print("Corrigindo erros de palavra-chave 'this' e símbolos inesperados...")

    # Encontrar todos os arquivos .cs
    cs_files = glob.glob('*.cs')

    fixed_count = 0
    total_files = len(cs_files)

    for i, filepath in enumerate(cs_files, 1):
        if process_file(filepath):
            print(f"[{i:3d}/{total_files:3d}] Corrigido: {filepath}")
            fixed_count += 1

    print(f"\nResumo:")
    print(f"- Total de arquivos processados: {total_files}")
    print(f"- Arquivos corrigidos: {fixed_count}")
    print(f"- Arquivos sem alterações: {total_files - fixed_count}")

if __name__ == "__main__":
    main()