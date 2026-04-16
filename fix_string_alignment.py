#!/usr/bin/env python3
"""
Fix StringAlignment conversion errors in Tabela*.cs files.
Converts integer assignments (0, 1, 2) to proper StringAlignment enum values.
"""

import os
import re

def fix_string_alignment(file_path):
    """Fix StringAlignment conversion errors in a file."""
    with open(file_path, 'r', encoding='utf-8') as f:
        content = f.read()
    
    original_content = content
    
    # Fix LineAlignment assignments (all are = 1 -> Center)
    content = re.sub(
        r'stringFormat\.LineAlignment\s*=\s*1\s*;',
        'stringFormat.LineAlignment = StringAlignment.Center;',
        content
    )
    
    # Fix Alignment = 0 -> Near
    content = re.sub(
        r'stringFormat\.Alignment\s*=\s*0\s*;',
        'stringFormat.Alignment = StringAlignment.Near;',
        content
    )
    
    # Fix Alignment = 1 -> Center
    content = re.sub(
        r'stringFormat\.Alignment\s*=\s*1\s*;',
        'stringFormat.Alignment = StringAlignment.Center;',
        content
    )
    
    # Fix Alignment = 2 -> Far
    content = re.sub(
        r'stringFormat\.Alignment\s*=\s*2\s*;',
        'stringFormat.Alignment = StringAlignment.Far;',
        content
    )
    
    # Write back if changed
    if content != original_content:
        with open(file_path, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False

def main():
    base_dir = '/home/carlos/Desktop/tet/dec/iS800'
    files_to_fix = [
        'TabelaLinhaInteria.cs',
        'TabelaMeiaLinhaDireita.cs',
        'TabelaMeiaLinhaEsquerda.cs'
    ]
    
    fixed_count = 0
    
    for filename in files_to_fix:
        file_path = os.path.join(base_dir, filename)
        if os.path.exists(file_path):
            if fix_string_alignment(file_path):
                print(f"Fixed: {filename}")
                fixed_count += 1
            else:
                print(f"No changes needed: {filename}")
        else:
            print(f"File not found: {file_path}")
    
    print(f"\nTotal files fixed: {fixed_count}")

if __name__ == '__main__':
    main()