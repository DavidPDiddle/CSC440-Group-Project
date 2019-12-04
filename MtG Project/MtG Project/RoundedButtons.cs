using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Made using https://www.youtube.com/watch?v=U6ciI0Gtb44 as a reference as I was sick of the 
 * standard VisualStudio buttons.
 * Made by Ronald Logan Barker
 */

namespace MtG_Project
{
    class RoundedButtons : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
