using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.Librairie
{
    public class  Utilisateur
    {
        private static string urlMain = Settings.urlEmployees;

        public int? Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateLastLogin { get; set; }
        public DateTime DatePreviousLogin { get; set; }

        #region Constructeur
        public Utilisateur() { }

        public Utilisateur(int Id)
        {
            hydrate(Id);
        }
        #endregion

        #region Fonctions privées

        private void hydrate(int id)
        {
            try
            {
                string url = urlMain + "?id=" + id.ToString();
                string json = Fonctions.RequeteWeb(url);
                Utilisateur obj = JsonConvert.DeserializeObject<Utilisateur>(json);

                this.Id = obj.Id;
                this.Login = obj.Login;
                this.Password = obj.Password;
                this.ApiKey = this.ApiKey;
                this.Nom = obj.Nom;
                this.Prenom = obj.Prenom;
                this.Adresse = obj.Adresse;
                this.CodePostal = obj.CodePostal;
                foreach (var prop in obj.GetType().GetProperties())
                {
                    //this.GetType().GetProperty(prop.Name).SetValue(obj); 
                    //MessageBox.Show(prop.Name);
                }
            }
            catch (Exception e)
            {

            }
        }

        private static List<Utilisateur> Recherche(string requete)
        {
            string json = Fonctions.RequeteWeb(requete);
            List<Utilisateur> liste = JsonConvert.DeserializeObject<List<Utilisateur>>(json);
            return liste;
        }

        #endregion

        #region Fonctions publiques
        public void Enregistrer()
        {
            string urlsave = urlMain;
            string json = JsonConvert.SerializeObject(this);
            string resultat = Fonctions.RequeteWeb(urlsave, json);

            Utilisateur obj = JsonConvert.DeserializeObject<Utilisateur>(resultat);
            hydrate((int)obj.Id);
        }

        public static List<Utilisateur> Items()
        {
            string recherche = urlMain + "?q=" + "" + "&nb=30";
            return Recherche(recherche);
        }

        public static List<Utilisateur> Items(string Query)
        {
            string recherche = urlMain + "?q=" + Query + "&nb=30";
            return Recherche(recherche);
        }
        
        #endregion


    }

    public static class Utilisateurs
    {
        private static int limit = 30;

        public static List<Utilisateur> Items()
        {
            try
            {
                List<Utilisateur> result = new List<Utilisateur>();

                return result;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }

}
