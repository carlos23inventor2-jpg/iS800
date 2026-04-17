#!/usr/bin/env python3
"""
Script para corrigir os erros restantes do projeto
"""
import re

def fix_rt850_conf():
    """Corrige errors em RT_850_conf.cs"""
    with open('RT_850_conf.cs', 'r', encoding='utf-8') as f:
        content = f.read()
    
    original = content
    
    # Remover finally blocks com enumerator não inicializado
    # Padrão: finally { List<T>.Enumerator e; e.Dispose(); }
    content = re.sub(
        r'finally\s*\{\s*List<[^>]+>\.Enumerator\s+\w+;?\s*\w+\.Dispose\(\);?\s*\}',
        '',
        content
    )
    
    # Inicializar Integer_ictel structs
    content = re.sub(
        r'RT_geral\.Integer_ictel\s+(\w+);',
        r'RT_geral.Integer_ictel \1 = new RT_geral.Integer_ictel();',
        content
    )
    
    # Inicializar result = false no switch global
    content = re.sub(
        r'(\s+)switch\s*\(\s*z\s*\)\s*\n\s*\{',
        r'\1bool result = false;\n\1switch (z)\n\1{',
        content
    )
    
    # HorizontalAlignment -> DataGridViewContentAlignment em .cs
    content = re.sub(
        r'\.DefaultCellStyle\.Alignment\s*=\s*System\.Windows\.Forms\.HorizontalAlignment\.(\w+)',
        r'.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.\1',
        content
    )
    content = re.sub(
        r'\.Alignment\s*=\s*System\.Windows\.Forms\.HorizontalAlignment\.(\w+)',
        r'.Alignment = System.Windows.Forms.DataGridViewContentAlignment.\1',
        content
    )
    
    if content != original:
        with open('RT_850_conf.cs', 'w', encoding='utf-8') as f:
            f.write(content)
        print("✓ RT_850_conf.cs corrigido")
        return True
    return False

def fix_rt850_designer():
    """Corrige RT_850_conf.Designer.cs"""
    with open('RT_850_conf.Designer.cs', 'r', encoding='utf-8') as f:
        content = f.read()
    
    original = content
    
    # Corrigir erro CS0119 - Size atribuindo a tipo
    # Padrão: global::System.Drawing.Size = new ...;
    content = re.sub(
        r'global::System\.Drawing\.Size\s*=\s*new\s+global::System\.Drawing\.Size',
        r'global::System.Drawing.Size imageSize = new global::System.Drawing.Size',
        content
    )
    
    # Corrigir referência a Size após atribuição
    content = re.sub(
        r'toolStri_RT\.ImageScalingSize\s*=\s*Size;',
        r'toolStri_RT.ImageScalingSize = imageSize;',
        content
    )
    
    # HorizontalAlignment -> DataGridViewContentAlignment
    content = re.sub(
        r'System\.Windows\.Forms\.HorizontalAlignment\.(\w+)',
        r'System.Windows.Forms.DataGridViewContentAlignment.\1',
        content
    )
    
    if content != original:
        with open('RT_850_conf.Designer.cs', 'w', encoding='utf-8') as f:
            f.write(content)
        print("✓ RT_850_conf.Designer.cs corrigido")
        return True
    return False

def main():
    if fix_rt850_conf():
        print("✅ RT_850_conf.cs corrigido com sucesso")
    
    if fix_rt850_designer():
        print("✅ RT_850_conf.Designer.cs corrigido com sucesso")
    
    print("\n✅ Script de correções completed")

if __name__ == '__main__':
    main()
