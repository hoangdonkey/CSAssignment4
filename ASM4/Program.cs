using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4
{
    class Program
    {
        static void Main(string[] args)
        {
            Window list1 = new ListBox(1, 2, "No1");
            Window list2 = new ListBox(3, 4, "No2");
            Window button = new Button(5, 6);
            list1.DrawWindow();
            list2.DrawWindow();
            button.DrawWindow();

            Console.ReadKey();
        }
    }
}
