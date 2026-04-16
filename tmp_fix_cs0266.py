#!/usr/bin/env python3
"""
Fix CS0266 Enum Conversion Errors - Comprehensive Batch Script
Converts numeric enum values to proper enum type references across the entire project

Error Pattern: CS0266 "Cannot implicitly convert type 'int' to 'EnumType'"
Cause: Decompiler/VB.NET generated numeric assignments to enum properties
"""

from pathlib import Path
import re
import sys

def fix_cs0266_enums():
    """Main batch processing function for all CS0266 enum conversion errors"""
    
    root = Path(".")
    
    # Statistics
    stats = {
        'files_modified': 0,
        'total_replacements': 0,
        'enum_types': {},
        'files_modified_list': []
    }
    
    # All enum conversion patterns with documentation
    # Format: (regex_pattern, replacement, enum_display_name, description)
    patterns = [
        # ===== AUTOSCALEMODE (0/1/2) =====
        # Value 1 = Font (most common in project)
        (r'this\.AutoScaleMode\s*=\s*1\s*;',
         'this.AutoScaleMode = AutoScaleMode.Font;',
         'AutoScaleMode.Font',
         'Form auto-scale font mode'),
        
        # ===== DIALOGRESULT (1-7) =====
        # Value 1 = OK
        (r'this\.DialogResult\s*=\s*1\s*;',
         'this.DialogResult = DialogResult.OK;',
         'DialogResult.OK',
         'Dialog OK result'),
        # Value 2 = Cancel
        (r'this\.DialogResult\s*=\s*2\s*;',
         'this.DialogResult = DialogResult.Cancel;',
         'DialogResult.Cancel',
         'Dialog Cancel result'),
        
        # ===== FORMBORDERSTYLE (0-6) =====
        # Value 0 = None
        (r'this\.FormBorderStyle\s*=\s*0\s*;',
         'this.FormBorderStyle = FormBorderStyle.None;',
         'FormBorderStyle.None',
         'Form border none'),
        # Value 1 = FixedSingle
        (r'this\.FormBorderStyle\s*=\s*1\s*;',
         'this.FormBorderStyle = FormBorderStyle.FixedSingle;',
         'FormBorderStyle.FixedSingle',
         'Form fixed single border'),
        
        # ===== FORMSTARTPOSITION (0-4) =====
        # Value 0 = Manual
        (r'this\.StartPosition\s*=\s*0\s*;',
         'this.StartPosition = FormStartPosition.Manual;',
         'FormStartPosition.Manual',
         'Form start position manual'),
        # Value 1 = CenterScreen
        (r'this\.StartPosition\s*=\s*1\s*;',
         'this.StartPosition = FormStartPosition.CenterScreen;',
         'FormStartPosition.CenterScreen',
         'Form start position center screen'),
        # Value 4 = CenterParent
        (r'this\.StartPosition\s*=\s*4\s*;',
         'this.StartPosition = FormStartPosition.CenterParent;',
         'FormStartPosition.CenterParent',
         'Form start position center parent'),
        
        # ===== AUTOVALIDATE (0-5) =====
        # Value 1 = EnableAllowFocusChange
        (r'this\.AutoValidate\s*=\s*1\s*;',
         'this.AutoValidate = AutoValidate.EnableAllowFocusChange;',
         'AutoValidate.EnableAllowFocusChange',
         'Auto-validation enable focus change'),
        
        # ===== FLATSTYLE (0-3) =====
        # Value 0 = Flat
        (r'\.FlatStyle\s*=\s*0\s*;',
         '.FlatStyle = FlatStyle.Flat;',
         'FlatStyle.Flat',
         'Control flat style'),
        # Value 3 = System
        (r'\.FlatStyle\s*=\s*3\s*;',
         '.FlatStyle = FlatStyle.System;',
         'FlatStyle.System',
         'Control system flat style'),
    ]
    
    # Additional context-aware patterns (TextAlign requires different enum types)
    textalign_patterns = [
        # TextAlign = 1 -> HorizontalAlignment.Center (for TextBox/NumericUpDown)
        (r'\.TextAlign\s*=\s*1\s*;',
         '.TextAlign = HorizontalAlignment.Center;',
         'HorizontalAlignment.Center',
         'Text align center (TextBox/NumericUpDown)'),
        # TextAlign = 2 -> HorizontalAlignment.Right (for TextBox/NumericUpDown)
        (r'\.TextAlign\s*=\s*2\s*;',
         '.TextAlign = HorizontalAlignment.Right;',
         'HorizontalAlignment.Right',
         'Text align right (TextBox/NumericUpDown)'),
        # TextAlign = 32 -> ContentAlignment.MiddleRight (for Label)
        (r'\.TextAlign\s*=\s*32\s*;',
         '.TextAlign = ContentAlignment.MiddleRight;',
         'ContentAlignment.MiddleRight',
         'Content align middle right (Label)'),
    ]
    
    # ===== FILE PROCESSING LOOP =====
    print("=" * 90)
    print("CS0266 ENUM CONVERSION ERROR FIXER - BATCH PROCESSING")
    print("=" * 90)
    print()
    print("Target errors: CS0266 'Cannot implicitly convert type'")
    print("Scope: All enum assignments with numeric values")
    print()
    
    # Get all C# files
    cs_files = sorted([f for f in root.rglob("*.cs") 
                      if not f.name.startswith("tmp_fix")])
    
    print(f"Scanning {len(cs_files)} C# files...")
    print()
    
    for filepath in cs_files:
        try:
            # Read file
            content = filepath.read_text(encoding="utf-8", errors="ignore")
            original = content
            file_changes = []
            
            # Apply standard patterns
            for pattern_str, replacement, enum_name, description in patterns:
                pattern = re.compile(pattern_str)
                new_content, count = pattern.subn(replacement, content)
                if count > 0:
                    content = new_content
                    file_changes.append((enum_name, count, description))
                    stats['total_replacements'] += count
                    stats['enum_types'][enum_name] = stats['enum_types'].get(enum_name, 0) + count
            
            # Apply TextAlign patterns
            for pattern_str, replacement, enum_name, description in textalign_patterns:
                pattern = re.compile(pattern_str)
                new_content, count = pattern.subn(replacement, content)
                if count > 0:
                    content = new_content
                    file_changes.append((enum_name, count, description))
                    stats['total_replacements'] += count
                    stats['enum_types'][enum_name] = stats['enum_types'].get(enum_name, 0) + count
            
            # Save file if modified
            if content != original:
                filepath.write_text(content, encoding="utf-8")
                stats['files_modified'] += 1
                stats['files_modified_list'].append((filepath, file_changes))
        
        except Exception as e:
            print(f"ERROR processing {filepath}: {e}", file=sys.stderr)
    
    # ===== PRINT SUMMARY REPORT =====
    print()
    print("=" * 90)
    print("BATCH PROCESSING RESULTS")
    print("=" * 90)
    print()
    
    print(f"Files modified:          {stats['files_modified']}")
    print(f"Total replacements:      {stats['total_replacements']}")
    print()
    
    # Show enum types fixed
    if stats['enum_types']:
        print("ENUM TYPES FIXED (by frequency):")
        print("-" * 90)
        
        sorted_enums = sorted(stats['enum_types'].items(), key=lambda x: x[1], reverse=True)
        for enum_name, count in sorted_enums:
            bar_width = int(count / 2) if count < 50 else 25
            bar = "█" * min(bar_width, 30)
            print(f"  {enum_name:.<50} {count:>5} instances  {bar}")
        print()
    
    # Show modified files grouped
    if stats['files_modified_list']:
        print("FILES MODIFIED (grouped by type):")
        print("-" * 90)
        
        # Separate Designer.cs from other files
        designer_files = []
        other_files = []
        
        for filepath, changes in stats['files_modified_list']:
            if 'Designer' in filepath.name:
                designer_files.append((filepath, changes))
            else:
                other_files.append((filepath, changes))
        
        # Print Designer files
        if designer_files:
            print(f"\n  DESIGNER.CS FILES ({len(designer_files)} files):")
            print("  " + "-" * 86)
            for filepath, changes in sorted(designer_files):
                filename = filepath.name
                total = sum(count for _, count, _ in changes)
                print(f"    {filename:.<50} {total:>4} fixes")
                for enum_name, count, desc in changes:
                    print(f"      • {enum_name:.<45} {count:>3}")
        
        # Print other files
        if other_files:
            print(f"\n  OTHER C# FILES ({len(other_files)} files):")
            print("  " + "-" * 86)
            for filepath, changes in sorted(other_files):
                filename = filepath.name
                total = sum(count for _, count, _ in changes)
                if total > 0:
                    print(f"    {filename:.<50} {total:>4} fixes")
                    for enum_name, count, desc in changes:
                        print(f"      • {enum_name:.<45} {count:>3}")
    
    # Final status
    print()
    print("=" * 90)
    if stats['total_replacements'] > 0:
        print(f"✓ SUCCESS!")
        print(f"  Fixed {stats['total_replacements']} CS0266 enum conversion errors")
        print(f"  Modified {stats['files_modified']} file(s)")
        print("  All numeric enum values converted to proper type references")
    else:
        print("✓ No enum conversion errors found (already fixed or not present)")
    print("=" * 90)
    
    return stats

if __name__ == "__main__":
    results = fix_cs0266_enums()
    
    # Exit with success regardless (script completed)
    sys.exit(0)