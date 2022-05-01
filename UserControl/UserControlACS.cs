using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACS.Librairie
{
    public partial class UserControlACS : UserControl
    {
        public UserControlACS()
        {
            InitializeComponent();
        }

        private int _selected;
        public int selected { get => _selected; set { _selected = value; Selection(); } }

        /*
        private Produit _selectedProduit;
        public Produit selectedProduit { get => _selectedProduit; set { _selectedProduit = value; Selection(); } }
        */

        private List<Produit> _listeProduits;
        public List<Produit> listeProduits { get => _listeProduits; set { _listeProduits = value; refreshDGV(value); } }

        private List<Client> _listeClients;
        public List<Client> listeClients { get => _listeClients; set { _listeClients = value; refreshDGV(value); } }

        private List<FactureClient> _listeFacturesClients;
        public List<FactureClient> listeFacturesClients { get => _listeFacturesClients; set { _listeFacturesClients = value; refreshDGV(value); } }

        private List<Demande> _listeDemandes;
        public List<Demande> listeDemandes { get => _listeDemandes; set { _listeDemandes = value; refreshDGV(value); } }

        private List<FactureFournisseur> _listeFactureFournisseur;
        public List<FactureFournisseur> listeFactureFournisseur { get => _listeFactureFournisseur; set { _listeFactureFournisseur = value; refreshDGV(value); } }

        private List<FicheAtelier> _listeFicheAtelier;
        public List<FicheAtelier> listeFicheAtelier { get => _listeFicheAtelier; set { _listeFicheAtelier = value; refreshDGV(value); } }

        private List<Fournisseur> _listeFournisseur;
        public List<Fournisseur> listeFournisseur { get => _listeFournisseur; set { _listeFournisseur = value; refreshDGV(value); } }

        private List<Licence> _listeLicence;
        public List<Licence> listeLicence { get => _listeLicence; set { _listeLicence = value; refreshDGV(value); } }

        private List<Utilisateur> _listeUtilisateur;
        public List<Utilisateur> listeUtilisateur { get => _listeUtilisateur; set { _listeUtilisateur = value; refreshDGV(value); } }

        public event EventHandler _selectedObjectChanged;
        private bool _canEditSelected = true;

        #region Paramètres
        [Category("Configuration")]
        public bool CanEditSelected
        {
            get
            {
                return this._canEditSelected;
            }
            set
            {
                this._canEditSelected = value;
            }
        }
        #endregion

        private DataTable refreshDGV<T>(IList<T> liste)
        {
            // Pour déselectionner une ligne
            DataTable dt = null;
            selected = -1;
            dgv.CurrentCell = null;
            dgv.ClearSelection();

            if (liste != null)
            {
                dt = Fonctions.ConvertToDataTable(liste);
                dgv.DataSource = dt;
                Conception.InitializeDataGridView(dgv);
            }

            return dt;
        }

        private void Selection()
        {
            EventArgs e = new EventArgs();
            if (this._selectedObjectChanged != null)
                this._selectedObjectChanged(this, e);
        }

        private void OpenForm()
        {
            /*
            FormEditClient frm = new FormEditClient(selected);
            frm.ShowDialog();
            */
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = e.RowIndex;
            if (select != -1)
            {
                selected = (int)dgv.Rows[e.RowIndex].Cells["Id"].Value;
                //MessageBox.Show(selected.ToString());
            }
            /*
            if (select >= 0)
            {
                selected = ;
            }
            */
            else selected = -1;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CanEditSelected)
            {
                int select = e.RowIndex;
                if (select >= 0)
                {
                    //selected = listeElements[select];
                    selected = (int)dgv.Rows[e.RowIndex].Cells["Id"].Value;
                    OpenForm();
                }
                else selected = -1;
            }
        }
    
    }
}
