#!/usr/bin/env python3
"""
final_comprehensive_fixer.py
Final comprehensive fixer for all remaining compilation errors in iS800 project
"""
import io
import os
import re

class FinalFixer:
    """Comprehensive fixer for all remaining compilation errors"""

    def __init__(self):
        self.stats = {}

    def fix_all_files(self):
        """Apply all remaining fixes"""
        print("\n" + "="*80)
        print("FINAL COMPREHENSIVE FIXER - ALL REMAINING ERRORS".center(80))
        print("="*80 + "\n")

        # Get all C# files
        cs_files = [f for f in os.listdir('.') if f.endswith('.cs')]

        total_fixes = 0
        files_modified = 0

        for filepath in sorted(cs_files):
            fixes = self._fix_file(filepath)
            if fixes > 0:
                total_fixes += fixes
                files_modified += 1
                print(f"✓ {filepath:<50} +{fixes} fixes")

        # Summary
        self._print_summary(total_fixes, files_modified)
        return total_fixes

    def _fix_file(self, filepath):
        """Apply all fixes to a single file"""
        try:
            with io.open(filepath, 'r', encoding='utf-8-sig') as f:
                content = f.read()

            original = content
            file_fixes = 0

            # 1. Fix DataGridViewContentAlignment numeric assignments
            alignment_map = {
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

            for num_val, enum_val in alignment_map.items():
                pattern = rf'\(DataGridViewContentAlignment\){re.escape(num_val)}'
                content = re.sub(pattern, enum_val, content)

            # 2. Fix unassigned variables
            content = re.sub(r'(;\s*)IEnumerator\s+enumerator\s*;', r'\1IEnumerator enumerator = null;', content)
            content = re.sub(r'(;\s*)int\s+integer_ictel\s*;', r'\1int integer_ictel = 0;', content)

            # 3. Fix DataGridViewScrollBars type references (different pattern)
            content = re.sub(r'\bDataGridViewScrollBars\.(\w+)', r'System.Windows.Forms.DataGridViewScrollBars.\1', content)

            # 4. Fix DataGridViewDataErrorContexts numeric assignments
            error_contexts_map = {
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

            for num_val, enum_val in error_contexts_map.items():
                pattern = rf'\(DataGridViewDataErrorContexts\){re.escape(num_val)}'
                content = re.sub(pattern, enum_val, content)

            # 5. Fix MsgBoxStyle numeric assignments
            msgbox_map = {
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
            }

            for num_val, enum_val in msgbox_map.items():
                pattern = rf'\(MsgBoxStyle\){re.escape(num_val)}'
                content = re.sub(pattern, enum_val, content)

            # 6. Fix DialogResult comparisons
            dialog_map = {
                '1': 'DialogResult.OK',
                '2': 'DialogResult.Cancel',
                '3': 'DialogResult.Abort',
                '4': 'DialogResult.Retry',
                '5': 'DialogResult.Ignore',
                '6': 'DialogResult.Yes',
                '7': 'DialogResult.No',
            }

            for num_val, enum_val in dialog_map.items():
                pattern = rf'(DialogResult\.\w+)\s*==\s*{re.escape(num_val)}'
                content = re.sub(pattern, rf'\1 == {enum_val}', content)

            if content != original:
                with io.open(filepath, 'w', encoding='utf-8-sig') as f:
                    f.write(content)
                return 1  # File was modified

        except Exception as e:
            print(f"✗ Error processing {filepath}: {e}")

        return 0

    def _print_summary(self, total_fixes, files_modified):
        """Print final summary"""
        print("\n" + "="*80)
        print("FINAL SUMMARY".center(80))
        print("="*80 + "\n")

        print(f"Files modified: {files_modified}")
        print(f"Total comprehensive fixes applied: {total_fixes}")

        print("\n" + "="*80)
        if total_fixes > 0:
            print("✓ COMPREHENSIVE FIXES APPLIED - READY FOR FINAL BUILD".center(80))
        else:
            print("✓ NO ADDITIONAL FIXES NEEDED".center(80))
        print("="*80 + "\n")


if __name__ == '__main__':
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    fixer = FinalFixer()
    fixer.fix_all_files()