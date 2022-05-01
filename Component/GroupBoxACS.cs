using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACS.Librairie
{
    [System.Drawing.ToolboxBitmap(@"D:\App.ico")]                    // Changer l'icone dans la barre d'outils
    //public partial class GroupBoxACS : ContainerControl
    public partial class GroupBoxACS : ContainerControl
    {
        public GroupBoxACS()
        {
            InitializeComponent();
            changeBorderColor(BorderColor);
        }

        //private Color _borderColor = Color.DeepSkyBlue;
        private Color _borderColor = ColorACS.Bleu1;
        private string _textGroupBox = "GroupBox ACS";
        private Color _textColor = System.Drawing.Color.White;
        protected Color _gradientColor = ColorACS.Bleu2;
        // 25, 140, 220
        // Sombre 233, 243, 255
        // Clair 200, 217, 237
        //private Font _textFont = new System.Drawing.Font();

        #region Paramètres

        
        public Color BorderColor
        {
            get
            {
                return this._borderColor;
            }
            set
            {
                this._borderColor = value;
                changeBorderColor(value);
            }
        }

        public string Text
        {
            get
            {
                return this._textGroupBox;
            }
            set
            {
                this._textGroupBox = value;
                label1.Text = value;
            }
        }

        public Color TextColor
        {
            get
            {
                return this._textColor;
            }
            set
            {
                this._textColor = value;
                label1.ForeColor = value;
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            int x = gradientPanelTop.Width / 2 - label1.Width / 2;
            int y = gradientPanelTop.Height / 2 - label1.Height / 2;
            Point location = new Point(x, y);
            label1.Location = location;
            label1.BackColor = System.Drawing.Color.Transparent;
            base.OnPaint(e);
        }
        private void changeBorderColor(Color cl)
        {
            panelBottom.BackColor = cl;
            panelLeft.BackColor = cl;
            panelRight.BackColor = cl;
            gradientPanelTop.TopColor = cl;
            gradientPanelTop.BottomColor = _gradientColor;
        }
    }
}
