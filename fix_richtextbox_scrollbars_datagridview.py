#!/usr/bin/env python3
"""
fix_richtextbox_scrollbars_datagridview.py
Fixes assignment of RichTextBoxScrollBars enum to DataGridView controls.
DataGridView needs DataGridViewScrollBars, not RichTextBoxScrollBars.
"""
import io
import os
import re

files_to_fix = [
    "RT_821_200_conf.Designer.cs",
]

def fix_scrollbars_enum_types(file_path):
    """Fix RichTextBoxScrollBars assignments to DataGridView"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    lines = content.split('\n')
    new_lines = []
    
    for line in lines:
        original_line = line
        
        # Check if this line assigns RichTextBoxScrollBars to a DataGridView
        if 'RichTextBoxScrollBars' in line and '.ScrollBars =' in line:
            # Check if it's a DataGridView
            if 'DataGridView' in line or 'dataGridView' in line:
                # Map RichTextBoxScrollBars values to DataGridViewScrollBars
                line = line.replace(
                    'global::System.Windows.Forms.RichTextBoxScrollBars.Vertical',
                    'global::System.Windows.Forms.DataGridViewScrollBars.Horizontal'
                )
                line = line.replace(
                    'global::System.Windows.Forms.RichTextBoxScrollBars.Horizontal',
                    'global::System.Windows.Forms.DataGridViewScrollBars.Vertical'
                )
                line = line.replace(
                    'global::System.Windows.Forms.RichTextBoxScrollBars.Both',
                    'global::System.Windows.Forms.DataGridViewScrollBars.Both'
                )
                line = line.replace(
                    'global::System.Windows.Forms.RichTextBoxScrollBars.None',
                    'global::System.Windows.Forms.DataGridViewScrollBars.None'
                )
                
                if line != original_line:
                    replacements += 1
        
        new_lines.append(line)
    
    if replacements > 0:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write('\n'.join(new_lines))
        return replacements
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_scrollbars_enum_types(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} RichTextBoxScrollBars to DataGridViewScrollBars conversion(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total replacements: {total_fixed}")

if __name__ == "__main__":
    main()