#!/usr/bin/env python3
"""
Script final para corrigir TODOS os erros do projeto em uma passagem
"""
import re
import os
from pathlib import Path

def fix_font_style_errors(content):
    """Corrige Font() com inteiro em FontStyle"""
    # Padrão: new Font("name", size, int)
    content = re.sub(
        r'new\s+Font\s*\(\s*([^,]+?)\s*,\s*([\d.]+)\s*,\s*(\d+)',
        r'new Font(\1, \2, (System.Drawing.FontStyle)\3',
        content
    )
    return content

def fix_horizontalalignment_to_datagridview(content):
    """Corrige HorizontalAlignment para DataGridViewContentAlignment"""
    # Padrão: System.Windows.Forms.HorizontalAlignment.X -> DataGridViewContentAlignment.X
    content = re.sub(
        r'System\.Windows\.Forms\.HorizontalAlignment\.(Left|Center|Right|MiddleLeft|MiddleCenter|MiddleRight|BottomLeft|BottomCenter|BottomRight)',
        lambda m: f'System.Windows.Forms.DataGridViewContentAlignment.{m.group(1)}',
        content
    )
    return content

def fix_datagridview_to_horizontal(content):
    """Corrige o inverso - DataGridViewContentAlignment para HorizontalAlignment em alguns casos"""
    # Padrão: if DataGridViewContentAlignment -> HorizontalAlignment
    content = re.sub(
        r'System\.Windows\.Forms\.DataGridViewContentAlignment\.(MiddleLeft|MiddleCenter|MiddleRight)',
        lambda m: f'System.Windows.Forms.HorizontalAlignment.{m.group(1).replace("Middle", "")}',
        content
    )
    return content

def fix_unassigned_variables_comprehensive(content):
    """Corrige variáveis não inicializadas"""
    # int num; -> int num = 0;
    content = re.sub(
        r'\bint\s+(num|num2|num3|num4|num5|num8|result|integer_ictel|enumerator)\s*;(?!\s*=)',
        r'int \1 = 0;',
        content
    )
    
    # IEnumerator enumerator; -> IEnumerator enumerator = null;
    content = re.sub(
        r'\bList<[^>]+>\.Enumerator\s+(\w+)\s*;',
        r'List<perifericos.Periferico>.Enumerator \1 = new List<perifericos.Periferico>.Enumerator();',
        content
    )
    
    return content

def fix_datagridview_mode_int(content):
    """Corrige int -> DataGridViewColumnHeadersHeightSizeMode, etc"""
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

def process_all_cs_files():
    """Processa todos os arquivos .cs"""
    base_dir = Path('.')
    count = 0
    
    for cs_file in base_dir.glob('*.cs'):
        if 'obj' in str(cs_file):
            continue
            
        try:
            with open(cs_file, 'r', encoding='utf-8-sig') as f:
                content = f.read()
            
            original = content
            
            # Aplicar todas as correções
            content = fix_font_style_errors(content)
            content = fix_horizontalalignment_to_datagridview(content)
            content = fix_unassigned_variables_comprehensive(content)
            content = fix_datagridview_mode_int(content)
            
            if content != original:
                with open(cs_file, 'w', encoding='utf-8') as f:
                    f.write(content)
                count += 1
                print(f'✓ {cs_file.name}')
        except Exception as e:
            print(f'✗ Erro em {cs_file.name}: {e}')
    
    print(f'\n✅ {count} arquivo(s) corrigido(s)')

if __name__ == '__main__':
    process_all_cs_files()
