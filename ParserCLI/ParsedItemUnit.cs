using Core.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCLI
{
    public class ParsedItemUnit
    {
        public string Mod { get; set; } = default!;
        public Dictionary<string, string> Contents { get; set; } = default!;

        public List<Translation> Translations { get; set; } = new();
    }

    public class Translation
    {
        public string Lang { get; set; } = default!;
        public MetaData MetaData { get; set; } = new MetaData();
    }
}
