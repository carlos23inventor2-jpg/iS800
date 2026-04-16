#!/usr/bin/env python3
"""
fix_datagridview_column_headers.py
Fixes DataGridViewColumnHeadersHeightSizeMode numeric assignments in RT_850_conf.Designer.cs
"""
import io
import os
import re

# DataGridViewColumnHeadersHeightSizeMode enum mapping
COLUMN_HEADERS_MODE_MAP = {
    '0': 'DataGridViewColumnHeadersHeightSizeMode.EnableResizing',
    '1': 'DataGridViewColumnHeadersHeightSizeMode.DisableResizing',
    '2': 'DataGridViewColumnHeadersHeightSizeMode.AutoSize',
}

files_to_fix = [
    "RT_850_conf.Designer.cs",
]

def fix_datagridview_column_headers(file_path):
    """Fix DataGridViewColumnHeadersHeightSizeMode numeric assignments"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Fix DataGridViewColumnHeadersHeightSizeMode assignments
    for num_value, enum_value in COLUMN_HEADERS_MODE_MAP.items():
        pattern = r'(\w+\.ColumnHeadersHeightSizeMode\s*=\s*)' + re.escape(num_value) + r'(\s*;)'
        content = re.sub(pattern, rf'\1{enum_value}\2', content)
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        # Count replacements
        replacements = sum(1 for _ in re.finditer(r'ColumnHeadersHeightSizeMode\s*=\s*\w+', content))
        return replacements
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_datagridview_column_headers(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} DataGridViewColumnHeadersHeightSizeMode assignment(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total DataGridView column headers fixes: {total_fixed}")

if __name__ == "__main__":
    main()