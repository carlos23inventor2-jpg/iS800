#!/usr/bin/env python3
"""
fix_toolstrip_enums.py
Fixes ToolStrip enum assignments in RT_850_conf.Designer.cs
- ToolStripLayoutStyle numeric assignments
- ToolStripItemDisplayStyle numeric assignments
"""
import io
import os
import re

# ToolStripLayoutStyle enum mapping
TOOLSTRIP_LAYOUT_MAP = {
    '0': 'ToolStripLayoutStyle.Flow',
    '1': 'ToolStripLayoutStyle.HorizontalStackWithOverflow',
    '2': 'ToolStripLayoutStyle.VerticalStackWithOverflow',
    '3': 'ToolStripLayoutStyle.StackWithOverflow',
    '4': 'ToolStripLayoutStyle.Table',
}

# ToolStripItemDisplayStyle enum mapping
TOOLSTRIP_DISPLAY_MAP = {
    '0': 'ToolStripItemDisplayStyle.None',
    '1': 'ToolStripItemDisplayStyle.Text',
    '2': 'ToolStripItemDisplayStyle.Image',
    '3': 'ToolStripItemDisplayStyle.ImageAndText',
}

files_to_fix = [
    "RT_850_conf.Designer.cs",
]

def fix_toolstrip_enums(file_path):
    """Fix ToolStrip enum assignments"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Fix ToolStripLayoutStyle assignments
    for num_value, enum_value in TOOLSTRIP_LAYOUT_MAP.items():
        pattern = r'(\w+\.LayoutStyle\s*=\s*)' + re.escape(num_value) + r'(\s*;)'
        content = re.sub(pattern, rf'\1{enum_value}\2', content)
    
    # Fix ToolStripItemDisplayStyle assignments
    for num_value, enum_value in TOOLSTRIP_DISPLAY_MAP.items():
        pattern = r'(\w+\.DisplayStyle\s*=\s*)' + re.escape(num_value) + r'(\s*;)'
        content = re.sub(pattern, rf'\1{enum_value}\2', content)
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        # Count replacements
        replacements = sum(1 for _ in re.finditer(r'LayoutStyle\s*=\s*\w+|DisplayStyle\s*=\s*\w+', content))
        return replacements
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_toolstrip_enums(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} ToolStrip enum assignment(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total ToolStrip enum fixes: {total_fixed}")

if __name__ == "__main__":
    main()