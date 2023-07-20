using System.Text;

namespace LunchApp.IO
{
    public class Fichier
    {
        private String completeFilename = String.Empty;
        public String CompleteFilename { get { return completeFilename; } set { StructFilename(value); } }
        public String Filename { get;private set; } = String.Empty;
        public String NameFile { get; private set; } = String.Empty;
        public String Path { get; private set; } = String.Empty;
        public String Extension { get; private set; } = String.Empty;

        public StreamReader file;

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
            //file = new FileStream(CompleteFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
        }
        public void Close()
        {
            if(file != null)
                file.Close();
        }
        public String ReadAll()
        {
            file = new StreamReader(CompleteFilename);
            String r = file.ReadToEnd();
            return r;
        }
        public void WriteFile(String buffer)
        {
            if (file != null)
            {
                //file.Position = 0;
                //file.Write(Encoding.ASCII.GetBytes(buffer), 0, buffer.Length);
            }
        }
        public void Write(String text)
        {
            if (file != null)
            {
                //file.Write(Encoding.ASCII.GetBytes(text), 0, text.Length);
            }
        }
        public void WriteLine(String text)
        {
            if (file != null)
            {
                //file.Write(Encoding.ASCII.GetBytes(text + '\n'), 0, text.Length);
            }
        }
        public void ReplaceTextFile(String[] text)
        {
        }
    }
}
