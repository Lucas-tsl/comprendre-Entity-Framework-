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
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
                
            });
            dgvCommandes.DataSource = bsCommandes;

            // R�cup�ration de la liste des clients/commandes
            cbClients.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cbClients.DisplayMember = "nomComplet";
            /*bsClients2.DataSource = Modele.listeClients();
            cbClients.DataSource = bsClients2;*/
            bsClients2.DataSource = (Modele.listeClients()).Select(x => new {
                x.Numcli,nomComplet = x.Nomcli + " " + x.Prenomcli, x.Emailcli
            });
            cbClients.DataSource = bsClients2;




            //  Auteurs
            bsAuteurs.DataSource = Modele.listeAuteurs(); // appel de la m�thode listeCommande
            dgvAuteurs.DataSource = bsAuteurs;

            /*N�h�sitez pas � am�liorer voytre dataGridView en masquant des colonnes ou en changeant les ent�tes:
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
            // r�cup�ration de l�identifiant du client issu de la comboBox : on a NUMCLI en ValueMember de la
            // combo, donc on peut r�cup�rer la valeur par la propri�t� SelectedValue
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