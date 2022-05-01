
namespace ACS.Librairie
{
    partial class UCClient
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
            this.adgv = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.adgv)).BeginInit();
            this.SuspendLayout();
            // 
            // adgv
            // 
            this.adgv.AllowUserToOrderColumns = true;
            this.adgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adgv.FilterAndSortEnabled = true;
            this.adgv.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv.Location = new System.Drawing.Point(0, 0);
            this.adgv.MultiSelect = false;
            this.adgv.Name = "adgv";
            this.adgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgv.Size = new System.Drawing.Size(520, 308);
            this.adgv.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv.TabIndex = 2;
            // 
            // UCClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adgv);
            this.Name = "UCClient";
            this.Size = new System.Drawing.Size(520, 308);
            this.Controls.SetChildIndex(this.adgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.adgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView adgv;
    }
}
