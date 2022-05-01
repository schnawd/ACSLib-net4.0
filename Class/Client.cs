using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.Librairie
{
    public class Client
    {
        private static string urlMain = Settings.urlClients;
        private int isClient = 1;

        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string CodeClient { get; set; }
        public string CodeCompta { get; set; }
        public string Url { get; set; }
        public int IsClient { get => isClient; set => isClient = value; }
        public DateTime? DateCreation { get; set; }

        public Client() { }

        public Client(int? id)
        {
            if (id != null || id != 0) hydrate(id.Value);
        }

        public void Enregistrer()
        {
            string urlsave = urlMain;
            string json = JsonConvert.SerializeObject(this);
            string resultat = Fonctions.RequeteWeb(urlsave, json);

            Client obj = JsonConvert.DeserializeObject<Client>(resultat);
            hydrate((int)obj.Id);
        }

        private void hydrate(int id)
        {
            try
            {
                string url = urlMain + "?id=" + id.ToString();
                string json = Fonctions.RequeteWeb(url);
                Client obj = JsonConvert.DeserializeObject<Client>(json);

                this.Id = obj.Id;
                this.Nom = obj.Nom;
                this.Adresse = obj.Adresse;
                this.CodePostal = obj.CodePostal;
                this.Ville = obj.Ville;
                this.Telephone = obj.Telephone;
                this.Email = obj.Email;
                this.CodeClient = obj.CodeClient;
                this.CodeCompta = obj.CodeCompta;
                this.IsClient = obj.IsClient;
                this.DateCreation = obj.DateCreation;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

        public static List<Client> Items()
        {
            string recherche = urlMain + "?q=" + "" + "&nb=30";
            return Recherche(recherche);
        }

        public static List<Client> Items(string Query)
        {
            string recherche = urlMain + "?q=" + Query + "&nb=30";
            return Recherche(recherche);
        }

        private static List<Client> Recherche(string requete)
        {
            string json = Fonctions.RequeteWeb(requete);
            List<Client> liste = JsonConvert.DeserializeObject<List<Client>>(json);
            return liste;
        }

        public class Account
        {
            public int? Id { get; set; }
            public string Login { get; set; }

        }
    }
}
