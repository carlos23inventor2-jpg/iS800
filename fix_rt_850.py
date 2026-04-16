#!/usr/bin/env python3
import re

def fix_rt_850_conf():
    with open('RT_850_conf.cs', 'r', encoding='utf-8-sig') as f:
        content = f.read()
    
    # Fix DataGridView CellBorderStyle = 1
    content = re.sub(r'(\.CellBorderStyle\s*=\s*)1\s*;', r'\1DataGridViewCellBorderStyle.Single;', content)
    
    # Fix DataGridView DefaultCellStyle.Alignment = 64
    content = re.sub(r'(\.DefaultCellStyle\.Alignment\s*=\s*)64\s*;', r'\1DataGridViewContentAlignment.MiddleRight;', content)
    
    # Fix DataGridView DefaultCellStyle.Alignment = 32
    content = re.sub(r'(\.DefaultCellStyle\.Alignment\s*=\s*)32\s*;', r'\1DataGridViewContentAlignment.MiddleCenter;', content)
    
    # Fix unassigned num5
    content = re.sub(r'(int\s+num5\s*);', r'\1 = 0;', content)
    
    with open('RT_850_conf.cs', 'w', encoding='utf-8') as f:
        f.write(content)
    
    print("Fixed RT_850_conf.cs")

if __name__ == "__main__":
    fix_rt_850_conf()