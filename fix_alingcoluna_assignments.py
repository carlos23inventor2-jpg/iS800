#!/usr/bin/env python3
"""
fix_alingcoluna_assignments.py
Fixes AlingColuna property assignments with numeric DataGridViewContentAlignment values
"""
import io
import os
import re

files_to_fix = [
    "RT_850_conf.cs",
    "RT_831_200_configurador.cs",
    "RT_830_200_configurador.cs",
]

# DataGridViewContentAlignment enum mapping
ALIGNMENT_MAP = {
    '1': 'DataGridViewContentAlignment.TopLeft',
    '2': 'DataGridViewContentAlignment.TopCenter',
    '4': 'DataGridViewContentAlignment.TopRight',
    '16': 'DataGridViewContentAlignment.MiddleLeft',
    '32': 'DataGridViewContentAlignment.MiddleCenter',
    '64': 'DataGridViewContentAlignment.MiddleRight',
    '256': 'DataGridViewContentAlignment.BottomLeft',
    '512': 'DataGridViewContentAlignment.BottomCenter',
    '1024': 'DataGridViewContentAlignment.BottomRight',
}

def fix_alingcoluna_assignments(file_path):
    """Fix AlingColuna property assignments"""
    if not os.path.exists(file_path):
        return 0

    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()

    original = content
    replacements = 0

    # Fix AlingColuna assignments
    for num_value, enum_value in ALIGNMENT_MAP.items():
        # Pattern: .AlingColuna = number;
        pattern = rf'(\.AlingColuna\s*=\s*){re.escape(num_value)}(\s*;)'
        content = re.sub(pattern, rf'\1{enum_value}\2', content)

    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        # Count replacements
        replacements = sum(1 for _ in re.finditer(r'\.AlingColuna\s*=\s*\w+', content))
        return replacements

    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")

    total_fixed = 0
    files_processed = 0

    for file_name in files_to_fix:
        fixed_count = fix_alingcoluna_assignments(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} AlingColuna assignment(s)")
            total_fixed += fixed_count
            files_processed += 1

    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total AlingColuna fixes: {total_fixed}")

if __name__ == "__main__":
    main()