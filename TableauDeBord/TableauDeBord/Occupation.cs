using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TableauDeBord
{
    class Occupation
    {
        public string mois;
        public int anne;
        public int nbLitOccup;
        public int nbLitsTotal;
        public double pourcentageTotal;

        public Occupation(string pMois, int pAnnee, int pNbLitOccup, int pNblitsTotal, int pPourcentageTotal)
        {
            mois = pMois;
            anne = pAnnee;
            nbLitOccup = pNbLitOccup;
            nbLitsTotal = pNblitsTotal;
            pourcentageTotal = pPourcentageTotal;
        }    
        
        public double getPourcentageTotal()
        {
            double retour = 0;
            retour = 100 * (nbLitOccup) / (nbLitsTotal);
            return retour;
        }
    }
}
