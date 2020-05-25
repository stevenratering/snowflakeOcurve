// Steve Ratering
// 2020/5/25
// Draw Snowflake Curve and O Curve

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snowflake
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.FromName("Blue"));
        Graphics g;
        static int width, height, level;
        static double length;
        static String shape;
        static Boolean nested;

        public Form1()
        {
            InitializeComponent();
            shape = "Snow";
        }

        private void DrawSnow(double x, double y, int direction, double length, int level, Boolean incr)
        {
            double x1, y1;
            if (level == 0) {
                x1 = x + length * Math.Cos(direction * Math.PI / 6);
                y1 = y - length * Math.Sin(direction * Math.PI / 6);
                g.DrawLine(myPen, (int)x, (int)y, (int)(x1), (int)(y1));
            }
            else
            {
                double newLen = length / Math.Sqrt(3);
                if (incr)
                {
                    DrawSnow(x, y, (direction + 1) % 12, newLen, level - 1, false);
                    x1 = x + newLen * Math.Cos((direction + 1) * Math.PI / 6);
                    y1 = y - newLen * Math.Sin((direction + 1) * Math.PI / 6);
                    DrawSnow(x1, y1, (direction + 11) % 12, newLen, level - 1, false);
                }
                else
                {
                    DrawSnow(x, y, (direction + 11) % 12, newLen, level - 1, true);
                    x1 = x + newLen * Math.Cos((direction + 11) * Math.PI / 6);
                    y1 = y - newLen* Math.Sin((direction + 11) * Math.PI / 6);
                    DrawSnow(x1, y1, (direction + 1) % 12, newLen, level - 1, true);
                }
            }
        }

        private void DrawO(double x, double y, int direction, double length, int level)
        {
            double x1, y1;

            if (level == 0)
            {
                x1 = x + length * Math.Cos(direction * Math.PI / 4);
                y1 = y - length * Math.Sin(direction * Math.PI / 4);
                g.DrawLine(myPen, (int)Math.Round(x), (int)Math.Round(y), (int)Math.Round(x1), (int)Math.Round(y1));
            }
            else
            {
                double newLen = length / Math.Sqrt(2);
                DrawO(x, y, (direction + 1) % 8, newLen, level - 1);
                x1 = x + newLen * Math.Cos((direction + 1) % 8 * Math.PI / 4);
                y1 = y - newLen * Math.Sin((direction + 1) % 8 * Math.PI / 4);
                DrawO(x1, y1, (direction + 7) % 8, newLen, level - 1);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //float thick = float.Parse(myThickness.Text);
            float thick = 1;
            width = canvas.Width;
            height = canvas.Height;
            if (shape == "Snow")
            {
                length = Math.Min((width - 2 * thick) / 3, (height - 2 * thick) / 2 / Math.Sqrt(3));
            }
            else
            {
                length = Math.Min(width / 2, height / 2);
            }
            myPen = new Pen(Color.FromName(myColor.Text), thick);
            //myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            //myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g = canvas.CreateGraphics();
            double centerX, centerY, x1, y1, x2, y2, x3, y3;
            centerX = canvas.Width / 2;
            centerY = canvas.Height / 2;
            g.Clear(Color.White);
            if (shape == "Snow")
            {
                x1 = centerX - length * 1.5;
                y1 = centerY + length * Math.Sqrt(3) / 2;
                x2 = centerX;
                y2 = centerY - length * Math.Sqrt(3);
                x3 = centerX + length * 1.5;
                DrawSnow(x1, y1, 2, length * 3, level, true);
                DrawSnow(x2, y2, 10, length * 3, level, true);
                DrawSnow(x3, y1, 6, length * 3, level, true);
                if (nested && level > 1)
                {
                    x1 = centerX - length;
                    y1 = centerY;
                    x2 = centerX + length / 2;
                    y2 = centerY - length * Math.Sqrt(3) / 2;
                    y3 = centerY + length * Math.Sqrt(3) / 2;
                    DrawSnow(x1, y1, 1, length * Math.Sqrt(3), level - 1, true);
                    DrawSnow(x2, y2, 9, length * Math.Sqrt(3), level - 1, true);
                    DrawSnow(x2, y3, 5, length * Math.Sqrt(3), level - 1, true);
                }
            }
            else
            {
                x1 = centerX - length / 2;
                y1 = centerY;
                x2 = centerX + length / 2;
                DrawO(x1, y1, 0, length, level);
                DrawO(x2, y1, 4, length, level);
            }
        }

        private void myLevel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                level = Int32.Parse(myLevel.Text);
                if (level > 12)
                {
                    level = 12;
                    myLevel.Text = "12";
                }
                if (level < 0)
                {
                    level = 0;
                    myLevel.Text = "0";
                }
                canvas.Refresh();
            }
            catch
            {
                myLevel.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void color_TextChanged(object sender, EventArgs e)
        {
            Color c = Color.FromName(myColor.Text);
            if (c.A > 0 || c.R > 0 || c.G > 0 || c.B > 0)
            {
                canvas.Refresh();
            }
        }

        private void myLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void myLevel_KeyDown(object sender, KeyEventArgs e)
        {
            const int up = 38;
            const int down = 40;
            int localLevel;
            try
            {
                localLevel = Int32.Parse(myLevel.Text);
                if (e.KeyValue == up && localLevel < 12)
                {
                    localLevel++;
                    myLevel.Text = "" + localLevel;
                }
                if (e.KeyValue == down && localLevel > 0)
                {
                    localLevel--;
                    myLevel.Text = "" + localLevel;
                }
            }
            catch
            {
            }
        }

        private void myShape_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void myShape_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void myShape_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        /* the link between Form1[Design] and Form1.Designer didn't change this method name to myShapeSnow_CheckedChanged */
        {
            if (myShapeSnow.Checked)
            {
                shape = "Snow";
                canvas.Refresh();
            }
        }

        private void myShapeO_CheckedChanged(object sender, EventArgs e)
        {
            if (myShapeO.Checked) 
            {
                shape = "O";
                canvas.Refresh();
            }
        }

        private void myNested_CheckedChanged(object sender, EventArgs e)
        {
            nested = myNested.Checked;
            canvas.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
        }
    }
}
