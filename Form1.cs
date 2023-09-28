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
            bsClients.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            dgvClients.DataSource = bsClients;

            //  Commandes
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
                
            });
            dgvCommandes.DataSource = bsCommandes;

            // Récupération de la liste des clients/commandes
            cbClients.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cbClients.DisplayMember = "nomComplet";
            /*bsClients2.DataSource = Modele.listeClients();
            cbClients.DataSource = bsClients2;*/
            bsClients2.DataSource = (Modele.listeClients()).Select(x => new {
                x.Numcli,nomComplet = x.Nomcli + " " + x.Prenomcli, x.Emailcli
            });
            cbClients.DataSource = bsClients2;




            //  Auteurs
            bsAuteurs.DataSource = Modele.listeAuteurs(); // appel de la méthode listeCommande
            dgvAuteurs.DataSource = bsAuteurs;

            /*N’hésitez pas à améliorer voytre dataGridView en masquant des colonnes ou en changeant les entêtes:
            dgvClients.Columns[indice].Visible =
            dgvClients.Columns[indice].HeaderText =*/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvAuteurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bsClients2_CurrentChanged(object sender, EventArgs e)
        {
            // récupération de l’identifiant du client issu de la comboBox : on a NUMCLI en ValueMember de la
            // combo, donc on peut récupérer la valeur par la propriété SelectedValue
            int IDC = Convert.ToInt32(cbClients.SelectedValue);
            int IdClient = Convert.ToInt32(cbClients.SelectedValue);
            bsCommandes.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            })
            .OrderBy(x => x.Datecde);
            dgvCommandes.DataSource = bsCommandes;
        }
    }
}