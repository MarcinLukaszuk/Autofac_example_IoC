using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.IDataWriter_Classes
{
    class IntWriter : TodayWriter
    {
        public IntWriter(IOutput ouput) : base(ouput)
        {
        }

        public IntWriter() : base() { }

        public override void WriteInt(int data)
        {
            this._output.Write(data.ToString());
        }
    }
}
