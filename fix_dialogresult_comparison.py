#!/usr/bin/env python3
"""
fix_dialogresult_comparison.py
Fixes DialogResult comparison with int in RT_850_conf.cs
"""
import io
import os
import re

files_to_fix = [
    "RT_850_conf.cs",
]

def fix_dialogresult_comparison(file_path):
    """Fix DialogResult comparison with int"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Fix DialogResult == int comparisons
    # Pattern: DialogResult.OK == 1 -> DialogResult.OK == DialogResult.OK
    pattern = r'(DialogResult\.\w+)\s*==\s*(\d+)'
    def replacer(match):
        nonlocal replacements
        dialog_result = match.group(1)
        num_value = match.group(2)
        
        # Map numeric values to DialogResult enum
        dialog_map = {
            '1': 'DialogResult.OK',
            '2': 'DialogResult.Cancel',
            '3': 'DialogResult.Abort',
            '4': 'DialogResult.Retry',
            '5': 'DialogResult.Ignore',
            '6': 'DialogResult.Yes',
            '7': 'DialogResult.No',
        }
        
        if num_value in dialog_map:
            replacements += 1
            return f'{dialog_result} == {dialog_map[num_value]}'
        else:
            return match.group(0)  # Keep original if not found
    
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
        fixed_count = fix_dialogresult_comparison(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} DialogResult comparison(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total DialogResult comparison fixes: {total_fixed}")

if __name__ == "__main__":
    main()