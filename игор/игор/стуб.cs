using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace игор
{
    class стуб
    {
        private int x, y;
        private int a, b;
        private SolidBrush sb;
        private Pen p;

        public стуб(int x, int y, int a, int b, Color cf, Color co)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            this.b = b;
            sb = new SolidBrush(cf);
            p = new Pen(co);
        }

        public void NacrtajSe(Graphics g)
        {
            g.FillRectangle(sb, x, y, a, b);
            g.DrawRectangle(p, x, y, a, b);
        }
    }
}
