using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace FlattenCombo
{
    public class CustomCombo : ComboBox
    {
        private Brush BorderBrush = new SolidBrush(SystemColors.WindowFrame);
        private Brush ArrowBrush = new SolidBrush(/*SystemColors.ControlText*/ Color.White);
        private Brush DropButtonBrush = new SolidBrush(SystemColors.Control);

        public CustomCombo()
        {
            //InitializeComponent();
            //SetStyle(ControlStyles.UserPaint, true);
        }

        private Color _ButtonColor = SystemColors.Control;
        public Color ButtonColor
        {
            get { return _ButtonColor; }
            set
            {
                _ButtonColor = value;
                DropButtonBrush = new SolidBrush(this.ButtonColor);
                this.Invalidate();
            }
        }

        private Color _borderColor = Color.Black;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        //private static int WM_PAINT = 0x000F;

        [Category("Appearance")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        public ButtonBorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                this.Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);



            /*if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
            }*/

            switch (m.Msg)
            {
                case 0xf:
                    //Graphics g = Graphics.FromHwnd(Handle);
                    Graphics g = this.CreateGraphics();
                    Rectangle bounds = new Rectangle(0, 0, Width, Height);
                    ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);

                    //Pen p = new Pen(Color.White, 2);
                    g.FillRectangle(BorderBrush, this.ClientRectangle);

                    Rectangle rect = new Rectangle(this.Width - 18, 0, 18, this.Height);
                    g.FillRectangle(DropButtonBrush, rect);
                    //g.FillPath(DropButtonBrush, RoundedRect(rect, 7));

                    System.Drawing.Drawing2D.GraphicsPath pth = new System.Drawing.Drawing2D.GraphicsPath();
                    PointF TopLeft = new PointF(this.Width - 13, (this.Height - 5) / 2);
                    PointF TopRight = new PointF(this.Width - 6, (this.Height - 5) / 2);
                    PointF Bottom = new PointF(this.Width - 9, (this.Height + 2) / 2);
                    pth.AddLine(TopLeft, TopRight);
                    pth.AddLine(TopRight, Bottom);

                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                    /*if (this.DroppedDown)
                    {
                        ArrowBrush = new SolidBrush(SystemColors.HighlightText);
                    }
                    else
                    {
                        ArrowBrush = new SolidBrush(SystemColors.ControlText);
                    }*/

                    g.FillPath(ArrowBrush, pth);

                    g.Dispose();

                    break;
            }
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            //BorderBrush = new SolidBrush(SystemColors.Highlight);
            //EnableDoubleBuffering();
            this.Invalidate();
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            /*if (this.Focused)
                return;*/
            BorderBrush = new SolidBrush(SystemColors.WindowFrame);
            //EnableDoubleBuffering();
            this.Invalidate();
        }

        protected override void OnLostFocus(System.EventArgs e)
        {
            base.OnLostFocus(e);
            //BorderBrush = new SolidBrush(SystemColors.Window);
            //EnableDoubleBuffering();
            this.Invalidate();
        }

        protected override void OnGotFocus(System.EventArgs e)
        {
            base.OnGotFocus(e);
            BorderBrush = new SolidBrush(SystemColors.WindowFrame);
            //EnableDoubleBuffering();
            this.Invalidate();
        }

        protected override void OnMouseHover(System.EventArgs e)
        {
            base.OnMouseHover(e);
            BorderBrush = new SolidBrush(SystemColors.WindowFrame);
            //EnableDoubleBuffering();
            this.Invalidate();
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }
            
            path.AddArc(arc, 180, 90);
            
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}