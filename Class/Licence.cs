using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.Librairie
{
    public class Licence
    {
        private static string urlMain = Settings.urlClients;

        public int? Id { get; set; }
        public int IdProduit { get; set; }
        public int? IdClient { get; set; }
        public string NumeroSerie { get; set; }
        public string Note { get; set; }
        public DateTime? DateActivation { get; set; }
        public DateTime? DateExpiration { get; set; }
        public int? Duree { get; set; }

        #region Constructeur
        public Licence() { }

        public Licence(string numeroSerie)
        {
            NumeroSerie = numeroSerie;
        }
        #endregion

        private void hydrate(int id)
        {
            try
            {
                string url = urlMain + "?id=" + id.ToString();
                string json = Fonctions.RequeteWeb(url);
                Licence obj = JsonConvert.DeserializeObject<Licence>(json);

                this.Id = obj.Id;
                this.IdProduit = obj.IdProduit;
                this.IdClient = obj.IdClient;
                this.NumeroSerie = obj.NumeroSerie;
                this.Note = obj.Note;
                this.DateActivation = obj.DateActivation;
                this.DateExpiration = obj.DateExpiration;
                this.Duree = obj.Duree;
            }
            catch (Exception e)
            {

            }          
        }

        public void Enregistrer()
        {
            string urlsave = urlMain;
            string json = JsonConvert.SerializeObject(this);
            string resultat = Fonctions.RequeteWeb(urlsave, json);

            Licence obj = JsonConvert.DeserializeObject<Licence>(resultat);
            hydrate((int)obj.Id);
        }

        public static List<Licence> Items()
        {
            string recherche = urlMain + "?q=" + "" + "&nb=30";
            return Recherche(recherche);
        }

        public static List<Licence> Items(string Query)
        {
            string recherche = urlMain + "?q=" + Query + "&nb=30";
            return Recherche(recherche);
        }

        private static List<Licence> Recherche(string requete)
        {
            string json = Fonctions.RequeteWeb(requete);
            List<Licence> liste = JsonConvert.DeserializeObject<List<Licence>>(json);
            return liste;
        }
    }
}
