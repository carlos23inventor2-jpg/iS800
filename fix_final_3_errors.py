#!/usr/bin/env python3
"""
Script muito cuidadoso para corrigir os 3 erros restantes
"""
import re

def fix_rt850_conf_carefully():
    """Corrige apenas os padrões específicos"""
    with open('RT_850_conf.cs', 'r', encoding='utf-8-sig') as f:
        lines = f.readlines()
    
    modified = False
    output_lines = []
    i = 0
    while i < len(lines):
        line = lines[i]
        
        # Padrão 1: HorizontalAlignment cast duplo
        if 'DefaultCellStyle.Alignment' in line and 'HorizontalAlignment)' in line:
            # Remover o cast duplo
            line = re.sub(
                r'\(System\.Windows\.Forms\.HorizontalAlignment\)\s*\(System\.Windows\.Forms\.HorizontalAlignment\)',
                '',
                line
            )
            modified = True
        
        # Padrão 2: Remover finally blocks orphaned (sem try correspondente válido)
        # Procurar por: foreach ... } } finally { Enumerator ... Dispose(); }
        if 'finally' in line and i + 2 < len(lines):
            next_line = lines[i + 1] if i + 1 < len(lines) else ''
            next_next_line = lines[i + 2] if i + 2 < len(lines) else ''
            
            if 'Enumerator' in next_line and 'Dispose' in next_next_line:
                # Skip this finally block (3 linhas)
                i += 4  # Pula finally, {, Enumerator, e Dispose.DisposeAsync();
                continue
        
        # Padrão 3: Inicializar int num = 0; mesmo quando not at início
        if re.search(r'\bint\s+num\s*;(?!.*=)', line) and 'num' not in output_lines[-1] if output_lines else True:
            line = re.sub(r'\bint\s+num\s*;', 'int num = 0;', line)
            modified = True
        
        # Padrão 4: Inicializar result = false
        if 'switch (z)' in line and i > 0:
            prev_line = output_lines[-1] if output_lines else ''
            if 'bool result' not in prev_line:
                # Adicionar bool result = false antes do switch
                indent = len(line) - len(line.lstrip())
                output_lines.append(' ' * indent + 'bool result = false;\n')
                modified = True
        
        output_lines.append(line)
        i += 1
    
    if modified:
        with open('RT_850_conf.cs', 'w', encoding='utf-8') as f:
            f.writelines(output_lines)
        print("✅ RT_850_conf.cs corrigido com sucesso")
        return True
    return False

def fix_designer_carefully():
    """Corrige RT_850_conf.Designer.cs"""
    with open('RT_850_conf.Designer.cs', 'r', encoding='utf-8-sig') as f:
        content = f.read()
    
    original = content
    
    # Problema: global::System.Drawing.Size = new ... em Designer
    # e depois referência a Size como se fosse variável
    # Padrão: global::System.Drawing.Size = new global::System.Drawing.Size(48, 48);
    #         toolStri_RT.ImageScalingSize = Size;
    
    # Solução: criar uma variável
    content = re.sub(
        r'global::System\.Drawing\.Size\s*=\s*new\s+global::System\.Drawing\.Size\s*\(\s*48\s*,\s*48\s*\)',
        'global::System.Drawing.Size imageSize = new global::System.Drawing.Size(48, 48)',
        content
    )
    content = re.sub(
        r'toolStri_RT\.ImageScalingSize\s*=\s*Size;',
        'toolStri_RT.ImageScalingSize = imageSize;',
        content
    )
    
    if content != original:
        with open('RT_850_conf.Designer.cs', 'w', encoding='utf-8') as f:
            f.write(content)
        print("✅ RT_850_conf.Designer.cs corrigido com sucesso")
        return True
    return False

def main():
    fix_rt850_conf_carefully()
    fix_designer_carefully()
    print("\n✅ Correções concluídas com cuidado")

if __name__ == '__main__':
    main()
