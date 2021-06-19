using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4
{
    class ListBox : Window
    {
        private String mListContents;

        public ListBox(int top, int left, String thecontent) : base(top, left)
        {
            mListContents = thecontent;
            Console.WriteLine("ListBox constructer");
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Writing string to the listbox: " + mListContents);
            System.Console.WriteLine(top + ", " + left + ", " + mListContents);
        }
    }
}
