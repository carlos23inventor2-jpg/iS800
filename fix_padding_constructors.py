#!/usr/bin/env python3
"""
fix_padding_constructors.py
Fixes 'new padding(...)' constructor calls to use proper global::System.Windows.Forms.Padding type.
Replaces approximately 23 instances across Designer.cs files.
"""
import io
import os
import re

files_to_fix = [
    "RT_830_200_configurador.Designer.cs",
    "GC_82x_conf.Designer.cs",
    "Equip_303_conf.Designer.cs",
    "RT_821_200_conf.Designer.cs",
    "Equip_302_conf.Designer.cs",
]

def fix_padding_constructors(file_path):
    """Fix 'new padding(...)' to 'new global::System.Windows.Forms.Padding(...)'"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    
    # Pattern: new padding(args)
    pattern = r'\bnew\s+padding\s*\('
    replacement = r'new global::System.Windows.Forms.Padding('
    
    content = re.sub(pattern, replacement, content)
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        count = len(re.findall(pattern, original))
        return count
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_padding_constructors(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} padding constructor(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    # Also scan all .cs files for any padding constructors not in the main list
    for file_name in os.listdir("."):
        if file_name.endswith(".Designer.cs") and file_name not in files_to_fix:
            fixed_count = fix_padding_constructors(file_name)
            if fixed_count > 0:
                print(f"FIXED (BONUS): {file_name} - {fixed_count} padding constructor(s)")
                total_fixed += fixed_count
                files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total replacements: {total_fixed}")

if __name__ == "__main__":
    main()