using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cas25
{
    class FileClass
    {
        private string FileToWrite;

        public void SetFileName(string FileName)
        {
            this.FileToWrite = FileName;
        }

        public void WriteToFile(string TextToWrite)
        {
            using (StreamWriter file = new StreamWriter(this.FileToWrite, true))
            {
                file.WriteLine("**********");
                file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss K"));
                file.WriteLine();
                file.WriteLine(TextToWrite);
                file.WriteLine();
                file.WriteLine("**********");
            }
        }
    }
}
