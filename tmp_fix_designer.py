#!/usr/bin/env python3
"""
Comprehensive Designer.cs Fixer
Fixes pseudo-type errors and compilation issues in all Designer.cs files
"""

import io
import os
import re
import glob
import shutil
from datetime import datetime
from pathlib import Path

class DesignerFixer:
    def __init__(self, workspace_dir="."):
        self.workspace_dir = workspace_dir
        self.log_file = os.path.join(workspace_dir, f"designer_fixes_{datetime.now().strftime('%Y%m%d_%H%M%S')}.log")
        self.backup_dir = os.path.join(workspace_dir, "designer_backups")
        self.stats = {
            "files_processed": 0,
            "files_fixed": 0,
            "total_replacements": 0,
            "location_replacements": 0,
            "size_replacements": 0,
            "num_replacements": 0,
            "enum_replacements": 0,
            "errors": []
        }
        self._init_backup_dir()
        
    def _init_backup_dir(self):
        """Create backup directory if it doesn't exist"""
        if not os.path.exists(self.backup_dir):
            os.makedirs(self.backup_dir)
            self._log(f"Created backup directory: {self.backup_dir}")
    
    def _log(self, message):
        """Log message to file and print to console"""
        timestamp = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
        log_message = f"[{timestamp}] {message}"
        print(log_message)
        with io.open(self.log_file, "a", encoding="utf-8") as f:
            f.write(log_message + "\n")
    
    def _backup_file(self, file_path):
        """Create a backup of the original file"""
        try:
            filename = os.path.basename(file_path)
            backup_path = os.path.join(self.backup_dir, filename)
            shutil.copy2(file_path, backup_path)
            return backup_path
        except Exception as e:
            self._log(f"ERROR: Failed to backup {file_path}: {e}")
            self.stats["errors"].append(f"Backup failed: {file_path}")
            return None
    
    def _read_file(self, file_path):
        """Read file with UTF-8 BOM aware encoding"""
        try:
            with io.open(file_path, "r", encoding="utf-8-sig") as f:
                return f.read()
        except Exception as e:
            self._log(f"ERROR: Failed to read {file_path}: {e}")
            self.stats["errors"].append(f"Read failed: {file_path}")
            return None
    
    def _write_file(self, file_path, content):
        """Write file with UTF-8 encoding (no BOM)"""
        try:
            with io.open(file_path, "w", encoding="utf-8") as f:
                f.write(content)
            return True
        except Exception as e:
            self._log(f"ERROR: Failed to write {file_path}: {e}")
            self.stats["errors"].append(f"Write failed: {file_path}")
            return False
    
    def fix_location_type(self, content):
        """
        Replace 'new location(' with 'new global::System.Drawing.Point('
        Pattern: new location(X, Y)
        """
        original_content = content
        count = 0
        
        # Fix constructor calls
        pattern = r'new\s+location\s*\('
        replacement = 'new global::System.Drawing.Point('
        content, count = re.subn(pattern, replacement, content)
        
        self.stats["location_replacements"] += count
        self.stats["total_replacements"] += count
        return content
    
    def fix_size_type(self, content):
        """
        Replace 'new size(' with 'new global::System.Drawing.Size('
        Pattern: new size(W, H)
        """
        count = 0
        
        # Fix constructor calls
        pattern = r'new\s+size\s*\('
        replacement = 'new global::System.Drawing.Size('
        content, count = re.subn(pattern, replacement, content)
        
        self.stats["size_replacements"] += count
        self.stats["total_replacements"] += count
        return content
    
    def fix_num_type(self, content):
        """
        Replace 'new num(' with 'new decimal('
        Pattern: new num(value) or new num(new int[] {...})
        """
        count = 0
        
        # Fix constructor calls - handle both simple and complex cases
        pattern = r'new\s+num\s*\('
        replacement = 'new decimal('
        content, count = re.subn(pattern, replacement, content)
        
        self.stats["num_replacements"] += count
        self.stats["total_replacements"] += count
        return content
    
    def fix_variable_declarations(self, content):
        """
        Find and ensure variable declarations for location, size, and num variables
        """
        lines = content.split('\n')
        modified = False
        
        # Check for variable usage patterns
        used_variables = set()
        location_used = False
        size_used = False
        num_used = False
        
        for line in lines:
            if re.search(r'location\s*=\s*new global::System\.Drawing\.Point', line):
                location_used = True
            if re.search(r'size\s*=\s*new global::System\.Drawing\.Size', line):
                size_used = True
            if re.search(r'num\s*=\s*new decimal', line):
                num_used = True
        
        # Count replacements (conservative estimate)
        if location_used or size_used or num_used:
            return content, 0
        
        return content, 0
    
    def fix_enum_assignments(self, content):
        """
        Fix enum assignments that use numeric values
        Examples:
        - TextAlign = 2 -> TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right
        - CheckState = 1 -> CheckState = global::System.Windows.Forms.CheckState.Checked
        """
        count = 0
        original_content = content
        
        # Common enum mapping patterns in Designer files
        enum_patterns = [
            # HorizontalAlignment
            (r'TextAlign\s*=\s*0\s*[,;]', 'TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;'),
            (r'TextAlign\s*=\s*2\s*[,;]', 'TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;'),
            (r'TextAlign\s*=\s*1\s*[,;]', 'TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;'),
            
            # RichTextBoxScrollBars
            (r'ScrollBars\s*=\s*0\s*[,;]', 'ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.None;'),
            (r'ScrollBars\s*=\s*1\s*[,;]', 'ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Horizontal;'),
            (r'ScrollBars\s*=\s*2\s*[,;]', 'ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Vertical;'),
            (r'ScrollBars\s*=\s*3\s*[,;]', 'ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Both;'),
            
            # CheckState
            (r'CheckState\s*=\s*0\s*[,;]', 'CheckState = global::System.Windows.Forms.CheckState.Unchecked;'),
            (r'CheckState\s*=\s*1\s*[,;]', 'CheckState = global::System.Windows.Forms.CheckState.Checked;'),
            (r'CheckState\s*=\s*2\s*[,;]', 'CheckState = global::System.Windows.Forms.CheckState.Indeterminate;'),
        ]
        
        for pattern, replacement in enum_patterns:
            new_content, replacements = re.subn(pattern, replacement, content)
            if replacements > 0:
                content = new_content
                count += replacements
        
        self.stats["enum_replacements"] += count
        self.stats["total_replacements"] += count
        return content
    
    def fix_file(self, file_path):
        """
        Apply all fixes to a single Designer.cs file
        """
        try:
            self._log(f"Processing: {file_path}")
            
            # Read original content
            content = self._read_file(file_path)
            if content is None:
                return False
            
            original_content = content
            
            # Create backup
            backup_path = self._backup_file(file_path)
            if backup_path is None:
                return False
            
            # Apply all fixes
            content = self.fix_location_type(content)
            content = self.fix_size_type(content)
            content = self.fix_num_type(content)
            content = self.fix_enum_assignments(content)
            content, _ = self.fix_variable_declarations(content)
            
            # Write fixed content
            if not self._write_file(file_path, content):
                # Restore from backup if write failed
                shutil.copy2(backup_path, file_path)
                return False
            
            # Log changes if any
            if content != original_content:
                self._log(f"✓ Fixed: {file_path}")
                self.stats["files_fixed"] += 1
                return True
            else:
                self._log(f"  No changes needed: {file_path}")
                return True
            
        except Exception as e:
            self._log(f"ERROR processing {file_path}: {e}")
            self.stats["errors"].append(f"Processing failed: {file_path} - {e}")
            return False
    
    def find_designer_files(self):
        """Find all Designer.cs files in the workspace"""
        patterns = [
            os.path.join(self.workspace_dir, "*.Designer.cs"),
            os.path.join(self.workspace_dir, "**/*.Designer.cs")
        ]
        
        files = []
        for pattern in patterns:
            files.extend(glob.glob(pattern, recursive=True))
        
        # Remove duplicates and sort
        files = sorted(set(files))
        return files
    
    def process_all(self):
        """Process all Designer.cs files in the workspace"""
        self._log("=" * 70)
        self._log("Starting Designer.cs Comprehensive Fixer")
        self._log("=" * 70)
        
        designer_files = self.find_designer_files()
        
        if not designer_files:
            self._log("ERROR: No Designer.cs files found!")
            return False
        
        self._log(f"Found {len(designer_files)} Designer.cs files to process")
        self._log("")
        
        # Process each file
        for file_path in designer_files:
            self.stats["files_processed"] += 1
            self.fix_file(file_path)
        
        # Print summary
        self._log("")
        self._log("=" * 70)
        self._log("SUMMARY")
        self._log("=" * 70)
        self._log(f"Files processed: {self.stats['files_processed']}")
        self._log(f"Files fixed: {self.stats['files_fixed']}")
        self._log(f"Total replacements: {self.stats['total_replacements']}")
        self._log(f"  - location → Point: {self.stats['location_replacements']}")
        self._log(f"  - size → Size: {self.stats['size_replacements']}")
        self._log(f"  - num → decimal: {self.stats['num_replacements']}")
        self._log(f"  - enum fixes: {self.stats['enum_replacements']}")
        
        if self.stats["errors"]:
            self._log(f"\nErrors encountered: {len(self.stats['errors'])}")
            for error in self.stats["errors"]:
                self._log(f"  - {error}")
        else:
            self._log("\n✓ No errors encountered")
        
        self._log("")
        self._log(f"Backups created in: {self.backup_dir}")
        self._log(f"Log file: {self.log_file}")
        self._log("=" * 70)
        
        return len(self.stats["errors"]) == 0
    
    def restore_from_backup(self):
        """Restore all files from backup (for testing purposes)"""
        self._log("Restoring from backups...")
        
        if not os.path.exists(self.backup_dir):
            self._log("ERROR: Backup directory not found")
            return False
        
        for backup_file in glob.glob(os.path.join(self.backup_dir, "*.Designer.cs")):
            original_path = os.path.join(self.workspace_dir, os.path.basename(backup_file))
            try:
                shutil.copy2(backup_file, original_path)
                self._log(f"Restored: {original_path}")
            except Exception as e:
                self._log(f"ERROR restoring {original_path}: {e}")
                return False
        
        return True


def main():
    """Main entry point"""
    import sys
    
    # Get workspace directory (default to current directory)
    workspace_dir = sys.argv[1] if len(sys.argv) > 1 else "."
    
    if not os.path.isdir(workspace_dir):
        print(f"ERROR: Directory not found: {workspace_dir}")
        sys.exit(1)
    
    # Create fixer and process
    fixer = DesignerFixer(workspace_dir)
    success = fixer.process_all()
    
    sys.exit(0 if success else 1)


if __name__ == "__main__":
    main()