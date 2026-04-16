#!/usr/bin/env python3
"""
fix_unassigned_variables.py
Fixes CS0165 unassigned local variable errors in RT_850_conf.cs
"""
import io
import os
import re

files_to_fix = [
    "RT_850_conf.cs",
]

def fix_unassigned_variables(file_path):
    """Fix unassigned local variables by initializing them"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Fix unassigned 'enumerator' variables
    # Pattern: ;IEnumerator enumerator;
    pattern = r'(;\s*)IEnumerator\s+enumerator\s*;'
    content = re.sub(pattern, r'\1IEnumerator enumerator = null;', content)
    
    # Fix unassigned 'num2' variables
    # Pattern: ;int num2;
    pattern = r'(;\s*)int\s+num2\s*;'
    content = re.sub(pattern, r'\1int num2 = 0;', content)
    
    # Fix unassigned 'integer_ictel' variables
    # Pattern: ;int integer_ictel;
    pattern = r'(;\s*)int\s+integer_ictel\s*;'
    content = re.sub(pattern, r'\1int integer_ictel = 0;', content)
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        # Count replacements
        replacements = sum(1 for _ in re.finditer(r'(enumerator = null|num2 = 0|integer_ictel = 0)', content))
        return replacements
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_unassigned_variables(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} unassigned variable(s) initialized")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total unassigned variable fixes: {total_fixed}")

if __name__ == "__main__":
    main()