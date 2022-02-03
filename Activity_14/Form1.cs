using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
        System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        System.Drawing.Graphics formGraphics;
        
        public Form1()
        {
            InitializeComponent();
            formGraphics = DrawRes.CreateGraphics();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                    }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drawEllipse()
        {
            if (OutlineRbtn.Checked)
            {
                formGraphics.DrawEllipse(myPen, new Rectangle(50, 50, 100, 100));
            }
            else
            {
                formGraphics.FillEllipse(myBrush, new Rectangle(50, 50, 100, 100));
            }

            /*myPen.Dispose();
            formGraphics.Dispose();*/
        }



        private void drawRectagle()
        {
            if (OutlineRbtn.Checked)
            {
                formGraphics.DrawRectangle(myPen, new Rectangle(10, 10, 200, 100));
            }
            else
            {
                formGraphics.FillRectangle(myBrush, new Rectangle(10, 10, 200, 100));
            }


        }

        private void drawTriangle()
        {
            PointF point1 = new PointF(10.0F, 100.0F);
            PointF point2 = new PointF(100.0F, 25.0F);
            PointF point3 = new PointF(200.0F, 100.0F);
            PointF[] curvePoints =
             {
                 point1,
                 point2,
                 point3, };

            if (OutlineRbtn.Checked)
            {
                formGraphics.DrawPolygon(myPen, curvePoints);
            }
            else
            {
                formGraphics.FillPolygon(myBrush, curvePoints);
            }


        }

        private void drawPentagon()
        {
            PointF point1 = new PointF(25, 350);
            PointF point2 = new PointF(450, 350);
            PointF point3 = new PointF(225, 50);
            PointF point4 = new PointF(10, 150);
            PointF point5 = new Point(475, 150);
            PointF[] curvePoints =
             {
                 point1,
                 point2,
                 point5,
                 point3,
                 point4
            };

            if (OutlineRbtn.Checked)
            {
                formGraphics.DrawPolygon(myPen, curvePoints);
            }
            else
            {
                formGraphics.FillPolygon(myBrush, curvePoints);
            }


        }

        private void drawHexagon()
        {
            var x_0 = DrawRes.Width / 2;
            var y_0 = DrawRes.Height / 2;

            var shape = new PointF[6];

            var r = 70; //70 px radius 

            //Create 6 points
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF(
                    x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            if (OutlineRbtn.Checked)
            {
                formGraphics.DrawPolygon(myPen, shape);
            }
            else
            {
                formGraphics.FillPolygon(myBrush, shape);
            }


        }

        private void showDetails()
        {
            string item = listBox1.SelectedItem.ToString();
            if (nameCbx.Checked)
            {
                nameLbl.Text = item;
            }
            if (dateCbx.Checked)
            {
                DateTime today = DateTime.Today;
                dateLbl.Text = today.ToShortDateString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = listBox1.SelectedItem.ToString();
            if (item == "Circle")
            {
                drawEllipse();
            }else if (item == "Triangle")
            {
                drawTriangle();
            }else if (item == "Rectangle")
            {
                drawRectagle();
            }else if (item == "Hexagon")
            {
                drawHexagon();
            }else if (item == "Pentagon")
            {
                drawPentagon();
            }
            showDetails();


        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

      
            formGraphics.Clear(Color.White);

            DrawRes.Clear();
        }
    }
}
