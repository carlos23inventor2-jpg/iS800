#!/usr/bin/env python3
"""
Fix script for Sobre.Designer.cs compilation errors:
1. Line 51: System.Windows.Form -> System.Windows.Forms (add missing 's')
2. Line 58: FormBorderStyle.None -> global::System.Windows.Forms.FormBorderStyle.None
3. Line 63: Duplicate namespace prefix in StartPosition assignment
"""

import os
import re
import sys

def fix_sobre_designer():
    """Fix all three errors in Sobre.Designer.cs"""
    
    file_path = "Sobre.Designer.cs"
    
    if not os.path.exists(file_path):
        print(f"ERROR: {file_path} not found")
        return 0
    
    with open(file_path, 'r', encoding='utf-8') as f:
        content = f.read()
    
    original_content = content
    replacements = 0
    
    # Fix 1: Change System.Windows.Form to System.Windows.Forms (line 51)
    # Pattern: global::System.Windows.Form.AutoScaleMode
    pattern1 = r'global::System\.Windows\.Form\.AutoScaleMode'
    replacement1 = 'global::System.Windows.Forms.AutoScaleMode'
    if re.search(pattern1, content):
        content = re.sub(pattern1, replacement1, content)
        replacements += 1
        print(f"✓ Fixed: System.Windows.Form -> System.Windows.Forms (line ~51)")
    
    # Fix 2: Add namespace prefix to FormBorderStyle.None (line 58)
    # Pattern: this.FormBorderStyle = FormBorderStyle.None;
    # Change to: this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
    pattern2 = r'this\.FormBorderStyle\s*=\s*FormBorderStyle\.None;'
    replacement2 = 'this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;'
    if re.search(pattern2, content):
        content = re.sub(pattern2, replacement2, content)
        replacements += 1
        print(f"✓ Fixed: FormBorderStyle.None -> global::System.Windows.Forms.FormBorderStyle.None (line ~58)")
    
    # Fix 3: Remove duplicate namespace prefix (line 63)
    # Pattern: global::System.Windows.Forms.System.Windows.Forms.FormStartPosition
    # Change to: global::System.Windows.Forms.FormStartPosition
    pattern3 = r'global::System\.Windows\.Forms\.System\.Windows\.Forms\.FormStartPosition'
    replacement3 = 'global::System.Windows.Forms.FormStartPosition'
    if re.search(pattern3, content):
        content = re.sub(pattern3, replacement3, content)
        replacements += 1
        print(f"✓ Fixed: Removed duplicate System.Windows.Forms prefix in FormStartPosition (line ~63)")
    
    # Write back if changes made
    if content != original_content:
        with open(file_path, 'w', encoding='utf-8') as f:
            f.write(content)
        print(f"\n✓ File updated: {file_path}")
        print(f"✓ Total replacements: {replacements}")
        return replacements
    else:
        print(f"\n⚠ No changes needed in {file_path}")
        return 0

if __name__ == "__main__":
    try:
        count = fix_sobre_designer()
        print(f"\nSUMMARY: {count} error(s) fixed in Sobre.Designer.cs")
        sys.exit(0 if count >= 0 else 1)
    except Exception as e:
        print(f"ERROR: {e}", file=sys.stderr)
        sys.exit(1)