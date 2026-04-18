#!/usr/bin/env python3
"""
Fix all DataGridViewContentAlignment and FontStyle errors
"""
import os
import re
import glob

def fix_datagridview_alignment(content):
    """Fix DataGridViewContentAlignment errors by adding explicit casts"""
    # Pattern: .something = int_value; where it should be DataGridViewContentAlignment
    # This regex looks for alignment assignments with bare integers
    content = re.sub(
        r'\.Alignment\s*=\s*(\d+)\s*;',
        r'.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)\1;',
        content
    )
    content = re.sub(
        r'\.DefaultCellStyle\.Alignment\s*=\s*(\d+)\s*;',
        r'.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)\1;',
        content
    )
    # Fix HorizontalAlignment to DataGridViewContentAlignment casts
    content = re.sub(
        r'\.Alignment\s*=\s*\(System\.Windows\.Forms\.HorizontalAlignment\)\s*(\d+)\s*;',
        r'.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)\1;',
        content
    )
    return content

def fix_fontstyle(content):
    """Fix FontStyle errors by adding explicit casts"""
    # Pattern: Font(..., int, ...) where int should be cast to FontStyle
    content = re.sub(
        r'new\s+(?:global::)?System\.Drawing\.Font\s*\(\s*"([^"]+)",\s*([\d.]+),\s*(\d+),',
        r'new global::System.Drawing.Font("\1", \2, (System.Drawing.FontStyle)\3,',
        content
    )
    # Also fix cases with 4 parameters
    content = re.sub(
        r'new\s+Font\s*\(\s*"([^"]+)",\s*([\d.]+),\s*(\d+),\s*\((?:global::)?System\.Drawing\.GraphicsUnit\)\s*(\d+)\s*\)',
        r'new Font("\1", \2, (System.Drawing.FontStyle)\3, (global::System.Drawing.GraphicsUnit)\4)',
        content
    )
    return content

def fix_uninitialized_variables(content):
    """Fix uninitialized variables"""
    # Initialize bool result
    content = re.sub(
        r'\bbool\s+result\s*;',
        r'bool result = false;',
        content
    )
    # Initialize int num12
    content = re.sub(
        r'\bint\s+num12\s*;',
        r'int num12 = 0;',
        content
    )
    # Initialize bool flag
    content = re.sub(
        r'\bbool\s+flag\s*;',
        r'bool flag = false;',
        content
    )
    return content

def fix_size_alignment_errors(content):
    """Fix Size/Padding alignment errors in Designer files"""
    # Fix incomplete lines like "global::System.Drawing." that's truncated
    content = re.sub(
        r'global::System\.Drawing\.\s*Size\s*=\s*new\s+global::System\.Drawing\.Size',
        r'toolStri_RT.ImageScalingSize = new global::System.Drawing.Size',
        content
    )
    return content

def main():
    files = glob.glob("*.cs")
    print(f"Processing {len(files)} files...")
    
    fixed_count = 0
    for filepath in files:
        try:
            with open(filepath, 'r', encoding='utf-8') as f:
                content = f.read()
            
            original_content = content
            
            # Apply all fixes
            content = fix_datagridview_alignment(content)
            content = fix_fontstyle(content)
            content = fix_uninitialized_variables(content)
            content = fix_size_alignment_errors(content)
            
            # Only write if there were changes
            if content != original_content:
                with open(filepath, 'w', encoding='utf-8') as f:
                    f.write(content)
                print(f"✓ Fixed: {filepath}")
                fixed_count += 1
        except Exception as e:
            print(f"✗ Error processing {filepath}: {e}")
    
    print(f"\nTotal files fixed: {fixed_count}")

if __name__ == "__main__":
    main()
