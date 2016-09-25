using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TableauDeBord
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet1.Occupation'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.occupationTableAdapter.Fill(this.tableaudebordDataSet1.Occupation);

            //int retour = Passerelle.pourcentage();
            //MessageBox.Show(retour.ToString());    
            
        }   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Occupation occupation = new Occupation("Aout",2016,55,100,55);//Passerelle.pourcentage();
            dataGridView1.Columns[0].Name = "mois";
            dataGridView1.Columns[1].Name = "nbLitsOccup";
            dataGridView1.Columns[2].Name = "pourcentage";
            string[] lign1 = new string[] {occupation.ToString() };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
