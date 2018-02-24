using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.IOutput_Classes
{
    class FileWriter : IOutput
    {
        public void Write(string content)
        {
            StreamWriter file = new StreamWriter("output.txt", true);
            file.WriteLine(content);
            file.Close();
        }
    }
}
