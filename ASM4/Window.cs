using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4
{
    public abstract class Window
    {
        protected int top;
        protected int left;

        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow() { }
    }
}
