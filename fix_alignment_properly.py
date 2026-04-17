#!/usr/bin/env python3
"""
Correção específica e cuidadosa de conversões de alignment
"""
import re

def fix_alignment_correctly():
    """Corrige conversões de alignment de forma específica"""
    
    # Apenas RT_850 Designer que tem problema
    files_to_fix = [
        'RT_850_conf.Designer.cs'
    ]
    
    for filename in files_to_fix:
        try:
            with open(filename, 'r', encoding='utf-8') as f:
                content = f.read()
            
            original = content
            
            # Converter APENAS DefaultCellStyle.Alignment
            # DataGridViewContentAlignment.Right -> MiddleRight
            content = re.sub(
                r'System\.Windows\.Forms\.DataGridViewContentAlignment\.Right',
                r'System.Windows.Forms.HorizontalAlignment.Right',
                content
            )
            
            # Converter .DefaultCellStyle.Alignment / .Alignment atribuições em DataGridView
            # .TextAlign = HorizontalAlignment é correto para TextAlign
            # .Alignment = DataGridViewContentAlignment é correto para DefaultCellStyle.Alignment
            content = re.sub(
                r'TextAlign\s*=\s*System\.Windows\.Forms\.DataGridViewContentAlignment\.(Left|Center|Right|MiddleLeft|MiddleCenter|MiddleRight)',
                lambda m: f'TextAlign = System.Windows.Forms.HorizontalAlignment.{m.group(1).replace("Middle", "")}',
                content
            )
            
            if content != original:
                with open(filename, 'w', encoding='utf-8') as f:
                    f.write(content)
                print(f'✅ {filename} corrigido')
                return True
        except Exception as e:
            print(f'❌ Erro em {filename}: {e}')
            return False
    
    return False

if __name__ == '__main__':
    fix_alignment_correctly()
