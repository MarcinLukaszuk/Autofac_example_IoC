using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    interface IDataWriter
    {
        void WriteData();
        void ChangeWriterOutput(IOutput output);
        void WriteInt(int i);
    }
}
