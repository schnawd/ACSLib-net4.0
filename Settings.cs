using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace ACS.Librairie
{
    public class Settings
    {
        #region Classes partagées
        public static Client ClientPartage = null;
        public static Licence LicencePartage = null;
        public static Produit ProduitPartage = null;
        public static Utilisateur employee = new Utilisateur(1);

        public static List<Utilisateur> listeEmployee;
        public static List<Demande_Type> listeDemandeType;
        public static List<CategorieProduit> listeCategoriesProduits;
        public static List<ZipTown> listeZipTown;

        public static void InitMoteur()
        {
            listeEmployee = Utilisateurs.Items();
            listeDemandeType = Demande_Type.Items();
            listeCategoriesProduits = CategorieProduit.Items();
            //listeZipTown = Class_Function.ListeZipTown();
        }
        #endregion

        #region Paramètres
        //Ces options permettent  de convertir le string en int
        /*
        public static JsonSerializerOptions options = new JsonSerializerOptions
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString,
            AllowTrailingCommas = true
        };
        */
        public static double CoefficientVente = 1.4;
        public static double TVA20 = 1.2;
        public static string MessageSMS = "Bonjour. Votre matériel est disponible en magasin. Cordialement, ACS Multimédia.";

        public static DateTime BaseDate = new DateTime();
        #endregion

        #region Répertoires
        public static string repertoireNouveauxDocs = @"\\192.168.1.4\Données\_à traiter";
        public static string repertoireAEnvoyer = @"\\192.168.1.4\Données\_à traiter\_à envoyer";
        public static string repertoireFacturesFournisseur = @"\\192.168.1.252\documents\fournisseur\facture";
        public static string ACS_ProgramData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ACS Multimédia");
        #endregion

        #region Fichiers
        public static string fichierInfosClient = Path.Combine(ACS_ProgramData, "infosClient.json");
        public static string fichierInfosAtelier = Path.Combine(Settings.ACS_ProgramData, "ficheAtelier.json");
        #endregion

        #region Liens hypertext
        public static string mainUrl = "http://cloud.acs65.fr/api/acs/";
        public static string mainFTP = "ftp://ftp.acs65.fr/FTP/";

        public static string urlFournisseur = mainUrl + "fournisseurs.php";
        public static string urlClients = mainUrl + "clients.php";
        public static string urlFacturesFournisseur = mainUrl + "factures_fournisseurs.php";
        public static string urlFacturesClients = mainUrl + "factures_clients.php";
        public static string urlProduits = mainUrl + "produits.php";
        public static string urlLicences = mainUrl + "licences.php";
        public static string urlCategories = mainUrl + "categories.php";
        public static string urlFichesAtelier = mainUrl + "fichesatelier.php";
        public static string urlDemandes = mainUrl + "demandes.php";
        public static string urlDemandesTypes = mainUrl + "demandes_types.php";
        public static string urlEmployees = mainUrl + "utilisateurs.php";
        public static string urlZipTown = mainUrl + "ziptowns.php";
        #endregion
    }

    public static class ColorACS
    {
        public static Color Bleu1 = Color.FromArgb(0, 191, 255);
        public static Color Bleu2 = Color.FromArgb(135, 206, 235);
        public static Color Vert1 = Color.FromArgb(77, 243, 131);
        public static Color Vert2 = Color.FromArgb(233, 243, 255);
    }
}
