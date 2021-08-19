using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int en1 = 150, boy1 = 150, koordinatX1 = 150, koordinatY1 = 150;
        int en2 = 170, boy2 = 170, koordinatX2 = 400, koordinatY2 = 150;

      
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            angle1 = trackBar2.Value;
            Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            angle = trackBar1.Value;
            Invalidate();
        }

        float angle, angle1;
        Bitmap image = Properties.Resources.airground250;
        Bitmap image1 = Properties.Resources.pusula;
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Matrix matrix = new Matrix();


            
            Graphics z = e.Graphics;
           

            g.RotateTransform(angle, MatrixOrder.Append);
            g.TranslateTransform(en1, boy1, MatrixOrder.Append);
            g.DrawImage(image, -koordinatX1 / 2, -koordinatY1 / 2, koordinatX1, koordinatY1);


            e.Graphics.ResetTransform();

            z.RotateTransform(angle1, MatrixOrder.Append);
            z.TranslateTransform(koordinatX2, koordinatY2, MatrixOrder.Append);
            z.DrawImage(image1, -en2 / 2, -boy2 / 2, en2, boy2);
            /*

            if (angle != 0)
            {
               
                g.TranslateTransform(cx, cy, MatrixOrder.Append);
                g.DrawImage(image, -rx / 2, -ry / 2, rx, ry);
            }
            else if (angle1 != 0)
            {
               
                z.TranslateTransform(cx, cy, MatrixOrder.Append);
                z.DrawImage(image1, -rx / 2, -ry / 2, rx, ry);
            }

            */


        }
    }
}
