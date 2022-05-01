using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.Librairie
{
    public class FicheAtelier
    {
        private static string urlMain = Settings.urlFichesAtelier;

        public int Id { get; set; }
        public int? IdClient { get; set; }
        public string Symptome { get; set; }
        public string Description { get; set; }
        public string CompteRendu { get; set; }

        public FicheAtelier() { }

        public FicheAtelier(int id)
        {
            hydrate(id);
        }

        public bool Enregistrer()
        {
            if (this.IdClient == null)
            {
                //MessageBox.Show("Veuillez renseigner un client !");
                return false;

            }
            else
            {
                try
                {
                    string urlsave = urlMain;
                    string json = JsonConvert.SerializeObject(this);
                    string resultat = Fonctions.RequeteWeb(urlsave, json);

                    FicheAtelier obj = JsonConvert.DeserializeObject<FicheAtelier>(resultat);
                    hydrate((int)obj.Id);

                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        private void hydrate(int id)
        {
            try
            {
                string url = urlMain + "?id=" + id.ToString();
                //MessageBox.Show(url);
                string json = Fonctions.RequeteWeb(url);
                FicheAtelier obj = JsonConvert.DeserializeObject<FicheAtelier>(json);

                this.Id = obj.Id;
                this.IdClient = obj.IdClient;
                this.Symptome = obj.Symptome;
                this.Description = obj.Description;
                this.CompteRendu = obj.CompteRendu;
                //this.IsFournisseur = obj.IsFournisseur;
            }
            catch (Exception e)
            {
                //MessageBox.Show("Ce dossier n'existe pas !" + e.Message);
            }
        }

        public static List<FicheAtelier> Items()
        {
            string recherche = urlMain + "?q=" + "" + "&nb=30";
            return Recherche(recherche);
        }

        public static List<FicheAtelier> Items(string Query)
        {
            string recherche = urlMain + "?q=" + Query + "&nb=30";
            return Recherche(recherche);
        }

        private static List<FicheAtelier> Recherche(string requete)
        {
            string json = Fonctions.RequeteWeb(requete);
            List<FicheAtelier> liste = JsonConvert.DeserializeObject<List<FicheAtelier>>(json);
            return liste;
        }
    }
}
