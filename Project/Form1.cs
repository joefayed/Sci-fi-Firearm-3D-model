using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        //variables
        int mx, my;
        //=============================================================
        //Flags
        bool right_mouse_down = false;
        bool left_mouse_down = false;
        bool rgb = true;
        //=============================================================
        //Models / Objects
        Parmetric_Model middlepart = new Parmetric_Model();
        _3D_Model rotatingx = new _3D_Model();
        _3D_Model rotatingy = new _3D_Model();
        _3D_Model rotatingz = new _3D_Model();
        //=============================================================
        //MISC
        Bitmap off;
        Camera cam = new Camera();
        Timer t = new Timer();
        //=============================================================
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += Form1_Paint;
            this.Load+=Form1_Load;
            this.KeyDown+=Form1_KeyDown;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
            t.Tick += t_Tick;
            t.Interval = 100;
            t.Start();
        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (right_mouse_down)
            {
                if (e.X > mx)
                {
                    _3D_Point v1 = new _3D_Point(rotatingz.L_3D_Pts[0].X, rotatingz.L_3D_Pts[0].Y, rotatingz.L_3D_Pts[0].Z);
                    _3D_Point v2 = new _3D_Point(rotatingz.L_3D_Pts[5].X, rotatingz.L_3D_Pts[5].Y, rotatingz.L_3D_Pts[5].Z);
                    Transformation.RotateArbitrary(middlepart.L_3D_Pts, v1, v2, -5f);
                    //Transformation.RotateArbitrary(middlepart2.L_3D_Pts, v1, v2, -5f);
                }
                else if (e.X < mx)
                {
                    _3D_Point v1 = new _3D_Point(rotatingz.L_3D_Pts[0].X, rotatingz.L_3D_Pts[0].Y, rotatingz.L_3D_Pts[0].Z);
                    _3D_Point v2 = new _3D_Point(rotatingz.L_3D_Pts[5].X, rotatingz.L_3D_Pts[5].Y, rotatingz.L_3D_Pts[5].Z);
                    Transformation.RotateArbitrary(middlepart.L_3D_Pts, v1, v2, 5f);
                    //Transformation.RotateArbitrary(middlepart2.L_3D_Pts, v1, v2, 5f);
                }
            }
            else if (left_mouse_down)
            {
                if (e.X>mx)
                {
                    _3D_Point v1 = new _3D_Point(rotatingx.L_3D_Pts[2].X, rotatingx.L_3D_Pts[2].Y, rotatingx.L_3D_Pts[2].Z);
                    _3D_Point v2 = new _3D_Point(rotatingx.L_3D_Pts[5].X, rotatingx.L_3D_Pts[5].Y, rotatingx.L_3D_Pts[5].Z);
                    Transformation.RotateArbitrary(middlepart.L_3D_Pts, v1, v2, 5f);
                    //Transformation.RotateArbitrary(middlepart2.L_3D_Pts, v1, v2, 5f);
                }
                else if (e.X<mx)
                {
                    _3D_Point v1 = new _3D_Point(rotatingx.L_3D_Pts[2].X, rotatingx.L_3D_Pts[2].Y, rotatingx.L_3D_Pts[2].Z);
                    _3D_Point v2 = new _3D_Point(rotatingx.L_3D_Pts[5].X, rotatingx.L_3D_Pts[5].Y, rotatingx.L_3D_Pts[5].Z);
                    Transformation.RotateArbitrary(middlepart.L_3D_Pts, v1, v2, -5f);
                    //Transformation.RotateArbitrary(middlepart2.L_3D_Pts, v1, v2, -5f);
                }
                else if (e.Y>my)
                {
                    _3D_Point v1 = new _3D_Point(rotatingy.L_3D_Pts[2].X, rotatingy.L_3D_Pts[2].Y, rotatingy.L_3D_Pts[2].Z);
                    _3D_Point v2 = new _3D_Point(rotatingy.L_3D_Pts[5].X, rotatingy.L_3D_Pts[5].Y, rotatingy.L_3D_Pts[5].Z);
                    Transformation.RotateArbitrary(middlepart.L_3D_Pts, v1, v2, 5f);
                    //Transformation.RotateArbitrary(middlepart2.L_3D_Pts, v1, v2, 5f);
                }
                else if (e.Y<my)
                {
                    _3D_Point v1 = new _3D_Point(rotatingy.L_3D_Pts[2].X, rotatingy.L_3D_Pts[2].Y, rotatingy.L_3D_Pts[2].Z);
                    _3D_Point v2 = new _3D_Point(rotatingy.L_3D_Pts[5].X, rotatingy.L_3D_Pts[5].Y, rotatingy.L_3D_Pts[5].Z);
                    Transformation.RotateArbitrary(middlepart.L_3D_Pts, v1, v2, -5f);
                    //Transformation.RotateArbitrary(middlepart2.L_3D_Pts, v1, v2, -5f);
                }
            }
            else
            {
            }
            mx = e.X;
            my = e.Y;
        }

        void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            right_mouse_down = false;
            left_mouse_down = false;
        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                right_mouse_down = true;
                mx = e.X;
                my = e.Y;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                left_mouse_down = true;
            }
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Camera Rotation
            //Rotate X
            if (e.KeyCode == Keys.X)
            {
                _3D_Point cpyOfCop = new _3D_Point(cam.cop);
                _3D_Model mdl = new _3D_Model();
                mdl.AddPoint(cpyOfCop);
                _3D_Point vv1 = new _3D_Point(cam.lookAt);
                _3D_Point vv2 = new _3D_Point(cam.lookAt);
                vv2.X -= 10;

                Transformation.RotateArbitrary(mdl.L_3D_Pts, vv1, vv2, 10);
                cam.cop = new _3D_Point(cpyOfCop);
                cam.BuildNewSystem();
            }
            //Rotate Y
            else if (e.KeyCode==Keys.Y)
            {
                _3D_Point cpyOfCop = new _3D_Point(cam.cop);
                _3D_Model mdl = new _3D_Model();
                mdl.AddPoint(cpyOfCop);
                _3D_Point vv1 = new _3D_Point(cam.lookAt);
                _3D_Point vv2 = new _3D_Point(cam.lookAt);
                vv2.Y -= 10;

                Transformation.RotateArbitrary(mdl.L_3D_Pts, vv1, vv2, 10);
                cam.cop = new _3D_Point(cpyOfCop);
                cam.BuildNewSystem();
            }
            //Rotate Z
            else if (e.KeyCode == Keys.Z)
            {
                _3D_Point cpyOfCop = new _3D_Point(cam.cop);
                _3D_Model mdl = new _3D_Model();
                mdl.AddPoint(cpyOfCop);
                _3D_Point vv1 = new _3D_Point(cam.lookAt);
                _3D_Point vv2 = new _3D_Point(cam.lookAt);
                vv2.Z -= 10;

                Transformation.RotateArbitrary(mdl.L_3D_Pts, vv1, vv2, 10);
                cam.cop = new _3D_Point(cpyOfCop);
                cam.BuildNewSystem();
            }
            //===================================================================================================
            else if (e.KeyCode==Keys.H)
            {
                _3D_Point v1 = new _3D_Point(rotatingx.L_3D_Pts[2].X, rotatingx.L_3D_Pts[2].Y, rotatingx.L_3D_Pts[2].Z);
                _3D_Point v2 = new _3D_Point(rotatingx.L_3D_Pts[5].X, rotatingx.L_3D_Pts[5].Y, rotatingx.L_3D_Pts[5].Z);
                Transformation.RotateArbitrary(middlepart.L_3D_Pts, v1, v2, 5f);
                //ransformation.RotateArbitrary(middlepart2.L_3D_Pts, v1, v2, 5f);
            }
            else if (e.KeyCode == Keys.J)
            {
                _3D_Point v1 = new _3D_Point(rotatingy.L_3D_Pts[2].X, rotatingy.L_3D_Pts[2].Y, rotatingy.L_3D_Pts[2].Z);
                _3D_Point v2 = new _3D_Point(rotatingy.L_3D_Pts[5].X, rotatingy.L_3D_Pts[5].Y, rotatingy.L_3D_Pts[5].Z);
                Transformation.RotateArbitrary(middlepart.L_3D_Pts, v1, v2, 5f);
                //Transformation.RotateArbitrary(middlepart2.L_3D_Pts, v1, v2, 5f);
            }
            else if (e.KeyCode == Keys.K)
            {
                _3D_Point v1 = new _3D_Point(rotatingz.L_3D_Pts[0].X, rotatingz.L_3D_Pts[0].Y, rotatingz.L_3D_Pts[0].Z);
                _3D_Point v2 = new _3D_Point(rotatingz.L_3D_Pts[5].X, rotatingz.L_3D_Pts[5].Y, rotatingz.L_3D_Pts[5].Z);
                Transformation.RotateArbitrary(middlepart.L_3D_Pts, v1, v2, 5f);
                //Transformation.RotateArbitrary(middlepart2.L_3D_Pts, v1, v2, 5f);
            }
            else if (e.KeyCode==Keys.Left)
            {
                rgb = !rgb;
            }
            else if (e.KeyCode==Keys.Right)
            {
                rgb = !rgb;
            }
        }

        void t_Tick(object sender, EventArgs e)
        {
            DrawDubble(this.CreateGraphics());
        }
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubble(e.Graphics);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Setup_Camera();
            middlepart.cam = cam;
            middlepart.design_middle(500, 100, 0);
            //middlepart2.cam = cam;
            //middlepart2.design_middle2(500, 100, 50);
            rotatingx.cam = cam;
            Create_Cube(rotatingx, 20, 1, -480, 1000, 45, 1, Color.Magenta);
            rotatingy.cam = cam;
            Create_Cube(rotatingy, -55, 150, 0, 1, 45, 1, Color.Green);
            rotatingz.cam = cam;
            Create_Cube(rotatingz, 20, 1, 0, 1, 0, 100, Color.Red);
        }
        void Create_Cube(_3D_Model M,float XLeft, float wWidth,float YBottom, float hHight,float ZS, float Depth,Color vvv)
        {
            float[] vert = 
                            { 
                                    XLeft+wWidth            ,YBottom + hHight       ,ZS,
                                    XLeft+wWidth            ,YBottom + hHight       ,ZS+Depth,
                                    XLeft                   ,YBottom + hHight       ,ZS+Depth,
                                    XLeft                   ,YBottom + hHight       ,ZS,
                                    XLeft+wWidth            ,YBottom                ,ZS,
                                    XLeft+wWidth            ,YBottom                ,ZS+Depth,
                                    XLeft                   ,YBottom                ,ZS+Depth,
                                    XLeft                   ,YBottom                ,ZS
                                
                            };


            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                pnn = new _3D_Point(vert[j], vert[j + 1], vert[j + 2]);
                j += 3;
                M.AddPoint(pnn);
            }


            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                                4,5,
                                5,6,
                                6,7,
                                7,4,
                                0,4,
                                3,7,
                                2,6,
                                1,5
                          };
            j = 0;
            for (int i = 0; i < 12; i++)
            {
                M.AddEdge(Edges[j], Edges[j + 1], vvv);

                j += 2;
            }
        }
        void Setup_Camera()
        {
            int cx = 400;
            int cy = 400;
            cam.ceneterX = (this.ClientSize.Width / 2);
            cam.ceneterY = (this.ClientSize.Height / 2);
            cam.cxScreen = cx;
            cam.cyScreen = cy;
            cam.BuildNewSystem();
        }
        void DrawDubble(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
        void DrawScene(Graphics g)
        {
            g.Clear(Color.Black);
            middlepart.DrawYourSelf(g,rgb);
            //middlepart2.DrawYourSelf(g);
            /*rotatingx.DrawYourSelf(g);
            rotatingy.DrawYourSelf(g);
            rotatingz.DrawYourSelf(g);*/
        }

    }
}
