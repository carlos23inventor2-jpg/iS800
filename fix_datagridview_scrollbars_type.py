#!/usr/bin/env python3
"""
fix_datagridview_scrollbars_type.py
Fixes DataGridViewScrollBars type not found errors in RT_850_conf.cs
"""
import io
import os
import re

files_to_fix = [
    "RT_850_conf.cs",
]

def fix_datagridview_scrollbars_type(file_path):
    """Fix DataGridViewScrollBars type references"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Fix DataGridViewScrollBars type references
    # Pattern: DataGridViewScrollBars.Horizontal -> System.Windows.Forms.DataGridViewScrollBars.Horizontal
    pattern = r'\bDataGridViewScrollBars\.(\w+)'
    content = re.sub(pattern, r'System.Windows.Forms.DataGridViewScrollBars.\1', content)
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        # Count replacements
        replacements = sum(1 for _ in re.finditer(r'System\.Windows\.Forms\.DataGridViewScrollBars\.\w+', content))
        return replacements
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_datagridview_scrollbars_type(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} DataGridViewScrollBars type reference(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total DataGridViewScrollBars type fixes: {total_fixed}")

if __name__ == "__main__":
    main()