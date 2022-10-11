using mission2.DAL;
using mission2.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mission2.Controleur
{
    internal class Controleurs
    {
        SecteurDAO s1 = new SecteurDAO();

        public List<Secteur> Chargement(){
            return s1.GetSecteur();

        }

        
    }
}
