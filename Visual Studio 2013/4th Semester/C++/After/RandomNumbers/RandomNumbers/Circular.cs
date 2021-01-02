using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace RandomNumbers
{
    class Circular:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grp = new GraphicsPath();
            grp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grp);
            base.OnPaint(pevent);
        }
    }
}
