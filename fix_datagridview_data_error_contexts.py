#!/usr/bin/env python3
"""
fix_datagridview_data_error_contexts.py
Fixes DataGridViewDataErrorContexts numeric assignments in RT_850_conf.cs
"""
import io
import os
import re

# DataGridViewDataErrorContexts enum mapping
ERROR_CONTEXTS_MAP = {
    '0': 'DataGridViewDataErrorContexts.Formatting',
    '1': 'DataGridViewDataErrorContexts.Display',
    '2': 'DataGridViewDataErrorContexts.PreferredSize',
    '4': 'DataGridViewDataErrorContexts.RowHeader',
    '8': 'DataGridViewDataErrorContexts.Parsing',
    '16': 'DataGridViewDataErrorContexts.Commit',
    '32': 'DataGridViewDataErrorContexts.InitialValueRestoration',
    '64': 'DataGridViewDataErrorContexts.MaskUpdate',
    '128': 'DataGridViewDataErrorContexts.LeaveControl',
}

files_to_fix = [
    "RT_850_conf.cs",
]

def fix_datagridview_data_error_contexts(file_path):
    """Fix DataGridViewDataErrorContexts numeric assignments"""
    if not os.path.exists(file_path):
        return 0
    
    with io.open(file_path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    
    original = content
    replacements = 0
    
    # Fix DataGridViewDataErrorContexts assignments
    for num_value, enum_value in ERROR_CONTEXTS_MAP.items():
        # Pattern: (DataGridViewDataErrorContexts)number
        pattern = r'(\(DataGridViewDataErrorContexts\))' + re.escape(num_value)
        content = re.sub(pattern, rf'{enum_value}', content)
    
    if content != original:
        with io.open(file_path, "w", encoding="utf-8-sig") as f:
            f.write(content)
        # Count replacements
        replacements = sum(1 for _ in re.finditer(r'DataGridViewDataErrorContexts\.\w+', content))
        return replacements
    
    return 0

def main():
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    
    total_fixed = 0
    files_processed = 0
    
    for file_name in files_to_fix:
        fixed_count = fix_datagridview_data_error_contexts(file_name)
        if fixed_count > 0:
            print(f"FIXED: {file_name} - {fixed_count} DataGridViewDataErrorContexts assignment(s)")
            total_fixed += fixed_count
            files_processed += 1
    
    print(f"\nSummary:")
    print(f"Files processed: {files_processed}")
    print(f"Total DataGridViewDataErrorContexts fixes: {total_fixed}")

if __name__ == "__main__":
    main()