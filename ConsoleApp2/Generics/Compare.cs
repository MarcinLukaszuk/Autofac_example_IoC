using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Generics
{
    public static class MyCompare
    {
        public static void showAttributes<T>(T model)
        {
            var info = typeof(T);
            foreach (var item in info.GetProperties())
            {
                Console.WriteLine("{0} - {1}", item.Name, item.GetValue(model));
            }
        }
    }
}
