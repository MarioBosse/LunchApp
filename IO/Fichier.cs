using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchApp.IO
{
    public class Fichier
    {
        private String completeFilename = String.Empty;
        public String CompleteFilename { get { return completeFilename; } set { StructFilename(value); } }
        public String? Filename { get;private set; }
        public String? NameFile { get; private set; }
        public String? Path { get;private set; }
        public String? Extension { get; private set; }

        public FileStream? file;
        public long Lenght { get { return file.Length; } }

        public Fichier() 
        {
        }
        public Fichier(string name)
        {
            CompleteFilename = name;
        }
        private void StructFilename(String compleFilename)
        {
            completeFilename = compleFilename;

            String[] strings = completeFilename.Split('\\');
            for (int i = 0; i < strings.Length - 1; i++)
            {
                Path += strings[i];
                if(i > 0) { Path += "\\"; }
            }
            NameFile = strings[strings.Length - 1];
            String[] filename = strings[strings.Length - 1].Split('.');
            Filename = filename[0];
            Extension = filename[1];
        }
        public void Open()
        {
            file = new FileStream(CompleteFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        }
        public String[]? Read()
        {
            return null;
        }
        public void Write(String text)
        {
            if (file != null)
            {
                file.Write(Encoding.ASCII.GetBytes(text), 0, text.Length);
            }
        }
        public void WriteLine(String text)
        {
            if (file != null)
            {
                file.Write(Encoding.ASCII.GetBytes(text + '\n'), 0, text.Length);
            }
        }
        public void ReplaceTextFile(String[] text)
        {
        }
    }
}
