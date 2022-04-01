using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CG_Lab2
{
    public partial class Form1 : Form
    {
        int xn, yn, xk, yk;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                xn = e.X; 
                yn = e.Y;
            }
            else MessageBox.Show("Вы не выбрали алгоритм вывода фигуры!");
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int i, n; 
            double xt, yt, dx, dy;
            xk = 0; 
            yk = 0; 
            xk = e.X; 
            yk = e.Y; 

            dx = xk - xn; 
            dy = yk - yn; 
            n = 100; 
            xt = xn; 
            yt = yn;

            for (i = 1; i <= n; i++)
            {
                //Объявляем объект "g" класса Graphics и предоставляем ему возможность рисования на pictureBox1:
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

                //Рисуем прямоугольник: 
                g.DrawRectangle( this_Pen(), (int)xt, (int)yt, 2, 2);

                xt = xt + dx / n;
                yt = yt + dy / n;
                
            }
        }

        // Построение отрезка по координатам
        private void button2_Click(object sender, EventArgs e)
        {
            int i, n;
            double xt, yt, dx, dy;
            xk = 0;
            yk = 0;
            xk = int.Parse(textBox4.Text);
            yk = int.Parse(textBox5.Text);
            xn = int.Parse(textBox1.Text);
            yn = int.Parse(textBox2.Text);

            dx = xk - xn;
            dy = yk - yn;
            n = 100;
            xt = xn;
            yt = yn;

            for (i = 1; i <= n; i++)
            { 
                //Объявляем объект "g" класса Graphics и предоставляем ему возможность рисования на pictureBox1:
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

                g.DrawRectangle(this_Pen(), (int)xt, (int)yt, 2, 2);

                xt = xt + dx / n;
                yt = yt + dy / n;

            }
        }

        // Построение прямоугольника
        private void button3_Click(object sender, EventArgs e)
        {
            Point[] pg = new Point[4];

            pg[0] = new Point(0, 0);
            pg[1] = new Point(50, 0);
            pg[2] = new Point(50, 200);
            pg[3] = new Point(0, 200);

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            g.DrawPolygon(this_Pen(), pg);
        }

        //Построение квадрата
        private void button4_Click(object sender, EventArgs e)
        {
            Point[] pg = new Point[4];

            pg[0] = new Point(25, 100);
            pg[1] = new Point(325, 100);
            pg[2] = new Point(325, 400);
            pg[3] = new Point(25, 400);

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            g.DrawPolygon(this_Pen(), pg);
        }

        // Построение треугольника
        private void button5_Click(object sender, EventArgs e)
        {
            Point[] pg = new Point[3];

            pg[0] = new Point(75, 200);
            pg[1] = new Point(400, 0);
            pg[2] = new Point(350, 300);

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            g.DrawPolygon(this_Pen(), pg);
        }

        // Построение многоугольника
        private void button6_Click(object sender, EventArgs e)
        {
            Point[] pg = new Point[5];

            pg[0] = new Point(100, 0);
            pg[1] = new Point(200, 50);
            pg[2] = new Point(150, 75);
            pg[3] = new Point(200, 100);
            pg[4] = new Point(100, 150);

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            g.DrawPolygon(this_Pen(), pg);
        }

        private void button1_Click(object sender, EventArgs e) 
        { 
            pictureBox1.Image = null; 
        }

        private Color this_color() 
        {
            string s1 = textBox3.Text;
            Color c = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(s1);
            return c;
        }

        private System.Drawing.Pen this_Pen()
        {
            int A;

            A = int.Parse(textBox6.Text);
            
            Pen myPen = new Pen(this_color(), A);
            return myPen;
        }
    }   
}
