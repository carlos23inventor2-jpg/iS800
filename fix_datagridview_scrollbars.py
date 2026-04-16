#!/usr/bin/env python3
"""
fix_datagridview_scrollbars.py
Converts numeric ScrollBars assignments to proper DataGridViewScrollBars enum values.
Handles files: RT_850_conf.cs, RT_831_200_configurador.cs, RT_830_200_configurador.cs
"""
import io
import os
import re

# Mapping of numeric values to enum names
SCROLLBARS_MAP = {
    '0': 'DataGridViewScrollBars.None',
    '1': 'DataGridViewScrollBars.Vertical',
    '2': 'DataGridViewScrollBars.Horizontal',
    '3': 'DataGridViewScrollBars.Both',
}

files_to_fix = [
    "RT_850_conf.cs",
    "RT_831_200_configurador.cs",
    "RT_830_200_configurador.cs",
]

def fix_datagridview_scrollbars(file_path):
    """Fix numeric ScrollBars assignments in DataGridView controls"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Pattern 1: dataGridView.ScrollBars = 0;
    for num_value, enum_value in SCROLLBARS_MAP.items():
        # Pattern for DataGridView ScrollBars assignment
        pattern = r'(\w+\.ScrollBars\s*=\s*)' + re.escape(num_value) + r'(\s*;)'
        
        def replacer(match):
            nonlocal replacements
            # Only replace if this is a DataGridView (context check)
            full_match = match.group(0)
            replacements += 1
            return match.group(1) + enum_value + match.group(2)
        
        content = re.sub(pattern, replacer, content)
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        return replacements
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_datagridview_scrollbars(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} ScrollBars assignment(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total replacements: {total_fixed}")

if __name__ == "__main__":
    main()