using mission2.DAL;
using mission2.Modele;
using mission2.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mission2
{

    public partial class Form1 : Form
    {
        List<Secteur> ls = new List<Secteur>() ;
        Controleurs UnControlleur;
        public Form1()
        {
            InitializeComponent();
            UnControlleur = new Controleurs();
        }

        public void afficher()
        {
            secteur.DataSource = null;

            secteur.DataSource = ls;

            secteur.DisplayMember = ".Tostring";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void secteur_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ls = UnControlleur.Chargement();
            afficher();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void liaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void secteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void secteur_MouseEnter(object sender, EventArgs e)
        {
            int id = (secteur.SelectedIndex)+1;
            String name = secteur.GetItemText(secteur.SelectedItem);

            liaison = secteur.

        }
    }
}
