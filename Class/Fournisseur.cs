using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.Librairie
{
    public class Fournisseur
    {
        private static string urlMain = Settings.urlFournisseur;
        private int isFournisseur = 1;
        //private int? _id;

        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string CodeFournisseur { get; set; }
        public string Url { get; set; }
        public int IsFournisseur { get => isFournisseur; set => isFournisseur = value; }
        public string NotePrivee { get; set; }

        public Fournisseur() { }

        public Fournisseur(int Id)
        {
            hydrate(Id);
        }

        public void Enregistrer()
        {
            string urlsave = urlMain;
            string json = JsonConvert.SerializeObject(this);
            string resultat = Fonctions.RequeteWeb(urlsave, json);

            Fournisseur obj = JsonConvert.DeserializeObject<Fournisseur>(resultat);
            hydrate((int)obj.Id);
        }

        private bool hydrate(int id)
        {
            try
            {
                string url = urlMain + "?id=" + id.ToString();
                //MessageBox.Show(url);
                string json = Fonctions.RequeteWeb(url);
                Fournisseur obj = JsonConvert.DeserializeObject<Fournisseur>(json);

                this.Id = obj.Id;
                this.Nom = obj.Nom;
                this.Adresse = obj.Adresse;
                this.CodePostal = obj.CodePostal;
                this.Ville = obj.Ville;
                this.Telephone = obj.Telephone;
                this.Email = obj.Email;
                this.CodeFournisseur = obj.CodeFournisseur;
                this.Url = obj.Url;
                this.IsFournisseur = obj.IsFournisseur;
                this.NotePrivee = obj.NotePrivee;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            //this.IsFournisseur = obj.IsFournisseur;
        }

        public static List<Fournisseur> Items()
        {
            string recherche = urlMain + "?q=" + "" + "&nb=30";
            return Recherche(recherche);
        }

        public static List<Fournisseur> Items(string Query)
        {
            string recherche = urlMain + "?q=" + Query + "&nb=30";
            return Recherche(recherche);
        }

        private static List<Fournisseur> Recherche(string requete)
        {
            string json = Fonctions.RequeteWeb(requete);
            List<Fournisseur> liste = JsonConvert.DeserializeObject<List<Fournisseur>>(json);
            return liste;
        }
    }
}
