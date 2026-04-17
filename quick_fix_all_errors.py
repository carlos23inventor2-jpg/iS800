#!/usr/bin/env python3
"""
Script otimizado para corrigir erros de compilação C# em lote
"""
import re
import os
from pathlib import Path

def fix_designer_alignment_errors(content):
    """Corrige erros de conversão em Designer.cs e .cs"""
    # HorizontalAlignment -> DataGridViewContentAlignment
    content = re.sub(
        r'\.DataGridViewCellStyle\d*\.Alignment\s*=\s*System\.Windows\.Forms\.HorizontalAlignment\.(\w+)',
        r'.DataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.\1',
        content
    )
    content = re.sub(
        r'\.DefaultCellStyle\.Alignment\s*=\s*System\.Windows\.Forms\.HorizontalAlignment\.(\w+)',
        r'.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.\1',
        content
    )
    # int -> DataGridViewColumnHeadersHeightSizeMode
    content = re.sub(
        r'\.ColumnHeadersHeightSizeMode\s*=\s*(\d+)',
        lambda m: f'.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode){m.group(1)}',
        content
    )
    # int -> DataGridViewRowHeadersWidthSizeMode
    content = re.sub(
        r'\.RowHeadersWidthSizeMode\s*=\s*(\d+)',
        lambda m: f'.RowHeadersWidthSizeMode = (System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode){m.group(1)}',
        content
    )
    return content

def fix_unassigned_variables(content):
    """Corriga variáveis não inicializadas"""
    # int num e valor não inicializados
    content = re.sub(
        r'int\s+(num|valor|result|integer_ictel|num2|num8|enumerator)\s*;',
        r'int \1 = 0;',
        content
    )
    content = re.sub(
        r'long\s+(num|valor|result)\s*;',
        r'long \1 = 0L;',
        content
    )
    # IEnumerator não inicializado
    content = re.sub(
        r'IEnumerator\s+enumerator\s*;',
        r'IEnumerator enumerator = null;',
        content
    )
    # Parity enum
    content = re.sub(
        r'(\w+)\s*=\s*\.Parity\.',
        r'\1 = (int)SerialPort.Parity.',
        content
    )
    return content

def fix_method_call_errors(content):
    """Corrige erros de chamada de método"""
    # OpenMode -> DateFormat
    content = re.sub(
        r'FormatDateTime\((.*?),\s*(\d+)\)',
        lambda m: f'FormatDateTime({m.group(1)}, (DateFormat){m.group(2)})',
        content
    )
    # Font com FontStyle inteiro
    content = re.sub(
        r'new Font\((.*?),\s*([\d.]+),\s*(\d+)',
        lambda m: f'new Font({m.group(1)}, {m.group(2)}, (FontStyle){m.group(3)}',
        content
    )
    # InStr com argumentos incorretos
    content = re.sub(
        r'InStr\(\s*(\d+),\s*(.*?),\s*(.*?),\s*(\d+)\)',
        lambda m: f'InStr({m.group(1)}, {m.group(2)}, {m.group(3)}, (CompareMethod){m.group(4)})',
        content
    )
    return content

def process_file(filepath):
    """Processa um arquivo C#"""
    try:
        with open(filepath, 'r', encoding='utf-8') as f:
            content = f.read()
        
        original = content
        
        # Aplicar correções
        if 'Designer.cs' in filepath:
            content = fix_designer_alignment_errors(content)
        
        content = fix_unassigned_variables(content)
        content = fix_method_call_errors(content)
        
        # Salvar se houve mudanças
        if content != original:
            with open(filepath, 'w', encoding='utf-8') as f:
                f.write(content)
            return True
        return False
    except Exception as e:
        print(f"Erro ao processar {filepath}: {e}")
        return False

def main():
    base_dir = Path('.')
    count = 0
    
    # Processar todos os arquivos .cs
    for cs_file in base_dir.glob('*.cs'):
        if process_file(str(cs_file)):
            count += 1
            print(f"✓ {cs_file.name}")
    
    print(f"\n✅ {count} arquivo(s) corrigido(s)")

if __name__ == '__main__':
    main()
