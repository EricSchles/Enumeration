using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        //enum's are static dictionaries..
        public enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        static void Main(string[] args)
        {
            Days day = Days.Monday;
            Console.WriteLine((int)day);
            string[] values = Enum.GetNames(typeof(Days));
            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
