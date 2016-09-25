using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TableauDeBord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Passerelle.Connection();    // connexion bdd
            Boolean i = Passerelle.utilisateur(login.Text, mdp.Text);
            if (i == false)
            {
                label3.Visible = true;
            }
            else
            {*/
                Form2 a = new Form2();
                a.Show();   // ouverture du Form: taux d'occupation
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
