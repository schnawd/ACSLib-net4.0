using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ACS.Librairie
{
    public class Fonctions
    {
        #region RequetesWeb
        public static string RequeteWeb(string url)
        {
            try
            {
                WebClient wc = new WebClient();
                string html = wc.DownloadString(url);

                return html;
            }
            catch (Exception e)
            {
                //MessageBox.Show("Il n'y a pas de connection internet !");
                return "Erreur internet" + e.Message;
            }
        }

        public static string RequeteWeb(string url, string data)
        {
            WebClient wc = new WebClient();

            var values = new NameValueCollection();
            values["json"] = data;

            var response = wc.UploadValues(url, values);
            string html = Encoding.Default.GetString(response);

            //string html = wc.UploadString(url, data);

            return html;
        }
        #endregion

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }

    public class Conception
    {
        //public static Color CouleurBleuPale = Color.FromArgb(176, 203, 240);
        public static Color CouleurBleuPale = Color.FromArgb(213, 227, 245);
        public static Color CouleurBleuEnTete = Color.FromArgb(190, 208, 232);
        public static Color CouleurTexte = Color.FromArgb(21, 66, 139);
        public static Color CouleurJaune = Color.FromArgb(176, 203, 0);

        public static void InitializeDataGridView(DataGridView dgv)
        {                                                                                        // 
            // Dimension 1ere colonne                                                            // 
            dgv.RowHeadersWidth = 20;                                                            // 
            dgv.RowHeadersVisible = false;                                                       // 
                                                                                                 // 
                                                                                                 // Initialize basic DataGridView properties.                                         // 
                                                                                                 //                                                                                   // 
            dgv.Dock = DockStyle.Fill;                                                           // 
            dgv.BackgroundColor = CouleurBleuPale;                                               // 
            dgv.BorderStyle = BorderStyle.Fixed3D;                                               // 
            dgv.EnableHeadersVisualStyles = false;                                               // 
                                                                                                 // 
                                                                                                 // Set property values appropriate for read-only display and                         // 
                                                                                                 // limited interactivity.                                                            // 
                                                                                                 //                                                                                   // 
            dgv.AllowUserToAddRows = false;                                                      // 
            dgv.AllowUserToDeleteRows = false;                                                   // 
            dgv.AllowUserToOrderColumns = true;                                                  // 
            dgv.ReadOnly = true;                                                                 // 
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                         // 
            dgv.MultiSelect = false;                                                             // 
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;                            // 
            dgv.AllowUserToResizeColumns = true;                                                 // Autoriser l'utilisateur à redimensionner les colonnes
            dgv.ColumnHeadersHeightSizeMode =                                                    // 
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;                         // 
            dgv.AllowUserToResizeRows = false;                                                   // 
            dgv.RowHeadersWidthSizeMode =                                                        // 
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;                             // 
                                                                                                 // 
                                                                                                 // Set the selection background color for all the cells.                             // 
            dgv.DefaultCellStyle.SelectionBackColor = Color.White;                               // 
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;                               // 
                                                                                                 // 
                                                                                                 // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default             // 
                                                                                                 // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.            // 
                                                                                                 //dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DarkBlue;                  // Couleur de sélection
            dgv.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;                              // 
                                                                                                    // 
                                                                                                    // Set the background color for all rows and for alternating rows.                   // 
                                                                                                    // The value for alternating rows overrides the value for all rows.                  // 
            dgv.RowsDefaultCellStyle.BackColor = Color.White;                                    // Couleur par défaut des lignes
            dgv.AlternatingRowsDefaultCellStyle.BackColor = CouleurBleuPale;                     // Couleur alternative des lignes
                                                                                                 // 
                                                                                                 // Définit le style et en-têtes des lignes et colonnes.                              // 
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;                           // 
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Conception.CouleurBleuPale;            // 
            dgv.RowHeadersDefaultCellStyle.BackColor = Conception.CouleurBleuPale;               // 

            // Set the Format property on the "Last Prepared" column to cause
            // the DateTime to be formatted as "Month, Year".
            if (dgv.Columns["DateCreation"] != null) dgv.Columns["DateCreation"].DefaultCellStyle.Format = "dd-MM-yyyy";
            //if (dataGridView1.Columns["PrixAchat"] != null) dataGridView1.Columns["PrixAchatHT"].DefaultCellStyle.Format = "0.##";

            // Specify a larger font for the "Ratings" column. 
            /*
            using (Font font = new Font(
                dataGridView1.DefaultCellStyle.Font.FontFamily, 25, FontStyle.Bold))
            {
                dataGridView1.Columns["Rating"].DefaultCellStyle.Font = font;
            }
            */

            // Attach a handler to the CellFormatting event.
            dgv.CellFormatting += new DataGridViewCellFormattingEventHandler(dg_CellFormatting);
        }

        private static void dg_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is decimal)
            {
                e.CellStyle.Format = "# ##0.00 €";
            }
        }
    }

}
