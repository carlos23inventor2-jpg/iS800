#!/usr/bin/env python3
"""
fix_datagridview_alignment.py
Fixes DataGridViewContentAlignment numeric assignments in RT_850_conf.Designer.cs
"""
import io
import os
import re

# DataGridViewContentAlignment enum mapping
ALIGNMENT_MAP = {
    '1': 'DataGridViewContentAlignment.TopLeft',
    '2': 'DataGridViewContentAlignment.TopCenter',
    '4': 'DataGridViewContentAlignment.TopRight',
    '16': 'DataGridViewContentAlignment.MiddleLeft',
    '32': 'DataGridViewContentAlignment.MiddleCenter',
    '64': 'DataGridViewContentAlignment.MiddleRight',
    '256': 'DataGridViewContentAlignment.BottomLeft',
    '512': 'DataGridViewContentAlignment.BottomCenter',
    '1024': 'DataGridViewContentAlignment.BottomRight',
}

files_to_fix = [
    "RT_850_conf.Designer.cs",
]

def fix_datagridview_alignment(file_path):
    """Fix DataGridViewContentAlignment numeric assignments"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Fix DataGridViewContentAlignment assignments
    for num_value, enum_value in ALIGNMENT_MAP.items():
        pattern = r'(\w+\.DefaultCellStyle\.Alignment\s*=\s*)' + re.escape(num_value) + r'(\s*;)'
        content = re.sub(pattern, rf'\1{enum_value}\2', content)
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        # Count replacements
        replacements = sum(1 for _ in re.finditer(r'DefaultCellStyle\.Alignment\s*=\s*\w+', content))
        return replacements
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_datagridview_alignment(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} DataGridViewContentAlignment assignment(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total DataGridView alignment fixes: {total_fixed}")

if __name__ == "__main__":
    main()