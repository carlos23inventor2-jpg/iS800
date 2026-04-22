managed_ini = '''using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace iS800
{
    public class IniFile
    {
        private string _path;
        private Dictionary<string, Dictionary<string, string>> _data =
            new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

        public IniFile(string path)
        {
            _path = path;
            if (File.Exists(path)) Load();
        }

        private void Load()
        {
            string section = "";
            foreach (var line in File.ReadAllLines(_path, Encoding.UTF8))
            {
                var l = line.Trim();
                if (l.StartsWith("[") && l.EndsWith("]"))
                {
                    section = l.Substring(1, l.Length - 2);
                    if (!_data.ContainsKey(section))
                        _data[section] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                }
                else if (l.Contains("=") && !l.StartsWith(";"))
                {
                    int idx = l.IndexOf('=');
                    string key = l.Substring(0, idx).Trim();
                    string val = l.Substring(idx + 1).Trim();
                    if (!string.IsNullOrEmpty(section))
                        _data[section][key] = val;
                }
            }
        }

        private void Save()
        {
            var sb = new StringBuilder();
            foreach (var sec in _data)
            {
                sb.AppendLine("[" + sec.Key + "]");
                foreach (var kv in sec.Value)
                    sb.AppendLine(kv.Key + "=" + kv.Value);
                sb.AppendLine();
            }
            File.WriteAllText(_path, sb.ToString(), Encoding.UTF8);
        }

        public string ReadString(string section, string key, string def)
        {
            if (_data.TryGetValue(section, out var s) && s.TryGetValue(key, out var v))
                return v;
            return def;
        }

        public int ReadInteger(string section, string key, int def)
        {
            string v = ReadString(section, key, null);
            if (v != null && int.TryParse(v, out int r)) return r;
            return def;
        }

        public bool ReadBool(string section, string key, bool def)
        {
            string v = ReadString(section, key, null);
            if (v == null) return def;
            return v == "1" || v.Equals("true", StringComparison.OrdinalIgnoreCase);
        }

        public void WriteString(string section, string key, string value)
        {
            if (!_data.ContainsKey(section))
                _data[section] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            _data[section][key] = value;
            Save();
        }

        public void WriteInteger(string section, string key, int value)
            => WriteString(section, key, value.ToString());

        public void WriteBool(string section, string key, bool value)
            => WriteString(section, key, value ? "1" : "0");
    }
}
'''
with open("IniFile.cs", "w") as f:
    f.write(managed_ini)
print("IniFile.cs reescrito (managed)")
