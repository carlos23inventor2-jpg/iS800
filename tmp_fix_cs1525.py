import io
import os
import re

files = [
    "Comunicacao.cs",
    "Equip_101_conf.cs",
    "Equip_202_conf.cs",
    "Equip_302_conf.cs",
    "Equip_VA220_ope.cs",
    "GC_82x_conf.cs",
    "IEC_855_conf.cs",
    "IER_856_conf.cs",
    "Plataforma.cs",
    "RT_810_200_conf.cs",
    "RT_810_conf.cs",
    "RT_820_200_conf.cs",
    "RT_820_360_conf.cs",
    "RT_820_conf.cs",
    "RT_821_200_conf.cs",
    "RT_821_Conf.cs",
    "RT_830_200_configurador.cs",
    "RT_831_200_configurador.cs",
    "RT_850_conf.cs",
]

def replace_method(content, signature, new_method):
    idx = content.find(signature)
    if idx < 0:
        return content, False
    brace = content.find("{", idx)
    if brace < 0:
        return content, False
    depth = 0
    i = brace
    while i < len(content):
        ch = content[i]
        if ch == "{":
            depth += 1
        elif ch == "}":
            depth -= 1
            if depth == 0:
                end = i + 1
                return content[:idx] + new_method + content[end:], True
        i += 1
    return content, False

def fix_comunicacao(path):
    with io.open(path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    new_init_porta = """\t\tpublic static bool Init_porta_serial()\n\t\t{\n\t\t\ttry\n\t\t\t{\n\t\t\t\tif (Comunicacao.Config_sistema.tipo_interface == 1)\n\t\t\t\t{\n\t\t\t\t\tif (MyProject.Forms.Plataforma.SerialPort1.IsOpen)\n\t\t\t\t\t{\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.Close();\n\t\t\t\t\t}\n\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.Encoding = Encoding.GetEncoding(28591);\n\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.PortName = Comunicacao.Config_sistema.Serial.Porta_serial;\n\t\t\t\t\tswitch (Comunicacao.Config_sistema.Serial.Baudrate)\n\t\t\t\t\t{\n\t\t\t\t\tcase 0:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.BaudRate = 1200;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\tcase 1:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.BaudRate = 2400;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\tcase 2:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.BaudRate = 4800;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\tcase 3:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.BaudRate = 9600;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\tcase 4:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.BaudRate = 19200;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\tcase 5:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.BaudRate = 38400;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\t}\n\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.Parity = Comunicacao.Config_sistema.Serial.Parity;\n\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.StopBits = Comunicacao.Config_sistema.Serial.StopBits;\n\t\t\t\t\tswitch (Comunicacao.Config_sistema.Serial.DataBits)\n\t\t\t\t\t{\n\t\t\t\t\tcase 0:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.DataBits = 4;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\tcase 1:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.DataBits = 5;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\tcase 2:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.DataBits = 6;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\tcase 3:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.DataBits = 7;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\tcase 4:\n\t\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.DataBits = 8;\n\t\t\t\t\t\tbreak;\n\t\t\t\t\t}\n\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.Open();\n\t\t\t\t\tComunicacao.Init_buffer_serial();\n\t\t\t\t\tGeral.Config_geral.Porta_serial_Ok = true;\n\t\t\t\t}\n\t\t\t\telse\n\t\t\t\t{\n\t\t\t\t\tGeral.Config_geral.Porta_serial_Ok = Comunicacao.Config_sistema.tipo_interface == 2;\n\t\t\t\t}\n\t\t\t\treturn Geral.Config_geral.Porta_serial_Ok;\n\t\t\t}\n\t\t\tcatch (Exception)\n\t\t\t{\n\t\t\t\tInteraction.MsgBox("Erro na escolha da porta de comunicação serial", (MsgBoxStyle)272, "Atenção - verifique configuração");\n\t\t\t\tGeral.Config_geral.Porta_serial_Ok = false;\n\t\t\t\treturn false;\n\t\t\t}\n\t\t}\n"""
    new_init_buffer = """\t\tpublic static bool Init_buffer_serial()\n\t\t{\n\t\t\ttry\n\t\t\t{\n\t\t\t\tif (Comunicacao.Config_sistema.tipo_interface == 1)\n\t\t\t\t{\n\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.DiscardOutBuffer();\n\t\t\t\t\tMyProject.Forms.Plataforma.SerialPort1.DiscardInBuffer();\n\t\t\t\t}\n\t\t\t\tfor (int i = 0; i <= 512; i++)\n\t\t\t\t{\n\t\t\t\t\tComunicacao.Buffer_resp[i] = 0;\n\t\t\t\t\tComunicacao.Buffer_cmd[i] = 0;\n\t\t\t\t}\n\t\t\t\tComunicacao.Ctrl_Com.Tipo_funcao = 0;\n\t\t\t\tComunicacao.Ctrl_Com.Cont_rx = 0;\n\t\t\t\tComunicacao.Ctrl_Com.Frame = 255;\n\t\t\t\treturn true;\n\t\t\t}\n\t\t\tcatch (Exception)\n\t\t\t{\n\t\t\t\tInteraction.MsgBox("Erro na localização da porta serial!", (MsgBoxStyle)32, "Atenção - Porta Serial");\n\t\t\t\treturn false;\n\t\t\t}\n\t\t}\n"""
    content, _ = replace_method(content, "\t\tpublic static bool Init_porta_serial()", new_init_porta)
    content, _ = replace_method(content, "\t\tpublic static bool Init_buffer_serial()", new_init_buffer)
    with io.open(path, "w", encoding="utf-8") as f:
        f.write(content)

def rewrite_method_body(content, signature, body):
    pattern = re.escape(signature)
    m = re.search(pattern, content)
    if not m:
        return content, False
    start = m.start()
    brace = content.find("{", m.end())
    if brace < 0:
        return content, False
    depth = 0
    i = brace
    while i < len(content):
        if content[i] == "{":
            depth += 1
        elif content[i] == "}":
            depth -= 1
            if depth == 0:
                end = i + 1
                method = signature + "\n\t\t{\n" + body + "\t\t}\n"
                return content[:start] + method + content[end:], True
        i += 1
    return content, False

def fix_generic(path):
    with io.open(path, "r", encoding="utf-8-sig") as f:
        content = f.read()
    content = re.sub(r'@switch\(ICSharpCode\.Decompiler\.ILAst\.ILLabel\[\],\s*[^;]+\);', 'throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");', content)
    content = re.sub(r'catch when \(endfilter\(obj is Exception & [^)]+\)\)\s*\{\s*Exception ex = \(Exception\)obj2;\s*goto [^;]+;\s*\}', 'catch (Exception)\n\t\t\t{\n\t\t\t\tthrow;\n\t\t\t}', content)
    if os.path.basename(path) == "Equip_101_conf.cs":
        body1 = """\t\t\ttry\n\t\t\t{\n\t\t\t\tthis.Reservatorio_altura.Value = new decimal(Mod_MD.Reservatorio[indice].Altura_sensor);\n\t\t\t\tthis.Valor_end_est.Value = new decimal(Mod_MD.Reservatorio[indice].End_estacao);\n\t\t\t\tthis.Valor_end_mestre.Value = new decimal(Mod_MD.Reservatorio[indice].End_mestre);\n\t\t\t\tthis.Valor_end_est_rep.Value = new decimal(Mod_MD.Reservatorio[indice].End_repetidora);\n\t\t\t\tthis.Filtro_intervalo.Value = new decimal(Mod_MD.Reservatorio[indice].Intervalo_filtro * 10);\n\t\t\t\tthis.Filtro_tamanho.Value = new decimal(Mod_MD.Reservatorio[indice].Tamanho_filtro);\n\t\t\t\tthis.Valor_num_est_rep.Value = new decimal(Mod_MD.Reservatorio[indice].Num_repetidoras);\n\t\t\t\tif (Mod_MD.Reservatorio[indice].Offset_sensor <= 1000)\n\t\t\t\t{\n\t\t\t\t\tthis.Sensor_offset.Value = new decimal(Mod_MD.Reservatorio[indice].Offset_sensor);\n\t\t\t\t}\n\t\t\t\telse\n\t\t\t\t{\n\t\t\t\t\tthis.Sensor_offset.Value = new decimal(0 - (Mod_MD.Reservatorio[indice].Offset_sensor - 1000));\n\t\t\t\t}\n\t\t\t\tthis.Sensor_range.Value = new decimal(Mod_MD.Reservatorio[indice].Range_sensor);\n\t\t\t\tthis.Valor_temp_ptt.Value = new decimal(Mod_MD.Reservatorio[indice].Tempo_ptt * 10);\n\t\t\t\tthis.Valor_int_tx.Value = new decimal(Mod_MD.Reservatorio[indice].Tempo_tx_ponto);\n\t\t\t\tthis.Atualiza_tela_MD101_repetidora(indice);\n\t\t\t\tthis.Atualiza_tela_MD101_operacao(indice);\n\t\t\t\tthis.Atualiza_tela_MD101_medida(indice);\n\t\t\t}\n\t\t\tcatch (Exception)\n\t\t\t{\n\t\t\t\tMsgBoxResult msgBoxResult = Interaction.MsgBox("Existem valores não compatíveis com os parâmetro desta tela !\\r\\nCarregar configuração Default ?", (MsgBoxStyle)36, "Atenção");\n\t\t\t\tif (msgBoxResult == MsgBoxResult.Yes)\n\t\t\t\t{\n\t\t\t\t\tMod_MD.CarregaConfiguracaoDefault_MD101(indice);\n\t\t\t\t}\n\t\t\t\telse\n\t\t\t\t{\n\t\t\t\t\tMod_MD.Reservatorio[indice].Altura_sensor = 1000;\n\t\t\t\t\tMod_MD.Reservatorio[indice].End_estacao = 1;\n\t\t\t\t\tMod_MD.Reservatorio[indice].End_mestre = 200;\n\t\t\t\t\tMod_MD.Reservatorio[indice].End_repetidora = 100;\n\t\t\t\t\tMod_MD.Reservatorio[indice].Intervalo_filtro = 500;\n\t\t\t\t\tMod_MD.Reservatorio[indice].Tamanho_filtro = 5;\n\t\t\t\t\tMod_MD.Reservatorio[indice].Num_repetidoras = 0;\n\t\t\t\t\tMod_MD.Reservatorio[indice].Offset_sensor = 0;\n\t\t\t\t\tMod_MD.Reservatorio[indice].Range_sensor = 1000;\n\t\t\t\t\tMod_MD.Reservatorio[indice].Tempo_ptt = 20;\n\t\t\t\t\tMod_MD.Reservatorio[indice].Tempo_tx_ponto = 30;\n\t\t\t\t}\n\t\t\t\tthis.Atualiza_tela_MD101(indice);\n\t\t\t}\n"""
        body2 = """\t\t\ttry\n\t\t\t{\n\t\t\t\tif (this.passo < 4)\n\t\t\t\t{\n\t\t\t\t\tthis.Valor_end_rep_3.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[3 + this.passo * 12]);\n\t\t\t\t\tthis.Valor_end_rep_4.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[4 + this.passo * 12]);\n\t\t\t\t\tthis.Valor_end_rep_5.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[5 + this.passo * 12]);\n\t\t\t\t\tthis.Valor_end_rep_6.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[6 + this.passo * 12]);\n\t\t\t\t\tthis.Valor_end_rep_7.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[7 + this.passo * 12]);\n\t\t\t\t\tthis.Valor_end_rep_8.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[8 + this.passo * 12]);\n\t\t\t\t\tthis.Valor_end_rep_9.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[9 + this.passo * 12]);\n\t\t\t\t\tthis.Valor_end_rep_10.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[10 + this.passo * 12]);\n\t\t\t\t\tthis.Valor_end_rep_11.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[11 + this.passo * 12]);\n\t\t\t\t\tthis.Valor_end_rep_12.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[12 + this.passo * 12]);\n\t\t\t\t}\n\t\t\t\tthis.Valor_end_rep_1.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[1 + this.passo * 12]);\n\t\t\t\tthis.Valor_end_rep_2.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[2 + this.passo * 12]);\n\t\t\t\tthis.Label_end_rep_1.Text = Strings.Format(1 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_2.Text = Strings.Format(2 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_3.Text = Strings.Format(3 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_4.Text = Strings.Format(4 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_5.Text = Strings.Format(5 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_6.Text = Strings.Format(6 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_7.Text = Strings.Format(7 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_8.Text = Strings.Format(8 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_9.Text = Strings.Format(9 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_10.Text = Strings.Format(10 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_11.Text = Strings.Format(11 + this.passo * 12, "00:");\n\t\t\t\tthis.Label_end_rep_12.Text = Strings.Format(12 + this.passo * 12, "00:");\n\t\t\t\tint num_repetidoras = Mod_MD.Reservatorio[indice].Num_repetidoras;\n\t\t\t\tthis.Label_end_rep_1.Visible = (num_repetidoras - this.passo * 12 - 0 > 0);\n\t\t\t\tthis.Valor_end_rep_1.Visible = this.Label_end_rep_1.Visible;\n\t\t\t\tthis.Label_end_rep_2.Visible = (num_repetidoras - this.passo * 12 - 1 > 0);\n\t\t\t\tthis.Valor_end_rep_2.Visible = this.Label_end_rep_2.Visible;\n\t\t\t\tthis.Label_end_rep_3.Visible = (num_repetidoras - this.passo * 12 - 2 > 0);\n\t\t\t\tthis.Valor_end_rep_3.Visible = this.Label_end_rep_3.Visible;\n\t\t\t\tthis.Label_end_rep_4.Visible = (num_repetidoras - this.passo * 12 - 3 > 0);\n\t\t\t\tthis.Valor_end_rep_4.Visible = this.Label_end_rep_4.Visible;\n\t\t\t\tthis.Label_end_rep_5.Visible = (num_repetidoras - this.passo * 12 - 4 > 0);\n\t\t\t\tthis.Valor_end_rep_5.Visible = this.Label_end_rep_5.Visible;\n\t\t\t\tthis.Label_end_rep_6.Visible = (num_repetidoras - this.passo * 12 - 5 > 0);\n\t\t\t\tthis.Valor_end_rep_6.Visible = this.Label_end_rep_6.Visible;\n\t\t\t\tthis.Label_end_rep_7.Visible = (num_repetidoras - this.passo * 12 - 6 > 0);\n\t\t\t\tthis.Valor_end_rep_7.Visible = this.Label_end_rep_7.Visible;\n\t\t\t\tthis.Label_end_rep_8.Visible = (num_repetidoras - this.passo * 12 - 7 > 0);\n\t\t\t\tthis.Valor_end_rep_8.Visible = this.Label_end_rep_8.Visible;\n\t\t\t\tthis.Label_end_rep_9.Visible = (num_repetidoras - this.passo * 12 - 8 > 0);\n\t\t\t\tthis.Valor_end_rep_9.Visible = this.Label_end_rep_9.Visible;\n\t\t\t\tthis.Label_end_rep_10.Visible = (num_repetidoras - this.passo * 12 - 9 > 0);\n\t\t\t\tthis.Valor_end_rep_10.Visible = this.Label_end_rep_10.Visible;\n\t\t\t\tthis.Label_end_rep_11.Visible = (num_repetidoras - this.passo * 12 - 10 > 0);\n\t\t\t\tthis.Valor_end_rep_11.Visible = this.Label_end_rep_11.Visible;\n\t\t\t\tthis.Label_end_rep_12.Visible = (num_repetidoras - this.passo * 12 - 11 > 0);\n\t\t\t\tthis.Valor_end_rep_12.Visible = this.Label_end_rep_12.Visible;\n\t\t\t}\n\t\t\tcatch (Exception)\n\t\t\t{\n\t\t\t\tMsgBoxResult msgBoxResult = Interaction.MsgBox("Existem valores não compatíveis com os parâmetro desta tela !\\r\\nCarregar configuração Default ?", (MsgBoxStyle)36, "Atenção");\n\t\t\t\tif (msgBoxResult == MsgBoxResult.Yes)\n\t\t\t\t{\n\t\t\t\t\tMod_MD.CarregaConfiguracaoDefault_MD101(indice);\n\t\t\t\t}\n\t\t\t\telse\n\t\t\t\t{\n\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[1 + this.passo * 12] = 0;\n\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[2 + this.passo * 12] = 0;\n\t\t\t\t\tif (this.passo < 4)\n\t\t\t\t\t{\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[3 + this.passo * 12] = 0;\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[4 + this.passo * 12] = 0;\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[5 + this.passo * 12] = 0;\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[6 + this.passo * 12] = 0;\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[7 + this.passo * 12] = 0;\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[8 + this.passo * 12] = 0;\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[9 + this.passo * 12] = 0;\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[10 + this.passo * 12] = 0;\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[11 + this.passo * 12] = 0;\n\t\t\t\t\t\tMod_MD.Reservatorio[indice].Repetidoras[12 + this.passo * 12] = 0;\n\t\t\t\t\t}\n\t\t\t\t}\n\t\t\t\tthis.Atualiza_tela_MD101_repetidora_enderecos(indice);\n\t\t\t}\n"""
        content, _ = rewrite_method_body(content, "\t\tpublic void Atualiza_tela_MD101(int indice)", body1)
        content, _ = rewrite_method_body(content, "\t\tpublic void Atualiza_tela_MD101_repetidora_enderecos(int indice)", body2)
    with io.open(path, "w", encoding="utf-8") as f:
        f.write(content)

for path in files:
    if not os.path.exists(path):
        continue
    if path == "Comunicacao.cs":
        fix_comunicacao(path)
    else:
        fix_generic(path)