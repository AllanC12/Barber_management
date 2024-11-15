using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BarberManagement.Helpers
{
    public class ConnectionRead
    {
        public static Dictionary<string, string> ReadArchiveConnection(string path)
        {

            Dictionary<string, string> configs = new Dictionary<string, string>();

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Arquivo não encotrado no caminho: " + path);
            }

            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {

                if (string.IsNullOrEmpty(line) || line.StartsWith(';')) continue;


                var parts = line.Split('=', 2);

                if (parts.Length == 2)
                {
                    var key = parts[0].Trim();
                    var value = parts[1].Trim();

                    configs[key] = value;
                }   
            }

            return configs;
        }

    }
}