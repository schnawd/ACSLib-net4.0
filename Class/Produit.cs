using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACS.Librairie
{
    public class Produit
    {
        private static string urlMain = Settings.urlProduits;

        public int? Id { get; set; }
        public string Ref { get; set; }
        public string Label { get; set; }
        public decimal? PrixVenteTTC { get; set; }
        public double? Stock { get; set; }
        public decimal? PrixVenteHT { get; set; }
        public decimal? PrixAchat { get; set; }
        public string Description { get; set; }
        public string CodeBarre { get; set; }
        public string DateCreation { get; set; }

        //public Categorie selectedCategorie { get; set; }

        #region Constructeur
        public Produit() { }

        public Produit(int Id)
        {
            hydrate(Id);
        }
        #endregion

        private void hydrate(int id)
        {
            try
            {
                string url = urlMain + "?id=" + id.ToString();
                string json = Fonctions.RequeteWeb(url);
                Produit obj = JsonConvert.DeserializeObject<Produit>(json);

                this.Id = obj.Id;
                this.Ref = obj.Ref;
                this.Label = obj.Label;
                this.Description = obj.Description;
                this.PrixAchat = obj.PrixAchat;
                this.PrixVenteHT = obj.PrixVenteHT;
                this.PrixVenteTTC = obj.PrixVenteTTC;
                this.Stock = obj.Stock;
                this.DateCreation = obj.DateCreation;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                //return null;
            }
        }

        public void Enregistrer()
        {
            string urlsave = urlMain;
            string json = JsonConvert.SerializeObject(this);
            string resultat = Fonctions.RequeteWeb(urlsave, json);
            Produit pr = JsonConvert.DeserializeObject<Produit>(resultat);
            hydrate((int)pr.Id);
        }

        public static List<Produit> Items()
        {
            string recherche = urlMain + "?q=" + "" + "&nb=30";
            return Recherche(recherche);
        }

        public static List<Produit> Items(string Query)
        {
            //Filtre.enStock = true;
            string recherche = urlMain + "?q=" + Query + "&nb=30";
            return Recherche(recherche);
        }

        private static List<Produit> Recherche(string requete)
        {
            string json = Fonctions.RequeteWeb(requete);
            List<Produit> listeProduits = JsonConvert.DeserializeObject<List<Produit>>(json);
            return listeProduits;
        }

        protected static class Filtre
        {
            public static bool enStock;
        }
    }

    
}
