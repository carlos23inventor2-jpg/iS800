#!/usr/bin/env python3
"""
Comprehensive CS0266 Enum Conversion Fixer for iS800 Project
Fixes ALL 200+ numeric enum assignments in one pass
"""

from pathlib import Path
import re
import sys
from collections import defaultdict
from datetime import datetime

class CS0266Fixer:
    """Complete enum pattern fixer"""
    
    # All patterns based on actual build output analysis
    ENUM_FIXES = {
        'StartPosition': {
            'enum_values': {0: 'FormStartPosition.Manual', 1: 'FormStartPosition.CenterScreen',
                           2: 'FormStartPosition.WindowsDefaultLocation', 3: 'FormStartPosition.WindowsDefaultBounds',
                           4: 'FormStartPosition.CenterParent'},
            'found': 20
        },
        'SizeGripStyle': {
            'enum_values': {0: 'SizeGripStyle.Auto', 1: 'SizeGripStyle.Show', 2: 'SizeGripStyle.Hide'},
            'found': 2
        },
        'WindowState': {
            'enum_values': {0: 'FormWindowState.Normal', 1: 'FormWindowState.Minimized', 2: 'FormWindowState.Maximized'},
            'found': 2
        },
        'BorderStyle': {
            'enum_values': {0: 'BorderStyle.None', 1: 'BorderStyle.FixedSingle', 2: 'BorderStyle.Fixed3D'},
            'found': 50
        },
        'FormBorderStyle': {
            'enum_values': {0: 'FormBorderStyle.None', 1: 'FormBorderStyle.FixedSingle', 2: 'FormBorderStyle.Fixed3D',
                           3: 'FormBorderStyle.FixedDialog', 4: 'FormBorderStyle.Sizable', 
                           5: 'FormBorderStyle.FixedToolWindow', 6: 'FormBorderStyle.SizableToolWindow'},
            'found': 1
        },
        'CellBorderStyle': {
            'enum_values': {0: 'DataGridViewCellBorderStyle.None', 1: 'DataGridViewCellBorderStyle.Single',
                           2: 'DataGridViewCellBorderStyle.Raised', 3: 'DataGridViewCellBorderStyle.Sunken',
                           4: 'DataGridViewCellBorderStyle.SingleVertical', 5: 'DataGridViewCellBorderStyle.SingleHorizontal'},
            'found': 50
        },
        'RowHeadersBorderStyle': {
            'enum_values': {0: 'DataGridViewHeaderBorderStyle.Custom', 1: 'DataGridViewHeaderBorderStyle.Single',
                           2: 'DataGridViewHeaderBorderStyle.Raised', 3: 'DataGridViewHeaderBorderStyle.Sunken'},
            'found': 10
        },
        'Parity': {
            'enum_values': {0: 'Parity.None', 1: 'Parity.Odd', 2: 'Parity.Even', 3: 'Parity.Mark', 4: 'Parity.Space'},
            'found': 1
        },
        'StopBits': {
            'enum_values': {0: 'StopBits.None', 1: 'StopBits.One', 2: 'StopBits.Two'},
            'found': 1
        },
        'DialogResult': {
            'enum_values': {0: 'DialogResult.None', 1: 'DialogResult.OK', 2: 'DialogResult.Cancel',
                           3: 'DialogResult.Abort', 4: 'DialogResult.Retry', 5: 'DialogResult.Ignore',
                           6: 'DialogResult.Yes', 7: 'DialogResult.No'},
            'found': 2
        },
        'FlatStyle': {
            'enum_values': {0: 'FlatStyle.Flat', 1: 'FlatStyle.Popup', 2: 'FlatStyle.Standard', 3: 'FlatStyle.System'},
            'found': 2
        },
        'AutoScaleMode': {
            'enum_values': {0: 'AutoScaleMode.None', 1: 'AutoScaleMode.Font', 2: 'AutoScaleMode.Dpi'},
            'found': 0  # Usually already fixed
        },
        'DockStyle': {
            'enum_values': {0: 'DockStyle.None', 1: 'DockStyle.Top', 2: 'DockStyle.Bottom',
                           3: 'DockStyle.Left', 4: 'DockStyle.Right', 5: 'DockStyle.Fill'},
            'found': 0
        },
        'ShutdownStyle': {
            'enum_values': {0: 'ShutdownMode.AfterMainFormCloses', 1: 'ShutdownMode.AfterAllFormsClose'},
            'found': 1
        },
    }
    
    def __init__(self):
        self.stats = defaultdict(int)
        self.modified_files = []
        self.total_fixes = 0
    
    def fix_all_files(self):
        """Process all C# files and fix enum conversions"""
        print("\n" + "="*80)
        print("CS0266 ENUM CONVERSION FIXER - COMPREHENSIVE BATCH MODE".center(80))
        print("="*80 + "\n")
        print("Patterns to fix:")
        for enum_type, info in self.ENUM_FIXES.items():
            print(f"  • {enum_type:.<50} Expected: {info['found']:>3} instances")
        print("\n" + "="*80 + "\n")
        
        # Get all C# files
        root = Path('.')
        cs_files = [f for f in root.rglob('*.cs')
                   if 'designer_backups' not in f.parts and 'bin' not in f.parts
                   and 'obj' not in f.parts]
        
        print(f"Scanning {len(cs_files)} files...\n")
        
        for filepath in sorted(cs_files):
            self._fix_file(filepath)
        
        # Report
        self._print_summary()
        return self.total_fixes
    
    def _fix_file(self, filepath):
        """Fix enum conversions in a single file"""
        try:
            content = filepath.read_text(encoding='utf-8')
            original = content
            file_fixes = {}
            
            # Apply all enum conversions
            for enum_type, config in self.ENUM_FIXES.items():
                for num_val, enum_name in config['enum_values'].items():
                    pattern = rf'(\w+\.{enum_type})\s*=\s*{re.escape(str(num_val))}\s*;'
                    matches = len(re.findall(pattern, content))
                    
                    if matches > 0:
                        content = re.sub(pattern, rf'\1 = {enum_name};', content)
                        file_fixes[f'{enum_type}({enum_name})'] = matches
                        self.stats[enum_type] += matches
            
            if content != original:
                filepath.write_text(content, encoding='utf-8')
                self.modified_files.append((filepath.name, file_fixes))
                self.total_fixes += sum(file_fixes.values())
                print(f"✓ {filepath.name:<50} +{sum(file_fixes.values())} fixes")
        
        except Exception as e:
            print(f"✗ Error processing {filepath.name}: {e}")
    
    def _print_summary(self):
        """Print final summary report"""
        print("\n" + "="*80)
        print("SUMMARY".center(80))
        print("="*80 + "\n")
        
        print(f"Files modified: {len(self.modified_files)}")
        print(f"Total fixes applied: {sum(self.stats.values())}\n")
        
        if self.stats:
            print("Fixes by enum type (sorted by count):")
            for enum_type in sorted(self.stats.keys(), key=lambda k: self.stats[k], reverse=True):
                count = self.stats[enum_type]
                bar = "█" * min(count // 2, 40)
                print(f"  {enum_type:<30} {count:>4} instances  {bar}")
        
        print("\n" + "="*80)
        if self.total_fixes > 0:
            print(f"✓ SUCCESS: Fixed {self.total_fixes} CS0266 enum conversion errors".center(80))
        else:
            print("✓ No errors found - project may already be fixed".center(80))
        print("="*80 + "\n")


if __name__ == '__main__':
    fixer = CS0266Fixer()
    count = fixer.fix_all_files()
    sys.exit(0)