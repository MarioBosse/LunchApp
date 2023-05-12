using LunchApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchApp.IO
{
    public partial class CNFFile : Fichier
    {
        public String? CnfFilename { get; private set; }
        public String RootPath { get; private set; } = String.Empty;
        public List<CNF> CNF { get; private set; } = new List<CNF>();

        public CNFFile(String filename)
        {
            CompleteFilename = filename;
        }
    }
}
