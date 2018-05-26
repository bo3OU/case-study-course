using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private ClientController CC = new ClientController();
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            CC.ajouterClient(new Client(nom.Text, prenom.Text));
        }

        private void lister_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = ClientController.ListeClients();
        }


    }
}
