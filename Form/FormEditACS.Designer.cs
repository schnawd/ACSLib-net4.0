
namespace ACS.Librairie
{
    partial class FormEditACS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditACS));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTabAccueil = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelEdition = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonEdit = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSave = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSaveQuit = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelCommunication = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonPrint = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSendSMS = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSendMail = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelControle = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonHelp = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonQuit = new System.Windows.Forms.RibbonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(709, 176);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTabAccueil);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTabAccueil
            // 
            this.ribbonTabAccueil.Name = "ribbonTabAccueil";
            this.ribbonTabAccueil.Panels.Add(this.ribbonPanelEdition);
            this.ribbonTabAccueil.Panels.Add(this.ribbonPanelCommunication);
            this.ribbonTabAccueil.Panels.Add(this.ribbonPanelControle);
            this.ribbonTabAccueil.Text = "Accueil";
            // 
            // ribbonPanelEdition
            // 
            this.ribbonPanelEdition.Items.Add(this.ribbonButtonEdit);
            this.ribbonPanelEdition.Items.Add(this.ribbonButtonSave);
            this.ribbonPanelEdition.Items.Add(this.ribbonButtonSaveQuit);
            this.ribbonPanelEdition.Name = "ribbonPanelEdition";
            this.ribbonPanelEdition.Text = "Edition";
            // 
            // ribbonButtonEdit
            // 
            this.ribbonButtonEdit.Image = global::ACSLib_net4._0.Properties.Resources.ACS_Modifier;
            this.ribbonButtonEdit.LargeImage = global::ACSLib_net4._0.Properties.Resources.ACS_Modifier;
            this.ribbonButtonEdit.Name = "ribbonButtonEdit";
            this.ribbonButtonEdit.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonEdit.SmallImage")));
            this.ribbonButtonEdit.Text = "Modifier";
            // 
            // ribbonButtonSave
            // 
            this.ribbonButtonSave.Image = global::ACSLib_net4._0.Properties.Resources.ACS_Enregistrer;
            this.ribbonButtonSave.LargeImage = global::ACSLib_net4._0.Properties.Resources.ACS_Enregistrer;
            this.ribbonButtonSave.Name = "ribbonButtonSave";
            this.ribbonButtonSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.SmallImage")));
            this.ribbonButtonSave.Text = "Enregistrer";
            // 
            // ribbonButtonSaveQuit
            // 
            this.ribbonButtonSaveQuit.Image = global::ACSLib_net4._0.Properties.Resources.ACS_Enregistrer_Fermer;
            this.ribbonButtonSaveQuit.LargeImage = global::ACSLib_net4._0.Properties.Resources.ACS_Enregistrer_Fermer;
            this.ribbonButtonSaveQuit.Name = "ribbonButtonSaveQuit";
            this.ribbonButtonSaveQuit.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSaveQuit.SmallImage")));
            this.ribbonButtonSaveQuit.Text = "Enregistrer et fermer";
            // 
            // ribbonPanelCommunication
            // 
            this.ribbonPanelCommunication.Items.Add(this.ribbonButtonPrint);
            this.ribbonPanelCommunication.Items.Add(this.ribbonButtonSendSMS);
            this.ribbonPanelCommunication.Items.Add(this.ribbonButtonSendMail);
            this.ribbonPanelCommunication.Name = "ribbonPanelCommunication";
            this.ribbonPanelCommunication.Text = "Communication";
            // 
            // ribbonButtonPrint
            // 
            this.ribbonButtonPrint.Image = global::ACSLib_net4._0.Properties.Resources.ACS_Imprimer;
            this.ribbonButtonPrint.LargeImage = global::ACSLib_net4._0.Properties.Resources.ACS_Imprimer;
            this.ribbonButtonPrint.Name = "ribbonButtonPrint";
            this.ribbonButtonPrint.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPrint.SmallImage")));
            this.ribbonButtonPrint.Text = "Imprimer";
            // 
            // ribbonButtonSendSMS
            // 
            this.ribbonButtonSendSMS.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSendSMS.Image")));
            this.ribbonButtonSendSMS.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSendSMS.LargeImage")));
            this.ribbonButtonSendSMS.Name = "ribbonButtonSendSMS";
            this.ribbonButtonSendSMS.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSendSMS.SmallImage")));
            this.ribbonButtonSendSMS.Text = "Envoi SMS";
            // 
            // ribbonButtonSendMail
            // 
            this.ribbonButtonSendMail.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSendMail.Image")));
            this.ribbonButtonSendMail.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSendMail.LargeImage")));
            this.ribbonButtonSendMail.Name = "ribbonButtonSendMail";
            this.ribbonButtonSendMail.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSendMail.SmallImage")));
            this.ribbonButtonSendMail.Text = "Envoi Email";
            // 
            // ribbonPanelControle
            // 
            this.ribbonPanelControle.Items.Add(this.ribbonButtonHelp);
            this.ribbonPanelControle.Items.Add(this.ribbonButtonQuit);
            this.ribbonPanelControle.Name = "ribbonPanelControle";
            this.ribbonPanelControle.Text = "Contrôle";
            // 
            // ribbonButtonHelp
            // 
            this.ribbonButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelp.Image")));
            this.ribbonButtonHelp.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelp.LargeImage")));
            this.ribbonButtonHelp.Name = "ribbonButtonHelp";
            this.ribbonButtonHelp.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelp.SmallImage")));
            this.ribbonButtonHelp.Text = "Aide";
            // 
            // ribbonButtonQuit
            // 
            this.ribbonButtonQuit.Image = global::ACSLib_net4._0.Properties.Resources.ACS_Quitter;
            this.ribbonButtonQuit.LargeImage = global::ACSLib_net4._0.Properties.Resources.ACS_Quitter;
            this.ribbonButtonQuit.Name = "ribbonButtonQuit";
            this.ribbonButtonQuit.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonQuit.SmallImage")));
            this.ribbonButtonQuit.Text = "Quitter";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 372);
            this.panel1.TabIndex = 1;
            // 
            // FormEditACS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Name = "FormEditACS";
            this.Text = "FormEditACS";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Ribbon ribbon1;
        public System.Windows.Forms.RibbonTab ribbonTabAccueil;
        public System.Windows.Forms.RibbonPanel ribbonPanelEdition;
        public System.Windows.Forms.RibbonButton ribbonButtonEdit;
        public System.Windows.Forms.RibbonButton ribbonButtonSave;
        public System.Windows.Forms.RibbonButton ribbonButtonSaveQuit;
        public System.Windows.Forms.RibbonPanel ribbonPanelCommunication;
        public System.Windows.Forms.RibbonButton ribbonButtonPrint;
        public System.Windows.Forms.RibbonButton ribbonButtonSendSMS;
        public System.Windows.Forms.RibbonButton ribbonButtonSendMail;
        public System.Windows.Forms.RibbonPanel ribbonPanelControle;
        public System.Windows.Forms.RibbonButton ribbonButtonHelp;
        public System.Windows.Forms.RibbonButton ribbonButtonQuit;
        public System.Windows.Forms.Panel panel1;
    }
}