using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.Librairie
{
    public class FactureFournisseur
    {
        private static string urlMain = Settings.urlFacturesFournisseur;


        public int? Id { get; set; }
        public string Ref { get; set; }
        public string RefFournisseur { get; set; }
        public string FichierPDF { get; set; }
        public int IdFournisseur { get; set; }
        public double TotalHT { get; set; }
        public double TotalTVA { get; set; }
        public double TotalTTC { get; set; }
        public DateTime DateFacture { get; set; }
        public DateTime DateCreation { get; set; }
        public int EstPaye { get; set; }
        public int PiecesRecues { get; set; }

        public FactureFournisseur() { }

        public FactureFournisseur(int Id)
        {
            hydrate(Id);
        }

        public void Enregistrer()
        {
            string urlsave = urlMain;
            string json = JsonConvert.SerializeObject(this);
            string resultat = Fonctions.RequeteWeb(urlsave, json);

            FactureFournisseur obj = JsonConvert.DeserializeObject<FactureFournisseur>(resultat);
            hydrate((int)obj.Id);
        }

        private void hydrate(int id)
        {
            string url = urlMain + "?id=" + id.ToString();
            string json = Fonctions.RequeteWeb(url);
            FactureFournisseur obj = JsonConvert.DeserializeObject<FactureFournisseur>(json);

            this.Id = obj.Id;
            this.Ref = obj.Ref;
            this.RefFournisseur = obj.RefFournisseur;
            this.FichierPDF = obj.FichierPDF;
            this.IdFournisseur = obj.IdFournisseur;
            this.TotalHT = obj.TotalHT;
            this.TotalTVA = obj.TotalTVA;
            this.TotalTTC = obj.TotalTTC;
            this.DateFacture = obj.DateFacture;
            this.DateCreation = obj.DateCreation;
            this.EstPaye = obj.EstPaye;
            this.PiecesRecues = obj.PiecesRecues;
        }

        public static List<FactureFournisseur> Items()
        {
            string recherche = urlMain + "?q=" + "" + "&nb=30";
            return Recherche(recherche);
        }

        public static List<FactureFournisseur> Items(string Query)
        {
            string recherche = urlMain + "?q=" + Query + "&nb=30";
            return Recherche(recherche);
        }

        private static List<FactureFournisseur> Recherche(string requete)
        {
            string json = Fonctions.RequeteWeb(requete);
            List<FactureFournisseur> liste = JsonConvert.DeserializeObject<List<FactureFournisseur>>(json);
            return liste;
        }
    }
}
