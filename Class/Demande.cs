using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.Librairie
{
    public class Demande
    {
        private static string urlMain = Settings.urlDemandes;

        public int Id { get; set; }
        public int IdClient { get; set; }
        public int TypeDemande { get; set; }
        public string Description { get; set; }
        public int IdTech { get; set; }
        public int Statut { get; set; }
        public DateTime DateCreation { get; set; }

        public Demande() { }

        public Demande(int id)
        {
            hydrate(id);
        }

        public void Enregistrer()
        {
            string urlsave = urlMain;
            string json = JsonConvert.SerializeObject(this);
            string resultat = Fonctions.RequeteWeb(urlsave, json);

            Demande obj = JsonConvert.DeserializeObject<Demande>(resultat);
            hydrate((int)obj.Id);
        }

        private void hydrate(int id)
        {
            try
            {
                string url = urlMain + "?id=" + id.ToString();
                string json = Fonctions.RequeteWeb(url);
                Demande obj = JsonConvert.DeserializeObject<Demande>(json);

                this.Id = obj.Id;
                this.IdClient = obj.IdClient;
                this.TypeDemande = obj.TypeDemande;
                this.Description = obj.Description;
                this.IdTech = obj.IdTech;
                this.DateCreation = obj.DateCreation;
            }
            catch (Exception e)
            {
                //MessageBox.Show("Ce dossier n'existe pas !" + e.Message);
            }
        }

        public static List<Demande> Items()
        {
            string recherche = urlMain + "?q=" + "" + "&nb=30";
            return Recherche(recherche);
        }

        public static List<Demande> Items(string Query)
        {
            string recherche = urlMain + "?q=" + Query + "&nb=30";
            return Recherche(recherche);
        }

        private static List<Demande> Recherche(string requete)
        {
            string json = Fonctions.RequeteWeb(requete);
            List<Demande> liste = JsonConvert.DeserializeObject<List<Demande>>(json);
            return liste;
        }
    }

    public class Demande_Type
    {
        public static List<Demande_Type> Items()
        {
            try
            {
                List<Demande_Type> result = new List<Demande_Type>();

                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
