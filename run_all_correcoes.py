#!/usr/bin/env python3
"""
run_all_correcoes.py
Executor único para aplicar todos os scripts de correção Python do projeto iS800.
"""
import os
import subprocess
import sys

SCRIPTS = [
    "add_missing_usings.py",
    "fix_common_errors.py",
    "fix_batch_common_errors.py",
    "fix_batch_simplified.py",
    "fix_case_sensitivity.py",
    "fix_datagridview_alignment.py",
    "fix_datagridview_column_headers.py",
    "fix_datagridview_content_alignment.py",
    "fix_datagridview_data_error_contexts.py",
    "fix_datagridview_scrollbars.py",
    "fix_datagridview_scrollbars_type.py",
    "fix_dialogresult_comparison.py",
    "fix_duplicate_namespaces.py",
    "fix_errors_carefully.py",
    "fix_final_errors.py",
    "fix_font_constructors.py",
    "fix_msgboxstyle.py",
    "fix_padding_constructors.py",
    "fix_remaining_common.py",
    "fix_richtextbox_scrollbars_datagridview.py",
    "fix_rt_850.py",
    "fix_rt_geral_comprehensive.py",
    "fix_sobre_designer.py",
    "fix_specific_errors.py",
    "fix_string_alignment.py",
    "fix_syntax_errors.py",
    "fix_this_keyword_errors.py",
    "fix_toolstrip_enums.py",
    "fix_unassigned_variables.py",
    "fix_alingcoluna_assignments.py",
    "fix_all_cs0266_enums.py",
    "final_remaining_fixes.py",
    "comprehensive_final_fixer.py",
    "final_comprehensive_fixer.py",
]

EXCLUDE_PATTERNS = [
    "tmp_fix_cs0266.py",
    "tmp_fix_cs1525.py",
    "tmp_fix_decompiled_syntax.py",
    "tmp_fix_designer.py",
]


def run_script(script_path):
    print("\n" + "=" * 80)
    print(f"Executando: {script_path}")
    print("=" * 80 + "\n")

    result = subprocess.run([sys.executable, script_path], cwd=SCRIPT_DIR)
    return result.returncode


def main():
    global SCRIPT_DIR
    SCRIPT_DIR = os.path.abspath(os.path.dirname(__file__))
    os.chdir(SCRIPT_DIR)

    print("Iniciando execução de todos os scripts de correção...\n")

    available_scripts = []
    for script in SCRIPTS:
        if os.path.basename(script) in EXCLUDE_PATTERNS:
            continue
        if os.path.isfile(os.path.join(SCRIPT_DIR, script)):
            available_scripts.append(script)
        else:
            print(f"Atenção: script não encontrado e será ignorado -> {script}")

    if not available_scripts:
        print("Nenhum script de correção encontrado. Verifique o diretório e a lista de scripts.")
        return 1

    success = 0
    failures = []

    for script in available_scripts:
        rc = run_script(script)
        if rc == 0:
            success += 1
            print(f"\n✔ Script concluído: {script}")
        else:
            failures.append((script, rc))
            print(f"\n✖ Script falhou ({rc}): {script}")

    print("\n" + "#" * 80)
    print("Resumo da execução".center(80))
    print("#" * 80)
    print(f"Scripts executados: {len(available_scripts)}")
    print(f"Sucesso: {success}")
    print(f"Falhas: {len(failures)}")

    if failures:
        print("\nScripts com falha:")
        for script, rc in failures:
            print(f"- {script}: exit code {rc}")

    return 0 if not failures else 2


if __name__ == '__main__':
    exit(main())
