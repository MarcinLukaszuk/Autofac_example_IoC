using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.IOutput_Classes
{
    class ConsoleWriter : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
