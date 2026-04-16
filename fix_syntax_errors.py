#!/usr/bin/env python3
"""
fix_syntax_errors.py
Fix syntax errors introduced by previous fixes
"""
import io
import os
import re

def fix_syntax_errors():
    """Fix syntax errors from previous fixes"""
    cs_files = [f for f in os.listdir('.') if f.endswith('.cs')]

    for filepath in cs_files:
        try:
            with io.open(filepath, 'r', encoding='utf-8-sig') as f:
                content = f.read()

            original = content

            # Fix invalid "this.//" syntax
            content = re.sub(
                r'this\.//\s+([^;]+);\s*//\s*Removed\s*-\s*not\s*supported',
                r'// this.\1; // Removed - not supported',
                content
            )

            # Fix any remaining "this.//" patterns
            content = re.sub(
                r'this\.//',
                r'// this.',
                content
            )

            # Fix global:: syntax issues
            content = re.sub(
                r'global::System\.Windows\.Forms\.FormStartPosition',
                r'System.Windows.Forms.FormStartPosition',
                content
            )

            if content != original:
                with io.open(filepath, 'w', encoding='utf-8-sig') as f:
                    f.write(content)
                print(f"Fixed syntax errors in {filepath}")

        except Exception as e:
            print(f"Error processing {filepath}: {e}")

if __name__ == '__main__':
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    fix_syntax_errors()