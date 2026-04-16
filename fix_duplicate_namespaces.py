#!/usr/bin/env python3
"""
Fix duplicate namespace prefixes in Sobre.Designer.cs
"""

import os
import re

def fix_duplicate_namespaces():
    """Fix duplicate global::System.Windows prefixes"""

    file_path = "Sobre.Designer.cs"

    if not os.path.exists(file_path):
        print(f"Error: {file_path} not found")
        return False

    with open(file_path, 'r', encoding='utf-8') as f:
        content = f.read()

    original_content = content

    # Fix duplicate global::System.Windows prefixes
    content = re.sub(
        r'global::System\.Windows\.global::System\.Windows\.Forms',
        r'global::System.Windows.Forms',
        content
    )

    if content != original_content:
        with open(file_path, 'w', encoding='utf-8') as f:
            f.write(content)
        print(f"✓ Fixed duplicate namespace prefixes in {file_path}")
        return True
    else:
        print(f"No changes needed in {file_path}")
        return False

if __name__ == "__main__":
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    fix_duplicate_namespaces()