#!/usr/bin/env python3
"""
fix_msgboxstyle.py
Fixes MsgBoxStyle numeric assignments in RT_850_conf.cs
"""
import io
import os
import re

# MsgBoxStyle enum mapping
MSGBOX_STYLE_MAP = {
    '0': 'MsgBoxStyle.OkOnly',
    '1': 'MsgBoxStyle.OkCancel',
    '2': 'MsgBoxStyle.AbortRetryIgnore',
    '3': 'MsgBoxStyle.YesNoCancel',
    '4': 'MsgBoxStyle.YesNo',
    '5': 'MsgBoxStyle.RetryCancel',
    '16': 'MsgBoxStyle.Critical',
    '32': 'MsgBoxStyle.Question',
    '48': 'MsgBoxStyle.Exclamation',
    '64': 'MsgBoxStyle.Information',
    '272': '(MsgBoxStyle)272',  # Critical + OkCancel
    '36': '(MsgBoxStyle)36',    # YesNo + Question
}

files_to_fix = [
    "RT_850_conf.cs",
]

def fix_msgboxstyle(file_path):
    """Fix MsgBoxStyle numeric assignments"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Fix MsgBoxStyle assignments
    for num_value, enum_value in MSGBOX_STYLE_MAP.items():
        # Pattern: (MsgBoxStyle)number
        pattern = r'(\(MsgBoxStyle\))' + re.escape(num_value)
        content = re.sub(pattern, rf'{enum_value}', content)
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        # Count replacements
        replacements = sum(1 for _ in re.finditer(r'MsgBoxStyle\.\w+', content))
        return replacements
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_msgboxstyle(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} MsgBoxStyle assignment(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total MsgBoxStyle fixes: {total_fixed}")

if __name__ == "__main__":
    main()