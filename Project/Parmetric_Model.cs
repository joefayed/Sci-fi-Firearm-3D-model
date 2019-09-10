using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Project
{
    class Parmetric_Model : _3D_Model
    {
        public void design_middle(float x, float y, float z)
        {
            float tempx = x, tempy = y, tempz = z;
            float btempx = x, btempy = y, btempz = z;
            float xs = x, ys = y, zs = z;
            int Rad = 60;
            int theta = 0;
            int ip = 0;
            int val = 50;
            float theta_in_rid;
            for (int l = 0; l < 2; l++)
            {
                xs = x;
                ys = y;
                if (l == 1)
                {
                    zs += val;
                }
                for (int i = 0; i < 250; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (ip > 0&&i>0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs -= 5;
                }
                theta = 90;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(30 * Math.Cos(theta_in_rid));
                    float yy = (float)(30 * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + xx, ys - 30 + yy, zs);
                    AddPoint(pnn);
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                    theta += 120 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys - 30 + yy;
                }
                xs = tempx - 35;
                ys = tempy - 135;
                theta = 60;
                Rad = 150;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + (0.5f * xx), ys + yy, zs);
                    AddPoint(pnn);
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                    theta -= 120 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys + yy;
                }
                xs = tempx - 25;
                ys = tempy - 9;
                theta = 160;
                Rad = 20;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + xx, ys + yy, zs);
                    AddPoint(pnn);
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                    theta += 115 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys + yy;
                }
                xs = tempx+50;
                ys = tempy;
                for (int i = 0; i < 10; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    ys += 36.2f;
                }
                ys = tempy+30;
                for (int i=0;i<70;i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    if (i<5)
                    {
                        xs += 10;
                        ys -= 2;
                    }
                    else if (i<30)
                    {
                        xs += 3;
                        ys += 7;
                    }
                    else if (i<35)
                    {
                        xs += 25;
                    }
                    else if (i<40)
                    {
                        ys -= 7;
                        tempx = xs;
                        tempy = ys;
                    }
                    else if (i<55)
                    {
                        xs += 10;
                        ys -= 3;
                    }
                    else if (i<60)
                    {
                        xs += 1;
                        ys -= 5;
                    }
                    else
                    {
                        xs += 3;
                    }
                }
                xs = tempx+80;
                ys = tempy-158;
                if (l==0)
                {
                    zs += 10;
                }
                else
                {
                    zs -= 10;
                }
                theta = 130;
                Rad = 200;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + (0.5f*xx), ys + yy, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    theta += 115 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys + yy;
                }
                xs = tempx+260;
                ys = tempy+143;
                theta = 130;
                Rad = 110;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + (0.5f * xx), ys + yy, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    theta += 100 / 20;
                    ip++;
                }
                xs = tempx+70;
                ys = tempy;
                _3D_Point pp = new _3D_Point(xs, ys, zs);
                AddPoint(pp);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                ip++;
                if (l == 0)
                {
                    zs = 0;
                }
                else
                {
                    zs =z+val;
                }
                xs += 275;
                ys += 236;
                theta = 90;
                Rad = 100;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + (xx), ys + yy, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    theta += 100 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys + yy;
                }
                xs = tempx+100;
                ys = tempy+108;
                for (int i=0;i<20;i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs += 5;
                }
                for (float y_th = ys; y_th > -300; y_th -= 10)
                {
                    //y = 100 * (float)(Math.Sin(x_th * Math.PI / 180));
                    float dist = (float)(Math.Sqrt((y_th - ys) * (y_th - ys)));
                    float xx = 40 * (float)(Math.Sin(dist * Math.PI / 160));

                    AddPoint(new _3D_Point(xx + xs, y_th, zs));

                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs -= 5;
                    tempy = xx + xs;
                    tempy = y_th;
                }
                xs = tempx+33;
                ys = tempy;
                for (int i=0;i<20;i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                    ip++;
                    xs += 7;
                    ys -= 2;
                }
                for (float y_th = ys; y_th <-210; y_th += 10)
                {
                    //y = 100 * (float)(Math.Sin(x_th * Math.PI / 180));
                    float dist = (float)(Math.Sqrt((y_th - ys) * (y_th - ys)));
                    float xx = -40 * (float)(Math.Sin(dist * Math.PI / 160));

                    AddPoint(new _3D_Point(xx + xs, y_th, zs));

                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs += 5;
                    tempx = xx + xs;
                    tempy = y_th;
                }
                xs = tempx+10;
                ys = tempy+10;
                pp = new _3D_Point(xs, ys, zs);
                AddPoint(pp);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                ip++;
                for (float y_th = ys; y_th < -110; y_th += 10)
                {
                    //y = 100 * (float)(Math.Sin(x_th * Math.PI / 180));
                    float dist = (float)(Math.Sqrt((y_th - ys) * (y_th - ys)));
                    float xx = -100 * (float)(Math.Sin(dist * Math.PI / 170));

                    AddPoint(new _3D_Point(xx + xs, y_th, zs));

                    if (ip > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs += 20;
                    tempx = xx + xs;
                    tempy = y_th;
                }
                xs -= 90;
                ys += 127;
                theta = 120;
                Rad = 50;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + (xx), ys + yy, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    theta += 120 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys + yy;
                }
                xs -= 135;
                ys = -30;
                pp = new _3D_Point(xs, ys, zs);
                AddPoint(pp);
                AddEdge(ip, ip -20, Color.DarkMagenta);
                ip++;
                xs = tempx;
                ys = tempy;
                for (int i=0;i<20;i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs += 7;
                }
                xs = tempx;
                ys = -30;
                for (int i = 0; i < 30; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    if (i < 20)
                    {
                        xs += 7;
                        tempx = xs;
                    }
                    else if (i<24)
                    {
                        xs += 7;
                        ys -= 9;
                    }
                    else
                    {
                        xs -= 7.2f;
                        ys -= 9.2f;
                    }
                }
                xs = tempx;
                ys = -30;
                for (int i=0;i<45;i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    if (i < 20)
                    {
                        xs += 7;
                    }
                    else if (i<24)
                    {
                        xs += 7;
                        ys -= 9;
                    }
                    else
                    {
                        xs += 8;
                        ys += 2;
                    }
                }
                xs -= 8;
                pp = new _3D_Point(xs, ys, zs);
                AddPoint(pp);
                if (l == 0)
                {
                    AddEdge(ip, 0, Color.DarkMagenta);
                }
                ip++;
                btempx = xs;
                btempy = ys;
                btempz = zs;
                //======================================================================================
                //the upper design
                xs = x;
                ys = y+50;
                pp = new _3D_Point(xs, ys, zs);
                AddPoint(pp);
                AddEdge(ip, ip-1, Color.DarkMagenta);
                ip++;
                for (int i=0;i<190;i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    if (i < 90)
                    {
                        xs -= 5;
                    }
                    else if (i<100)
                    {
                        xs -= 3;
                        ys += 5;
                    }
                    else if(i<110)
                    {
                        xs -= 5;
                    }
                    else if (i<130)
                    {
                        xs -= 3;
                        ys -= 5;
                    }
                    else if (i<135)
                    {
                        xs -= 5;
                    }
                    else if (i<140)
                    {
                        xs += 3;
                        ys += 5;
                    }
                    else if (i<150)
                    {
                        xs -= 5;
                        ys += 5;
                    }
                    else
                    {
                        xs -= 10;
                        ys -= 1;
                    }
                }
                theta = 90;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float xx = (float)(30 * Math.Cos(theta_in_rid));
                    float yy = (float)(30 * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs + xx, ys - 30 + yy, zs);
                    AddPoint(pnn);
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                    theta += 100 / 20;
                    ip++;
                    tempx = xs + xx;
                    tempy = ys - 30 + yy;
                }
                xs = btempx-50;
                ys = btempy+180;
                for (int i=0;i<65;i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    if (i==2||i==4||i==6||i==8||i==10||i==12||i==14||i==16||i==18||i==20||i==22||i==24||i==26||i==28||i==30||
                        i==32||i==34||i==36||i==38||i==40||i==42||i==44||i==46||i==48||i==50||i==52||i==54||i==56||i==58||i==60)
                    {
                        ys += 5;
                    }
                    if (i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 13 || i == 15 || i == 17 || i == 19 || i == 21 || i == 23 || i == 25 || i == 27 || i == 29 || i == 31 ||
                        i == 33 || i == 35|| i == 37 || i == 39 || i == 41 || i == 43 || i == 45 || i == 47 || i == 49 || i == 51 || i == 53 || i == 55 || i == 57 || i == 59)
                    {
                        ys -= 5;
                    }
                    xs -= 5;
                }
                xs = btempx;
                ys = btempy-5;
                for (int i=0;i<240;i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs -= 5;
                }
                for (int j = 0; j < 1; j++)
                {
                    if (j==0)
                    {
                        xs = 100;
                    }
                    else
                    {
                        xs = 120;
                    }

                    theta = 80;
                    for (int i = 0; i < 20; i++)
                    {
                        theta_in_rid = (float)(2 * Math.PI * theta / 360);
                        float xx = (float)(30 * Math.Cos(theta_in_rid));
                        float yy = (float)(30 * Math.Sin(theta_in_rid));
                        _3D_Point pnn = new _3D_Point(xs + xx, ys - 30 + yy, zs);
                        AddPoint(pnn);
                        if (i > 0)
                        {
                            AddEdge(ip, ip - 1, Color.DarkMagenta);
                        }
                        if (j==1)
                        {
                            AddEdge(ip, ip - 20, Color.DarkMagenta);
                        }
                        theta += 180 / 20;
                        ip++;
                        tempx = xs + xx;
                        tempy = ys - 30 + yy;
                    }
                }
                //======================================================================================
                //end of the doubling loop
            }
            for (int i = 0; i < ip / 2;i++)
            {
                AddEdge(i, (ip / 2)+i, Color.DarkMagenta);
            }
            xs = btempx;
            ys = btempy;
            zs = btempz;
            tempx = xs;
            tempy = 30;
            tempz = val / 2;
            zs = val/2;
            ys = 30;
            for (int j = 0; j < 100; j++)
            {
                if (j>0)
                {
                    xs += 1;
                }
                theta = 0;
                if (j > 40)
                {
                    if (j==41)
                    {
                        xs -= 1;
                    }
                    Rad = 15;
                }
                else
                {
                    Rad = 10;
                }
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float yy = (float)(Rad * Math.Cos(theta_in_rid));
                    float zz = (float)(Rad * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs, ys + yy, zz + zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    if (j>0)
                    {
                        AddEdge(ip, ip - 20*j, Color.DarkMagenta);
                    }
                    theta += 360 / 20;
                    ip++;
                }
            }
            xs = tempx;
            ys = tempy + 25;
            zs = tempz;
            for (int j=0;j<40;j++)
            {
                theta = 0;
                Rad = 7;
                xs++;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);
                    float yy = (float)(Rad * Math.Cos(theta_in_rid));
                    float zz = (float)(Rad * Math.Sin(theta_in_rid));
                    _3D_Point pnn = new _3D_Point(xs, ys + yy, zz + zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    if (j > 0)
                    {
                        AddEdge(ip, ip - 20 * j, Color.DarkMagenta);
                    }
                    theta += 360 / 20;
                    ip++;
                }
            }
            zs = 0;
            //designs
            xs = btempx;
            ys = 130;
            for (int q = 0; q < 6; q++)
            {
                if (q>0)
                {
                    xs -= 50;
                }
                theta = 90;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);

                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));

                    _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    theta -= 180 / 20;
                }
                xs -= 25;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);

                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));

                    _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                    AddPoint(pnn);
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                    if (i == 19)
                    {
                        AddEdge(ip, ip - 39, Color.DarkMagenta);
                    }
                    ip++;
                    theta -= 180 / 20;
                }
            }
            xs -= 100;
            for (int q = 0; q < 2; q++)
            {
                if (q==1)
                {
                    zs += val;
                }
                ys = 170;
                theta = 0;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);

                    float xx = (float)(20 * Math.Cos(theta_in_rid));
                    float yy = (float)(20 * Math.Sin(theta_in_rid));

                    _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    theta += 360 / 20;
                }
                AddEdge(ip - 1, ip - 20, Color.DarkMagenta);
            }
            zs = z;
            xs = btempx;
            ys = 70;
            for (int q = 0; q < 6; q++)
            {
                if (q > 0)
                {
                    xs -= 50;
                }
                theta = 90;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);

                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));

                    _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    theta -= 180 / 20;
                }
                xs -= 25;
                for (int i = 0; i < 20; i++)
                {
                    theta_in_rid = (float)(2 * Math.PI * theta / 360);

                    float xx = (float)(Rad * Math.Cos(theta_in_rid));
                    float yy = (float)(Rad * Math.Sin(theta_in_rid));

                    _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                    AddPoint(pnn);
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                    if (i == 19)
                    {
                        AddEdge(ip, ip - 39, Color.DarkMagenta);
                    }
                    ip++;
                    theta -= 180 / 20;
                }
            }
            xs = 0;
            ys = 70;
            theta = 90;
            for (int i = 0; i < 20; i++)
            {
                theta_in_rid = (float)(2 * Math.PI * theta / 360);

                float xx = (float)(Rad * Math.Cos(theta_in_rid));
                float yy = (float)(Rad * Math.Sin(theta_in_rid));

                _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                AddPoint(pnn);
                if (i > 0)
                {
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                }
                ip++;
                theta -= 180 / 20;
            }
            xs -= 120;
            for (int i = 0; i < 20; i++)
            {
                theta_in_rid = (float)(2 * Math.PI * theta / 360);

                float xx = (float)(Rad * Math.Cos(theta_in_rid));
                float yy = (float)(Rad * Math.Sin(theta_in_rid));

                _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                AddPoint(pnn);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                if (i == 19)
                {
                    AddEdge(ip, ip - 39, Color.DarkMagenta);
                }
                ip++;
                theta -= 180 / 20;
            }
            xs = -300;
            ys = 70;
            theta = 90;
            for (int i = 0; i < 20; i++)
            {
                theta_in_rid = (float)(2 * Math.PI * theta / 360);

                float xx = (float)(Rad * Math.Cos(theta_in_rid));
                float yy = (float)(Rad * Math.Sin(theta_in_rid));

                _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                AddPoint(pnn);
                if (i > 0)
                {
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                }
                ip++;
                theta -= 180 / 20;
            }
            xs -= 120;
            for (int i = 0; i < 20; i++)
            {
                theta_in_rid = (float)(2 * Math.PI * theta / 360);

                float xx = (float)(Rad * Math.Cos(theta_in_rid));
                float yy = (float)(Rad * Math.Sin(theta_in_rid));

                _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                AddPoint(pnn);
                AddEdge(ip, ip - 1, Color.DarkMagenta);
                if (i == 19)
                {
                    AddEdge(ip, ip - 39, Color.DarkMagenta);
                }
                ip++;
                theta -= 180 / 20;
            }
            xs = 0;
            ys = 70;
            for (int k = 0; k < 2; k++)
            {
                if (k==1)
                {
                    ys -= 10;
                    xs += 10;
                }
                for (int j = 0; j < 2; j++)
                {
                    if (j == 1)
                    {
                        xs -= 10;
                    }
                    zs = z;
                    for (int i = 0; i < 20; i++)
                    {
                        _3D_Point pnn = new _3D_Point(xs, ys, zs);
                        AddPoint(pnn);
                        if (i > 0)
                        {
                            AddEdge(ip, ip - 1, Color.DarkMagenta);
                        }
                        ip++;
                        zs -= 5;
                    }
                }
            }
            AddEdge(ip-1, ip - 21, Color.DarkMagenta);
            AddEdge(ip - 41, ip - 61, Color.DarkMagenta);
            AddEdge(ip - 1, ip - 61, Color.DarkMagenta);
            AddEdge(ip - 41, ip - 21, Color.DarkMagenta);
            xs = 50;
            ys = 20;
            zs = z;
            theta = 90;
            for (int i = 0; i < 20; i++)
            {
                theta_in_rid = (float)(2 * Math.PI * theta / 360);

                float xx = (float)(Rad * Math.Cos(theta_in_rid));
                float yy = (float)(Rad * Math.Sin(theta_in_rid));

                _3D_Point pnn = new _3D_Point(xs + xx, yy + ys, zs);
                AddPoint(pnn);
                if (i > 0)
                {
                    AddEdge(ip, ip - 1, Color.DarkMagenta);
                }
                ip++;
                theta += 180 / 20;
            }
            xs += 1;
            tempx = xs;
            ys += 7;
            for (int q = 0; q < 2; q++)
            {
                if (q==1)
                {
                    ys -= 15;
                    xs = tempx;
                }
                for (int i = 0; i < 50; i++)
                {
                    _3D_Point pnn = new _3D_Point(xs, ys, zs);
                    AddPoint(pnn);
                    if (i > 0)
                    {
                        AddEdge(ip, ip - 1, Color.DarkMagenta);
                    }
                    ip++;
                    xs += 5;
                }
            }
            AddEdge(ip-1, ip - 51, Color.DarkMagenta);
            //end of the class
        }
    }
}
