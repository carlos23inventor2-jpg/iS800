#!/usr/bin/env python3
"""
fix_font_constructors.py
Fixes Font constructor calls where numeric values are passed instead of FontStyle/GraphicsUnit enums.
Handles approximately 50+ instances across RT_850_conf.cs and RT_850_conf.Designer.cs
"""
import io
import os
import re

# FontStyle enum mapping
FONT_STYLE_MAP = {
    '0': 'FontStyle.Regular',
    '1': 'FontStyle.Bold',
    '2': 'FontStyle.Italic',
    '3': 'FontStyle.Underline',
    '4': 'FontStyle.Strikeout',
}

# GraphicsUnit enum mapping
GRAPHICS_UNIT_MAP = {
    '0': 'GraphicsUnit.World',
    '1': 'GraphicsUnit.Display',
    '2': 'GraphicsUnit.Pixel',
    '3': 'GraphicsUnit.Point',
    '4': 'GraphicsUnit.Inch',
    '5': 'GraphicsUnit.Document',
    '6': 'GraphicsUnit.Millimeter',
}

files_to_fix = [
    "RT_850_conf.cs",
    "RT_850_conf.Designer.cs",
]

def fix_font_constructors(file_path):
    """Fix Font constructor calls with numeric enum values"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Fix FontStyle arguments (3rd parameter in Font constructors)
    for num_value, enum_value in FONT_STYLE_MAP.items():
        # Pattern: new Font("name", size, 0, ...)
        pattern = r'(new\s+Font\s*\(\s*[^,]+,\s*[^,]+,\s*)' + re.escape(num_value) + r'(\s*,)'
        content = re.sub(pattern, rf'\1{enum_value}\2', content)
        
        # Also fix direct assignments: font.FontStyle = 0;
        pattern2 = r'(\w+\.FontStyle\s*=\s*)' + re.escape(num_value) + r'(\s*;)'
        content = re.sub(pattern2, rf'\1{enum_value}\2', content)
    
    # Fix GraphicsUnit arguments (4th parameter in Font constructors)
    for num_value, enum_value in GRAPHICS_UNIT_MAP.items():
        # Pattern: new Font("name", size, FontStyle.Regular, 0, ...)
        pattern = r'(new\s+Font\s*\(\s*[^,]+,\s*[^,]+,\s*[^,]+,\s*)' + re.escape(num_value) + r'(\s*,|\s*\))'
        content = re.sub(pattern, rf'\1{enum_value}\2', content)
    
    # Count replacements
    if content != original:
        replacements = (len(re.findall(r'new\s+Font\s*\(', original)) - len(re.findall(r'new\s+Font\s*\(', content))) * -1  # Rough estimate
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        return max(1, replacements)  # At least 1 if changed
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_font_constructors(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - Font constructor enum fixes applied")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total Font constructor fixes: {total_fixed}")

if __name__ == "__main__":
    main()