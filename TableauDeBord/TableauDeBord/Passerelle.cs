using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace TableauDeBord
{
    class Passerelle
    {
        static string chaineConnexion = "Data Source=win-921c8fktgae;Initial Catalog=tableaudebord;User ID=vanbaelinghem;Password=vanbaelinghem";
        static SqlConnection taConnexion;

        public static SqlConnection Connection()  
            // Connexion bdd
        {
            SqlConnection taConnexion;
            taConnexion = new SqlConnection(chaineConnexion);
            return taConnexion;
        }
        
        public static Boolean utilisateur(string login, string mdp)
        {
            SqlConnection taConnexion = Connection();
            taConnexion.Open();

            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT * FROM Connexion2 WHERE Login = '" + login + "'"; // recupere les informations de l'identifiant
            maCommande = new SqlCommand(requeteIdentifiant, taConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            Boolean i = false;
            while (Resultat.Read()) //Parcours le resultat
            {
                string mdpasse = (string)Resultat["MotDePasse"];
                if (mdp == mdpasse)    //Test l'égalité
                {
                    i = true;
                }
            }
            return i;
        }

        public static double pourcentage()
        {
            SqlConnection taConnexion = Connection();
            taConnexion.Open();

            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT nbeLitsOccupes, NbeLitsTotal FROM Occupation"; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, taConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            double calcul = 0;
            while (Resultat.Read()) //Parcours le resultat
            {
                string Mois = (string)Resultat["Mois"];
                int nbLitsOccup = (int)Resultat["nbeLitsOccupes"];
                int nbLitsTotal = (int)Resultat["NbeLitsTotal"];
                calcul = 100 * (nbLitsOccup) / (nbLitsTotal);
                //string mois = Mois;
            }
            
            return calcul;            
        }

        public static double poucentageMois(string pMois)
        {
            SqlConnection taConnexion = Connection();
            taConnexion.Open();

            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT Mois, nbeLitsOccupes, nbLitsTotal FROM Occupation GROUP BY annee"; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, taConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            double calcul = 0;
            while (Resultat.Read()) //Parcours le resultat
            {
                string mois = (string)Resultat["Mois"];
                int nbLitsOccup = (int)Resultat["nbeLitsOccupes"];
                int nbLitsTotal = (int)Resultat["NbeLitsTotal"];
            }
            return calcul;
        }
        
    }
}
