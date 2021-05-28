using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDA
{
    public partial class Form1 : Form
    {
        Bitmap Bitmap = new Bitmap(1001, 701);
        List<int> drawx,drawy;
        int sq = 0;
        public Form1()
        {
            drawx = new List<int>();
            drawy = new List<int>();
            Draw_Axis(Bitmap);
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xstart = Convert.ToInt32(txt_startx.Text);
            int ystart = Convert.ToInt32(txt_starty.Text);
            int xend = Convert.ToInt32(txt_endx.Text);
            int yend = Convert.ToInt32(txt_endy.Text);
            int xc = Convert.ToInt32(txt_cx.Text);
            int yc = Convert.ToInt32(txt_cy.Text);
            int rx = Convert.ToInt32(txt_rx.Text);
            int ry = Convert.ToInt32(txt_ry.Text);
            int tx = Convert.ToInt32(txt_tx.Text);
            int ty = Convert.ToInt32(txt_ty.Text);
            double theta = Convert.ToDouble(txt_theta.Text);
            int sh = Convert.ToInt32(txt_sh.Text);
            int sx = Convert.ToInt32(txt_sx.Text);
            int sy = Convert.ToInt32(txt_sy.Text);

            // تظبيط حدود
            if (xend >= 500)
                xend = 500;
            if (yend >= 350)
                yend = 350;
            if (xend <= -500)
                xend = -500;
            if (yend <= -350)
                yend = -350;

            if (xstart >= 500)
                xstart = 500;
            if (ystart >= 350)
                ystart = 350;
            if (xstart <= -500)
                xstart = -500;
            if (ystart <= -350)
                ystart = -350;

            if (xc >= 500)
                xc = 500;
            if (yc >= 350)
                yc = 350;
            if (xc <= -500)
                xc = -500;
            if (yc <= -350)
                yc = -350;

            

            //x axis
            xstart += 500;
            xend += 500;
            xc += 500;
            //cornars
            if (ystart >= 0) 
            {
                ystart = 350 - ystart;
            }
            else if (ystart <= 0)
            {
                ystart = 700-(ystart+350);
            }
            if (yend >= 0)
            {
                yend = 350 - yend;
            }
            else if (yend <= 0)
            {
                yend = 700 - (yend + 350);
            }
            if (yc >= 0)
            {
                yc = 350 - yc;
            }
            else if (yc <= 0)
            {
                yc = 700 - (yc + 350);
            }

            //circle
            if (yc + rx >= 700)
                yc = 700 - rx;
            else if (yc - rx <= 0)
                yc = rx;
            //elipse
            if (xc + rx >= 1000)
                xc = 1000 - rx;
            else if (xc - rx <= 0)
                xc = rx;

            if (yc + ry >= 700)
                yc = 700 - ry;
            else if (yc - ry <= 0)
                yc = ry;
            switch (Convert.ToString(this.comboBoxChooseAlgo.SelectedItem)) 
            {
                case "Bresenham Line (Blue)":
                    lineBresenham(xstart, ystart, xend, yend);
                    break;
                case "DDA Line (Red)":
                    lineDDA(xstart, ystart, xend, yend,1);
                    break;
                case "Circle (Brown)":
                    if (rx >= 350)
                        rx = 350;
                    else if (rx <= 0)
                        rx = 1;
                    circle(xc, yc, rx);
                    break;
                case "Elipse (green)":
                    if (rx >= 500)
                        rx = 500;
                    else if (rx <= 0)
                        rx = 1;
                    if (ry >= 350)
                        ry = 350;
                    else if (ry <= 0)
                        ry = 1;
                    elipse(xc, yc, rx, ry);
                    break;
                case "Translation (Aqua)":
                    if (drawx.Count != 0 && drawy.Count != 0)
                        Translation(tx, ty);
                    else
                        MessageBox.Show("No Draws Now On Screen");
                    break;
                case "Rotation (DarkGray)":
                    if (drawx.Count != 0 && drawy.Count != 0)
                    {
                        theta= (theta * (Math.PI)) / 180;
                        Rotation(theta);
                    }
                    else
                        MessageBox.Show("No Draws Now On Screen");
                    break;
                case "Shear (Purple)":
                    if (sq == 1)
                    {
                        if (shrdx.Checked)
                        {
                            shear(sh, 0);
                        }
                        else if (shrdy.Checked)
                        {
                            shear(sh, 1);
                        }
                    }
                    else
                        MessageBox.Show("Please Draw Squre ");

                    break;
                case "Reflection (DarkGreen)":
                    if (drawx.Count != 0 && drawy.Count != 0)
                    {
                        if (rdx.Checked)
                        {
                            Reflection(0);
                        }
                        else if (rdy.Checked)
                        {
                            Reflection(1);
                        }
                        else if (rdxy.Checked)
                        {
                            Reflection(2);
                        }
                    }
                    else
                        MessageBox.Show("No Draws Now On Screen");
                    break;
                case "Scale (Chocolate)":
                    if (drawx.Count != 0 && drawy.Count != 0)
                    {
                        scale(sx, sy);
                    }
                    else
                        MessageBox.Show("No Draws Now On Screen");
                    break;

            }
            
        }
        //btn square
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            drawx.Clear();
            drawy.Clear();

            lineDDA(550, 350, 550, 300, 0);
            lineDDA(500, 300, 550, 300, 0);
            lineDDA(500, 350, 500, 300, 0);
            lineDDA(500, 350, 550, 350, 0);
            sq = 1;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            drawx.Clear();
            drawy.Clear();
            clearbitmap();
            Draw_Axis(Bitmap);
        }

        private void lineDDA(int xstert,int ystart,int xend,int yend,int clear)
        {
            sq = 0;
            int dx = xend - xstert, dy = yend - ystart,steps,k;
            double xi, yi, x = xstert, y = ystart;
            if (clear == 1)
            {
                drawx.Clear();
                drawy.Clear();
                clearbitmap();
                Draw_Axis(Bitmap);
            }
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }
            else
            {
                steps = Math.Abs(dy);
            }

            xi = Convert.ToDouble(dx) / Convert.ToDouble(steps);
            yi = Convert.ToDouble(dy) / Convert.ToDouble(steps);

            
            
            
            
            Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.Red);
            drawx.Add((int)Convert.ToInt64(x));
            drawy.Add((int)Convert.ToInt64(y));
            for (k = 0; k < steps; k++) 
            {
                
                x += xi;
                y += yi;
                
                try
                {
                    Bitmap.SetPixel((int)Convert.ToInt64(x), (int)Convert.ToInt64(y), Color.Red);
                    drawx.Add( (int)Convert.ToInt64(x));
                    drawy.Add((int)Convert.ToInt64(y));
                }
                catch(Exception e)
                {
                    MessageBox.Show(e+"");
                }
                
            }
            panal.Image = Bitmap;
        }

        private void lineBresenham(int xstart, int ystart, int xend, int yend) 
        {
            sq = 0;
            int dx, dy, x=xstart, y=ystart, p, twody, twodyminusdx, dirction, temp;
             
            double m = Convert.ToDouble( -(yend-ystart)) / Convert.ToDouble(xend -xstart);
            drawx.Clear();
            drawy.Clear();
            
            if (yend < ystart)
                dirction = 1;
            else
                dirction = 0;

            clearbitmap();
            Draw_Axis(Bitmap);
                if (dirction == 1)
                {
                    if (m < 1 && m > 0)//1
                    {
                    
                    dx = Math.Abs(xend - xstart); dy = Math.Abs(yend - ystart);
                    p = 2 * dy - dx;
                    twody = 2 * dy; twodyminusdx = 2 * (dy - dx);
                    if (xstart > xend)
                    {
                        x = xend; y = yend; xend = xstart; yend = ystart;
                    }
                    else
                    {
                        x = xstart; y = ystart;
                    }
                    Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.Blue);
                    drawx.Add((int)Convert.ToInt64(x));
                    drawy.Add((int)Convert.ToInt64(y));
                    while (x <= xend)
                        {
                        
                            x++;
                       
                        if (p < 0)
                                p += twody;
                            else
                            {
                                y--;
                                p += twodyminusdx;
                            }
                            try
                            {
                                Bitmap.SetPixel((int)Convert.ToInt64(x), (int)Convert.ToInt64(y), Color.Blue);
                            drawx.Add((int)Convert.ToInt64(x));
                            drawy.Add((int)Convert.ToInt64(y));
                        }
                            catch (ArgumentOutOfRangeException e)
                            {
                                MessageBox.Show(e + "");
                            }
                        } 
                    }
                    else if (m > 1)//2
                    {
                    
                    temp = x;
                        x = y;
                        y = temp;
                    temp = xend;
                    xend = yend;
                    yend = temp;
                    dx = Math.Abs(xend - x); dy = Math.Abs(yend - y);
                    p = 2 * dy - dx;
                    twody = 2 * dy; twodyminusdx = 2 * (dy - dx);
                    if (x < xend)
                    {
                        temp = x;
                        x = xend;  
                        xend = temp;
                        temp = y;
                        y = yend;
                        yend = temp;
                    }
                    
                    Bitmap.SetPixel(Convert.ToInt32(y), Convert.ToInt32(x), Color.Blue);
                    drawx.Add((int)Convert.ToInt64(y));
                    drawy.Add((int)Convert.ToInt64(x));
                    while (x >= xend)
                        {
                        
                        x--;
                            if (p < 0)
                                p += twody;
                            else
                            {
                                y++;
                                p += twodyminusdx;
                            }
                            try
                            {
                                Bitmap.SetPixel((int)Convert.ToInt64(y), (int)Convert.ToInt64(x), Color.Blue);
                            drawx.Add((int)Convert.ToInt64(y));
                            drawy.Add((int)Convert.ToInt64(x));
                        }
                            catch (ArgumentOutOfRangeException e)
                            {
                                MessageBox.Show(e + "");
                            }
                        }
                    }
                    else if (m < -1) //3
                    {

                    temp = x;
                    x = y;
                    y = temp;
                    temp = xend;
                    xend = yend;
                    yend = temp;
                    dx = Math.Abs(xend - x); dy = Math.Abs(yend - y);
                    p = 2 * dy - dx;
                    twody = 2 * dy; twodyminusdx = 2 * (dy - dx);
                    if (x < xend)
                    {
                        temp = x;
                        x = xend;
                        xend = temp;
                        temp = y;
                        y = yend;
                        yend = temp;
                    }
                    Bitmap.SetPixel(Convert.ToInt32(y), Convert.ToInt32(x), Color.Blue);
                    drawx.Add((int)Convert.ToInt64(y));
                    drawy.Add((int)Convert.ToInt64(x));
                    while ( x>=xend)
                        {
                        
                        x--;
                            if (p < 0)
                                p += twody;
                            else
                            {
                                y--;
                                p += twodyminusdx;
                            }
                            try
                            {
                                Bitmap.SetPixel((int)Convert.ToInt64(y), (int)Convert.ToInt64(x), Color.Blue);
                            drawx.Add((int)Convert.ToInt64(y));
                            drawy.Add((int)Convert.ToInt64(x));
                        }
                            catch (ArgumentOutOfRangeException e)
                            {
                                MessageBox.Show(e + "");
                            }
                        }
                    }
                    else if (m > -1 && m < 0)//4
                    {
                    dx = Math.Abs(xend - x); dy = Math.Abs(yend - y);
                    p = 2 * dy - dx;
                    twody = 2 * dy; twodyminusdx = 2 * (dy - dx);
                    if (x < xend)
                    {
                        temp = x;
                        x = xend;
                        xend = temp;
                        temp = y;
                        y = yend;
                        yend = temp;
                    }

                    Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.Blue);
                    drawx.Add((int)Convert.ToInt64(x));
                    drawy.Add((int)Convert.ToInt64(y));
                    while (x >= xend)
                        {
                        
                        x--;
                            if (p < 0)
                                p += twody;
                            else
                            {
                                y--;
                                p += twodyminusdx;
                            }
                            try
                            {
                                Bitmap.SetPixel((int)Convert.ToInt64(x), (int)Convert.ToInt64(y), Color.Blue);
                            drawx.Add((int)Convert.ToInt64(x));
                            drawy.Add((int)Convert.ToInt64(y));
                        }
                            catch (ArgumentOutOfRangeException e)
                            {
                                MessageBox.Show(e + "");
                            }
                        }
                    }
                }
                else if (dirction == 0)
                {

                    if (m < 1 && m > 0)//5
                    {
                    dx = Math.Abs(xend - x); dy = Math.Abs(yend - y);
                    p = 2 * dy - dx;
                    twody = 2 * dy; twodyminusdx = 2 * (dy - dx);
                    if (x < xend)
                    {
                        temp = x;
                        x = xend;
                        xend = temp;
                        temp = y;
                        y = yend;
                        yend = temp;
                    }

                    Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.Blue);
                    drawx.Add((int)Convert.ToInt64(x));
                    drawy.Add((int)Convert.ToInt64(y));
                    while (x >= xend)
                        {
                        
                        x--;
                            if (p < 0)
                                p += twody;
                            else
                            {
                                y++;
                                p += twodyminusdx;
                            }
                            try
                            {
                                Bitmap.SetPixel((int)Convert.ToInt64(x), (int)Convert.ToInt64(y), Color.Blue);
                            drawx.Add((int)Convert.ToInt64(x));
                            drawy.Add((int)Convert.ToInt64(y));
                        }
                            catch (ArgumentOutOfRangeException e)
                            {
                                MessageBox.Show(e + "");
                            }
                        }
                    }
                    else if (m > 1)//6
                    {
                    temp = x;
                    x = y;
                    y = temp;
                    temp = xend;
                    xend = yend;
                    yend = temp;
                    dx = Math.Abs(xend - x); dy = Math.Abs(yend - y);
                    p = 2 * dy - dx;
                    twody = 2 * dy; twodyminusdx = 2 * (dy - dx);
                    if (x > xend)
                    {
                        temp = x;
                        x = xend;
                        xend = temp;
                        temp = y;
                        y = yend;
                        yend = temp;
                    }

                    Bitmap.SetPixel(Convert.ToInt32(y), Convert.ToInt32(x), Color.Blue);
                    drawx.Add((int)Convert.ToInt64(y));
                    drawy.Add((int)Convert.ToInt64(x));
                    while (x <= xend)
                        {
                        
                        x++;
                            if (p < 0)
                                p += twody;
                            else
                            {
                                y--;
                                p += twodyminusdx;
                            }
                            try
                            {
                                Bitmap.SetPixel((int)Convert.ToInt64(y), (int)Convert.ToInt64(x), Color.Blue);
                            drawx.Add((int)Convert.ToInt64(y));
                            drawy.Add((int)Convert.ToInt64(x));
                        }
                            catch (ArgumentOutOfRangeException e)
                            {
                                MessageBox.Show(e + "");
                            }
                        }
                    }
                    else if (m < -1)//7
                    {
                    temp = x;
                    x = y;
                    y = temp;
                    temp = xend;
                    xend = yend;
                    yend = temp;
                    dx = Math.Abs(xend - x); dy = Math.Abs(yend - y);
                    p = 2 * dy - dx;
                    twody = 2 * dy; twodyminusdx = 2 * (dy - dx);
                    if (x > xend)
                    {
                        temp = x;
                        x = xend;
                        xend = temp;
                        temp = y;
                        y = yend;
                        yend = temp;
                    }

                    Bitmap.SetPixel(Convert.ToInt32(y), Convert.ToInt32(x), Color.Blue);
                    drawx.Add((int)Convert.ToInt64(y));
                    drawy.Add((int)Convert.ToInt64(x));
                    while (x <= xend)
                        {
                        
                        x++;
                            if (p < 0)
                                p += twody;
                            else
                            {
                                y++;
                                p += twodyminusdx;
                            }
                            try
                            {
                                Bitmap.SetPixel((int)Convert.ToInt64(y), (int)Convert.ToInt64(x), Color.Blue);
                            drawx.Add((int)Convert.ToInt64(y));
                            drawy.Add((int)Convert.ToInt64(x));
                        }
                            catch (ArgumentOutOfRangeException e)
                            {
                                MessageBox.Show(e + "");
                            }
                        }
                    }
                    else if (m > -1 && m < 0)//8
                    {
                    
                    dx = Math.Abs(xend - x); dy = Math.Abs(yend - y);
                    p = 2 * dy - dx;
                    twody = 2 * dy; twodyminusdx = 2 * (dy - dx);
                    if (x > xend)
                    {
                        temp = x;
                        x = xend;
                        xend = temp;
                        temp = y;
                        y = yend;
                        yend = temp;
                    }

                    Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.Blue);
                    drawx.Add((int)Convert.ToInt64(x));
                    drawy.Add((int)Convert.ToInt64(y));
                    while (x < xend)
                        {
                        
                        x++;
                            if (p < 0)
                                p += twody;
                            else
                            {
                                y++;
                                p += twodyminusdx;
                            }
                            try
                            {

                                Bitmap.SetPixel((int)Convert.ToInt64(x), (int)Convert.ToInt64(y), Color.Blue);
                            drawx.Add((int)Convert.ToInt64(x));
                            drawy.Add((int)Convert.ToInt64(y));
                        }
                            catch (ArgumentOutOfRangeException e)
                            {
                                MessageBox.Show(e + "");
                            }
                        }
                    }
                }
                
            
            panal.Image = Bitmap;
        }

        private void circle(int xc,int yc,int rx)
        {
            sq = 0;
            int x = 0, y = rx, p = 1 - rx;


            clearbitmap();
            Draw_Axis(Bitmap);
            Bitmap.SetPixel(xc, yc, Color.Brown);
            drawx.Add((int)Convert.ToInt64(xc));
            drawy.Add((int)Convert.ToInt64(yc));
            circle_set_point(xc, yc, x, y, Bitmap);
            drawx.Add((int)Convert.ToInt64(xc + x));
            drawy.Add((int)Convert.ToInt64(yc - y));

            drawx.Add((int)Convert.ToInt64(xc - x));
            drawy.Add((int)Convert.ToInt64(yc - y));

            drawx.Add((int)Convert.ToInt64(xc + x));
            drawy.Add((int)Convert.ToInt64(yc + y));

            drawx.Add((int)Convert.ToInt64(xc - x));
            drawy.Add((int)Convert.ToInt64(yc + y));

            drawx.Add((int)Convert.ToInt64(xc + y));
            drawy.Add((int)Convert.ToInt64(yc - x));

            drawx.Add((int)Convert.ToInt64(xc - y));
            drawy.Add((int)Convert.ToInt64(yc - x));

            drawx.Add((int)Convert.ToInt64(xc + y));
            drawy.Add((int)Convert.ToInt64(yc + x));

            drawx.Add((int)Convert.ToInt64(xc - y));
            drawy.Add((int)Convert.ToInt64(yc + x));
            while (x < y)
            {
                
                x++;
                if (p<0)
                    p+=2*x + 1;
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                
                circle_set_point(xc, yc, x, y, Bitmap);
                drawx.Add((int)Convert.ToInt64(xc + x));
                drawy.Add((int)Convert.ToInt64(yc - y));

                drawx.Add((int)Convert.ToInt64(xc - x));
                drawy.Add((int)Convert.ToInt64(yc - y));

                drawx.Add((int)Convert.ToInt64(xc + x));
                drawy.Add((int)Convert.ToInt64(yc + y));

                drawx.Add((int)Convert.ToInt64(xc - x));
                drawy.Add((int)Convert.ToInt64(yc + y));

                drawx.Add((int)Convert.ToInt64(xc + y));
                drawy.Add((int)Convert.ToInt64(yc - x));

                drawx.Add((int)Convert.ToInt64(xc - y));
                drawy.Add((int)Convert.ToInt64(yc - x));

                drawx.Add((int)Convert.ToInt64(xc + y));
                drawy.Add((int)Convert.ToInt64(yc + x));

                drawx.Add((int)Convert.ToInt64(xc - y));
                drawy.Add((int)Convert.ToInt64(yc + x));
            }
            panal.Image = Bitmap;
        }

        private void elipse(int xc,int yc,int rx, int ry)
        {
            sq = 0;
            int x = 0, y = ry,p;
            int ry2 = ry * ry, rx2 = rx * rx;
            int tworx2 = rx2 * 2;
            int twory2 = ry2 * 2;
            int px = 0, py = tworx2 * y;

            drawx.Clear();
            drawy.Clear();

            clearbitmap();
            Draw_Axis(Bitmap);
            Bitmap.SetPixel(xc, yc, Color.Green);
            drawx.Add((int)Convert.ToInt64(xc));
            drawy.Add((int)Convert.ToInt64(yc));

            elipse_set_point(xc, yc, x, y, Bitmap);

            drawx.Add((int)Convert.ToInt64(xc + x));
            drawy.Add((int)Convert.ToInt64(yc - y));

            drawx.Add((int)Convert.ToInt64(xc - x));
            drawy.Add((int)Convert.ToInt64(yc - y));

            drawx.Add((int)Convert.ToInt64(xc + x));
            drawy.Add((int)Convert.ToInt64(yc + y));

            drawx.Add((int)Convert.ToInt64(xc - x));
            drawy.Add((int)Convert.ToInt64(yc + y));
            //octant 2
            p = ry2 - rx2 * ry + rx2 / 4;
            while (px < py)
            {
                
                x++;
                
                px += twory2;
                if (p < 0)
                    p += twory2*x + ry2;
                else
                {
                    y--;
                    py -= tworx2;
                    p += twory2 * x -tworx2*y+ ry2;
                }
                elipse_set_point(xc, yc, x, y, Bitmap);
                drawx.Add((int)Convert.ToInt64(xc + x));
                drawy.Add((int)Convert.ToInt64(yc - y));

                drawx.Add((int)Convert.ToInt64(xc - x));
                drawy.Add((int)Convert.ToInt64(yc - y));

                drawx.Add((int)Convert.ToInt64(xc + x));
                drawy.Add((int)Convert.ToInt64(yc + y));

                drawx.Add((int)Convert.ToInt64(xc - x));
                drawy.Add((int)Convert.ToInt64(yc + y));
            }
            //octant 1
            p = ry2 * (x + 1 / 2) * (x + 1 / 2) + rx2 * (y - 1) * (y - 1) - rx2 * ry2;
            while (y >=  0)
            {
                
                y--;
                
                py -= rx2 - py;
                if (p > 0)
                    p += -tworx2 * y + rx2;
                else
                {
                    x++;
                    px += twory2;
                    p += twory2*x - tworx2*y + rx2;
                }
                elipse_set_point(xc, yc, x, y, Bitmap);
                drawx.Add((int)Convert.ToInt64(xc + x));
                drawy.Add((int)Convert.ToInt64(yc - y));

                drawx.Add((int)Convert.ToInt64(xc - x));
                drawy.Add((int)Convert.ToInt64(yc - y));

                drawx.Add((int)Convert.ToInt64(xc + x));
                drawy.Add((int)Convert.ToInt64(yc + y));

                drawx.Add((int)Convert.ToInt64(xc - x));
                drawy.Add((int)Convert.ToInt64(yc + y));
            }
            panal.Image = Bitmap;
        }

        private void circle_set_point(int xc,int yc, int x, int y, Bitmap bitmap) 
        {
            bitmap.SetPixel(xc + x, yc - y, Color.Brown);//++
            bitmap.SetPixel(xc - x, yc - y, Color.Brown);//-+
            bitmap.SetPixel(xc + x, yc + y, Color.Brown);//+-
            bitmap.SetPixel(xc - x, yc + y, Color.Brown);//--

            bitmap.SetPixel(xc + y, yc - x, Color.Brown);//++
            bitmap.SetPixel(xc - y, yc - x, Color.Brown);//-+
            bitmap.SetPixel(xc + y, yc + x, Color.Brown);//+-
            bitmap.SetPixel(xc - y, yc + x, Color.Brown);//--

        }

        private void elipse_set_point(int xc,int yc, int x, int y, Bitmap bitmap)
        {
            bitmap.SetPixel(xc + x, yc - y, Color.Green);//++
            bitmap.SetPixel(xc - x, yc - y, Color.Green);//-+
            bitmap.SetPixel(xc + x, yc + y, Color.Green);//+-
            bitmap.SetPixel(xc - x, yc + y, Color.Green);//--
        }

        private void Translation(int tx ,int ty)
        {
            sq = 0;
            int[,] TranslationMatrix = { { 1, 0, tx }, { 0, 1, ty }, { 0, 0, 1 } };
            int x, y;
            for (int i = 0; i < drawx.Count; i++)
            {
                
                x = TranslationMatrix[0, 0] * drawx[i] + TranslationMatrix[0, 1] * drawy[i] + TranslationMatrix[0, 2];
                y = TranslationMatrix[1, 0] * drawx[i] + TranslationMatrix[1, 1] * drawy[i] - TranslationMatrix[1, 2];
                if (x >= 1000)
                    x = 1000;
                if (y >= 700)
                    y = 700;
                if (x <= 0)
                    x = 0;
                if (y <= 0)
                    y = 0;
                Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.Aqua);
                drawx[i] = x;
                drawy[i] = y;
            }
            panal.Image = Bitmap;
        }

        private void shear (int sh,int d)
        {
            int x, y;
            if (d == 0)
            {
                for (int i = 0; i < drawx.Count; i++)
                {
                    x = 500+((drawx[i]-500)+ sh * (350-drawy[i]));
                    y = drawy[i] ;
                    Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.Purple);
                }
            }
            else
            {
                for (int i = 0; i < drawx.Count; i++)
                {
                    x = drawx[i];
                    y = 350 - ((drawx[i] - 500) * sh + (350-drawy[i] ));
                    Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.Purple);

                }
            }
            panal.Image = Bitmap;
        }

        private void Rotation(double angel)
        {
            sq = 0;
            double[,] RotationMatrix = { { (Math.Cos(angel)), -(Math.Sin(angel)), 0 }, { (Math.Sin(angel)), (Math.Cos(angel)), 0 }, { 0, 0, 1 } };
            double x, y;
            
            for (int i = 0; i < drawx.Count; i++)
            {
                drawx[i] -= 500;
                drawy[i] = 350 - drawy[i];
                x = RotationMatrix[0, 0] * drawx[i]+ RotationMatrix[0, 1] * drawy[i] + RotationMatrix[0, 2];
                y = RotationMatrix[1, 0] * drawx[i] + RotationMatrix[1, 1] * drawy[i] + RotationMatrix[1, 2];
                x += 500;
                if (y >= 0)
                {
                    y = 350 - y;
                }
                else if (y <= 0)
                {
                    y = 700 - (y + 350);
                }
                if (x >= 1000)
                    x = 1000;
                if (y >= 700)
                    y = 700;
                if (x <= 0)
                    x = 0;
                if (y <= 0)
                    y = 0;
                Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.DarkGray);
                
                drawx[i] = (int)x;
                drawy[i] = (int)y;
            }
            panal.Image = Bitmap;
        }

        private void Reflection(int d)
        {
            sq = 0;
            int x, y;
            if (d == 0)//x
            {
                for (int i = 0; i < drawx.Count; i++)
                {
                    x = drawx[i];
                    y = drawy[i];
                    
                    y = 350 - y;
                    y = -y;
                    if (y >= 0)
                    {
                        y = 350 - y;
                    }
                    else if (y <= 0)
                    {
                        y = 700 - (y + 350);
                    }
                    Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.DarkGreen);
                    drawx[i] = (int)x;
                    drawy[i] = (int)y;
                }
            }else if (d == 1)//y
            {
                for (int i = 0; i < drawx.Count; i++)
                {
                    x = drawx[i];
                    y = drawy[i];
                    x -= 500;
                    x = -x;
                    x += 500;
                    Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.DarkGreen);
                    drawx[i] = (int)x;
                    drawy[i] = (int)y;
                }
            }else if (d == 2)//x y
            {
                for (int i = 0; i < drawx.Count; i++)
                {
                    x = drawx[i];
                    y = drawy[i];
                    x -= 500;
                    y = 350 - y;
                    x = -x;
                    y = -y;
                    x += 500;
                    if (y >= 0)
                    {
                        y = 350 - y;
                    }
                    else if (y <= 0)
                    {
                        y = 700 - (y + 350);
                    }
                    Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.DarkGreen);
                    drawx[i] = (int)x;
                    drawy[i] = (int)y;
                }
            }
            panal.Image = Bitmap;
        }
        
        private void scale(int sx,int sy)
        {
            sq = 0;
            
            double x, y;

            for (int i = 0; i < drawx.Count; i++)
            {
                x = drawx[i];
                y = drawy[i];
                x -= 500;
                y = 350 - y;
                x =x*sx;
                y =y*sy;
                x += 500;
                if (y >= 0)
                {
                    y = 350 - y;
                }
                else if (y <= 0)
                {
                    y = 700 - (y + 350);
                }
                if (x >= 1000)
                    x = 1000;
                if (y >= 700)
                    y = 700;
                if (x <= 0)
                    x = 0;
                if (y <= 0)
                    y = 0;
                Bitmap.SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), Color.Chocolate);
                drawx[i] = (int)x;
                drawy[i] = (int)y;
            }
            panal.Image = Bitmap;
        }

        private void clearbitmap()
        {
            for (int i = 0; i < 1001; i++)
            {
                for (int j = 0; j < 701; j++)
                {
                    Bitmap.SetPixel(Convert.ToInt32(i), Convert.ToInt32(j), Color.White);
                }
            }
        }

        private void Draw_Axis(Bitmap bmp)
        {
            Pen blackPen = new Pen(Color.Black, 2);
            Point px1 = new Point(0, 350);
            Point px2 = new Point(1000, 350);
            Point py1 = new Point(500, 0);
            Point py2 = new Point(500, 700);
            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.DrawLine(blackPen, px1, px2);
                graphics.DrawLine(blackPen, py1, py2);
            }
        }

        private void txt_startx_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }
        }

        private void txt_starty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txt_endx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txt_endy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txt_endy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_starty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_endx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panal_Click(object sender, EventArgs e)
        {

        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
