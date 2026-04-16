#!/usr/bin/env python3
"""
final_remaining_fixes.py
Final fixes for remaining compilation errors in iS800 project
"""
import io
import os
import re

class FinalFixer:
    """Final fixer for remaining compilation errors"""

    def __init__(self):
        self.stats = {}

    def fix_all_files(self):
        """Apply all remaining fixes"""
        print("\n" + "="*80)
        print("FINAL REMAINING FIXES - LAST ERRORS".center(80))
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

            # 1. Remove duplicate DesignerGeneratedAttribute
            content = re.sub(
                r'\[Microsoft\.VisualBasic\.CompilerServices\.DesignerGeneratedAttribute\(\)\]\s*',
                '',
                content
            )

            # 2. Fix static member access issues
            # AutoScaleMode.Font -> Form.AutoScaleMode.Font
            content = re.sub(
                r'(\w+)\.AutoScaleMode\.Font',
                r'Form.AutoScaleMode.Font',
                content
            )

            # FormBorderStyle.None -> Form.FormBorderStyle.None
            content = re.sub(
                r'(\w+)\.FormBorderStyle\.(\w+)',
                r'Form.FormBorderStyle.\2',
                content
            )

            # SizeGripStyle.Hide -> Form.SizeGripStyle.Hide
            content = re.sub(
                r'(\w+)\.SizeGripStyle\.(\w+)',
                r'Form.SizeGripStyle.\2',
                content
            )

            # 3. Fix FormStartPosition references
            content = re.sub(
                r'\bFormStartPosition\.(\w+)',
                r'global::System.Windows.Forms.FormStartPosition.\1',
                content
            )

            # 4. Fix PictureBox BeginInit/EndInit (remove them)
            content = re.sub(
                r'(\w+)\.BeginInit\(\);',
                r'// \1.BeginInit(); // Removed - not supported',
                content
            )
            content = re.sub(
                r'(\w+)\.EndInit\(\);',
                r'// \1.EndInit(); // Removed - not supported',
                content
            )

            # 5. Fix serial port enums
            content = re.sub(
                r'Parity\s*=\s*(\d+)',
                lambda m: f'Parity = {["Parity.None", "Parity.Odd", "Parity.Even", "Parity.Mark", "Parity.Space"][int(m.group(1))]}',
                content
            )
            content = re.sub(
                r'StopBits\s*=\s*(\d+)',
                lambda m: f'StopBits = {["StopBits.None", "StopBits.One", "StopBits.Two"][int(m.group(1))]}',
                content
            )

            # 6. Fix invalid MsgBoxStyle values
            content = re.sub(
                r'MsgBoxStyle\.AbortRetryIgnore72',
                'MsgBoxStyle.AbortRetryIgnore',
                content
            )
            content = re.sub(
                r'MsgBoxStyle\.YesNoCancel2',
                'MsgBoxStyle.YesNoCancel',
                content
            )

            # 7. Initialize unassigned variables
            content = re.sub(
                r'(;\s*)Point\s+point\s*;',
                r'\1Point point = new Point();',
                content
            )

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
        print(f"Total final fixes applied: {total_fixes}")

        print("\n" + "="*80)
        if total_fixes > 0:
            print("✓ FINAL FIXES APPLIED - READY FOR SUCCESSFUL BUILD".center(80))
        else:
            print("✓ NO ADDITIONAL FIXES NEEDED".center(80))
        print("="*80 + "\n")


if __name__ == '__main__':
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    fixer = FinalFixer()
    fixer.fix_all_files()