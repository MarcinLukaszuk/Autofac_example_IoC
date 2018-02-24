using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.IDataWriter_Classes
{
    class TodayWriter : IDataWriter
    {
        protected IOutput _output;

        public TodayWriter() { }

        public TodayWriter(IOutput ouput)
        {
            this._output = ouput;
        }

        public void ChangeWriterOutput(IOutput ouput)
        {
            this._output = ouput;
        }

        public void WriteData()
        {
            this._output.Write(DateTime.Now.ToShortDateString());
        }

        public virtual void WriteInt(int i)
        {
            throw new NotImplementedException();
        }
    }
}
