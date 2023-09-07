using TP_1.Entities;

namespace TP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Clients
            bsClients.DataSource = Modele.listeClients(); // appel de la m�thode listeClients
            dgvClients.DataSource = bsClients;

            //  Commandes
            bsCommandes.DataSource = Modele.listeCommandes(); // appel de la m�thode listeCommande
            dgvCommandes.DataSource = bsCommandes;

            //  Auteurs
            bsAuteurs.DataSource = Modele.listeAuteurs(); // appel de la m�thode listeCommande
            dgvAuteurs.DataSource = bsAuteurs;

            /*N�h�sitez pas � am�liorer voytre dataGridView en masquant des colonnes ou en changeant les ent�tes:
            dgvClients.Columns[indice].Visible =
            dgvClients.Columns[indice].HeaderText =*/

        }


    }
}