using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_1.Entities; // ajouter dans les using de la classe

namespace TP_1.Entities
{
   

    internal static class Modele
    {
        private static Tp1Context monModel;
        public static void init()
        {
            monModel = new Tp1Context();

        }

    public static List<Client> listeClients()
            {
                return monModel.Clients.ToList();
            }
        

    public static List<Commande> listeCommandes()
            {
                return monModel.Commandes.ToList();
            }

        public static List<Auteur> listeAuteurs()
        {
            return monModel.Auteurs.ToList();
        }
    }
}


