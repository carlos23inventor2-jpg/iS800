#!/usr/bin/env python3
"""
Comprehensive fixer for RT_geral.cs compilation errors:
- Fixes MessageBox.Show() magic number arguments
- Fixes DialogResult magic number comparisons
- Handles MsgBoxStyle conversions
"""

import os
import re

def fix_rt_geral():
    file_path = "RT_geral.cs"

    if not os.path.exists(file_path):
        print(f"Error: {file_path} not found")
        return False

    with open(file_path, 'r', encoding='utf-8') as f:
        content = f.read()

    original_content = content
    replacement_count = 0

    # FIX 1: MessageBox.Show with magic number 4 (MessageBoxButtons.YesNo)
    # Pattern: MessageBox.Show(..., 4) where 4 is the third parameter (buttons)
    pattern1 = r'MessageBox\.Show\s*\(\s*"([^"]+)"\s*,\s*(\w+)\s*,\s*4\s*\)'
    replacement1 = r'MessageBox.Show("\1", \2, MessageBoxButtons.YesNo)'
    matches = re.findall(pattern1, content)
    if matches:
        content = re.sub(pattern1, replacement1, content)
        replacement_count += len(matches)
        print(f"✓ Fixed {len(matches)} MessageBox.Show(text, msg, 4) calls -> MessageBoxButtons.YesNo")

    # FIX 2: DialogResult comparison with magic number 6 (DialogResult.Yes when using YesNo buttons)
    # Pattern: != 6 or == 6 when comparing DialogResult
    pattern2 = r'!=\s*6(?=\s*[;)])'
    replacement2 = r'!= DialogResult.Yes'
    matches = re.findall(pattern2, content)
    if matches:
        new_content = re.sub(pattern2, replacement2, content)
        if new_content != content:
            replacement_count += len(matches)
            content = new_content
            print(f"✓ Fixed {len(matches)} DialogResult != 6 comparisons -> != DialogResult.Yes")

    # FIX 3: DialogResult == 6 (rare but handle it)
    pattern3 = r'==\s*6(?=\s*[;)])'
    replacement3 = r'== DialogResult.Yes'
    matches = re.findall(pattern3, content)
    if matches:
        new_content = re.sub(pattern3, replacement3, content)
        if new_content != content:
            replacement_count += len(matches)
            content = new_content
            print(f"✓ Fixed {len(matches)} DialogResult == 6 comparisons -> == DialogResult.Yes")

    # FIX 4: MsgBoxStyle magic number 16 (MsgBoxStyle.Exclamation/Information)
    # Pattern: Interaction.MsgBox(text, 16, title)
    pattern4 = r'Interaction\.MsgBox\s*\(\s*(\w+)\s*,\s*16\s*,'
    replacement4 = r'Interaction.MsgBox(\1, MsgBoxStyle.Information,'
    matches = re.findall(pattern4, content)
    if matches:
        content = re.sub(pattern4, replacement4, content)
        replacement_count += len(matches)
        print(f"✓ Fixed {len(matches)} Interaction.MsgBox(text, 16, ...) calls -> MsgBoxStyle.Information")

    # FIX 5: MsgBoxStyle magic number 20 (MsgBoxStyle.Question)
    # Pattern: Interaction.MsgBox(text, 20, title)
    pattern5 = r'Interaction\.MsgBox\s*\(\s*(\w+)\s*,\s*20\s*,'
    replacement5 = r'Interaction.MsgBox(\1, MsgBoxStyle.Question,'
    matches = re.findall(pattern5, content)
    if matches:
        content = re.sub(pattern5, replacement5, content)
        replacement_count += len(matches)
        print(f"✓ Fixed {len(matches)} Interaction.MsgBox(text, 20, ...) calls -> MsgBoxStyle.Question")

    # Check if we made changes
    if content != original_content:
        with open(file_path, 'w', encoding='utf-8') as f:
            f.write(content)

        print(f"\n✅ SUCCESS: {file_path} updated")
        print(f"   Total replacements: {replacement_count}")
        return True
    else:
        print(f"\n⚠️  No changes made to {file_path}")
        return False

if __name__ == "__main__":
    success = fix_rt_geral()
    exit(0 if success else 1)