#!/usr/bin/env python3
"""
Simplified batch fixer for remaining compilation errors
Focuses on the most common patterns that cause the most errors
"""

import os
import re
import glob

def fix_common_errors_simplified():
    """Apply simplified fixes for common error patterns"""

    # Get all C# files
    cs_files = glob.glob("*.cs")

    total_fixes = 0
    files_modified = 0

    for filepath in sorted(cs_files):
        try:
            with open(filepath, 'r', encoding='utf-8') as f:
                content = f.read()

            original = content

            # FIX 1: Remove duplicate DesignerGeneratedAttribute (CS0579)
            content = re.sub(
                r'\[Microsoft\.VisualBasic\.CompilerServices\.DesignerGeneratedAttribute\(\)\]\s*',
                '',
                content
            )

            # FIX 2: Fix static member access issues (CS0176)
            # AutoScaleMode.Font -> global::System.Windows.Forms.AutoScaleMode.Font
            content = re.sub(
                r'(\w+)\.AutoScaleMode\.Font',
                r'global::System.Windows.Forms.AutoScaleMode.Font',
                content
            )

            # FormBorderStyle.* -> global::System.Windows.Forms.FormBorderStyle.*
            content = re.sub(
                r'(\w+)\.FormBorderStyle\.(\w+)',
                r'global::System.Windows.Forms.FormBorderStyle.\2',
                content
            )

            # SizeGripStyle.* -> global::System.Windows.Forms.SizeGripStyle.*
            content = re.sub(
                r'(\w+)\.SizeGripStyle\.(\w+)',
                r'global::System.Windows.Forms.SizeGripStyle.\2',
                content
            )

            # FIX 3: Fix enum conversions (CS0266)
            # Parity numeric assignments
            content = re.sub(
                r'Parity\s*=\s*0\s*;',
                r'Parity = Parity.None;',
                content
            )
            content = re.sub(
                r'Parity\s*=\s*1\s*;',
                r'Parity = Parity.Odd;',
                content
            )
            content = re.sub(
                r'Parity\s*=\s*2\s*;',
                r'Parity = Parity.Even;',
                content
            )

            # StopBits numeric assignments
            content = re.sub(
                r'StopBits\s*=\s*1\s*;',
                r'StopBits = StopBits.One;',
                content
            )
            content = re.sub(
                r'StopBits\s*=\s*2\s*;',
                r'StopBits = StopBits.Two;',
                content
            )

            # FIX 4: Initialize unassigned variables (CS0165)
            content = re.sub(
                r'(;\s*)Point\s+point\s*;',
                r'\1Point point = new Point();',
                content
            )
            content = re.sub(
                r'(;\s*)IEnumerator\s+enumerator\s*;',
                r'\1IEnumerator enumerator = null;',
                content
            )

            # FIX 5: Fix DialogResult comparisons (CS0019)
            content = re.sub(
                r'DialogResult\s*==\s*1\s*;',
                r'DialogResult == DialogResult.OK;',
                content
            )
            content = re.sub(
                r'DialogResult\s*==\s*6\s*;',
                r'DialogResult == DialogResult.Yes;',
                content
            )
            content = re.sub(
                r'DialogResult\s*!=\s*6\s*;',
                r'DialogResult != DialogResult.Yes;',
                content
            )

            if content != original:
                with open(filepath, 'w', encoding='utf-8') as f:
                    f.write(content)
                total_fixes += 1
                files_modified += 1
                print(f"✓ {filepath}")

        except Exception as e:
            print(f"✗ Error processing {filepath}: {e}")

    print(f"\n{'='*60}")
    print("SIMPLIFIED BATCH FIX SUMMARY".center(60))
    print(f"{'='*60}")
    print(f"Files processed: {len(cs_files)}")
    print(f"Files modified: {files_modified}")
    print(f"Total fixes applied: {total_fixes}")
    print(f"{'='*60}")

    return total_fixes

if __name__ == '__main__':
    os.chdir("/home/carlos/Desktop/tet/dec/iS800")
    fix_common_errors_simplified()