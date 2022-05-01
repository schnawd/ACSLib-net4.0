
namespace ACS.Librairie
{
    partial class GroupBoxACS
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.gradientPanelTop = new ACS.Librairie.GradientPanel();
            this.gradientPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GroupBoxACS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1, 136);
            this.panelLeft.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(175, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1, 136);
            this.panelRight.TabIndex = 2;
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(1, 135);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(174, 1);
            this.panelBottom.TabIndex = 3;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(1, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(174, 135);
            this.panelContainer.TabIndex = 4;
            // 
            // gradientPanelTop
            // 
            this.gradientPanelTop.Angle = 90F;
            this.gradientPanelTop.BottomColor = System.Drawing.Color.Cyan;
            this.gradientPanelTop.Controls.Add(this.label1);
            this.gradientPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanelTop.Location = new System.Drawing.Point(1, 0);
            this.gradientPanelTop.Name = "gradientPanelTop";
            this.gradientPanelTop.Size = new System.Drawing.Size(174, 29);
            this.gradientPanelTop.TabIndex = 0;
            this.gradientPanelTop.TopColor = System.Drawing.Color.Blue;
            // 
            // GroupBoxACS
            // 
            this.Controls.Add(this.gradientPanelTop);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Size = new System.Drawing.Size(176, 136);
            this.gradientPanelTop.ResumeLayout(false);
            this.gradientPanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelContainer;
        private GradientPanel gradientPanelTop;
    }
}
