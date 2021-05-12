using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Proyecto
{
    class ImagenesCirculares:PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath gra = new GraphicsPath();
            gra.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(gra);
            base.OnPaint(pe);   
        }
     
    }

}
