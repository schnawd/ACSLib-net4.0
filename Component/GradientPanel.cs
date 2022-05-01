using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ACS.Librairie
{
    public partial class GradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        private float _angle = 90;
        public float Angle { get => _angle; set => _angle = value; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);


        }
        public GradientPanel()
        {
            InitializeComponent();

        }
    }
}
