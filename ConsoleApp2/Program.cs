using Autofac;
using Autofac.Core;
using ConsoleApp2.Generics;
using ConsoleApp2.IDataWriter_Classes;
using ConsoleApp2.Interfaces;
using ConsoleApp2.IOutput_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            //var builder = new ContainerBuilder();
            ////builder.RegisterType<FileWriter>().As<IOutput>();
            //builder.RegisterType<ConsoleWriter>().As<IOutput>();
            //builder.RegisterType<TodayWriter>().As<IDataWriter>();
            //Container = builder.Build();

            //WriteData();

            ///OldWay
            //TodayWriter OldWay = new TodayWriter(new ConsoleWriter());
            //OldWay.WriteData();

            #region OldCode
            IOutput consoleWriter = new ConsoleWriter();
            IOutput fileWriter = new FileWriter();
            
            IDataWriter intWriter;

            intWriter = new IntWriter();

            for (int i = 0; i < 0; i++)
            {
                if (i % 2 == 0)
                {
                    intWriter.ChangeWriterOutput(consoleWriter);
                }
                else
                {
                    intWriter.ChangeWriterOutput(fileWriter);
                }

                intWriter.WriteInt(i);
            }

            ViewModel model = new ViewModel { Id = 1, Name = "Franek Dolas" };

            MyCompare.showAttributes<ViewModel>(model);
            #endregion
        }

        public static void WriteData()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDataWriter>();
                writer.WriteData();
            }
        }
    }
}
