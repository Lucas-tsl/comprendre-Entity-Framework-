using Microsoft.EntityFrameworkCore;
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
        private static BdPartitionsContext monModel;
        public static void init()
        {
            monModel = new BdPartitionsContext();

        }

    public static List<Client> listeClients()
            {
                return monModel.Clients.ToList();
            }


        public static List<Commande> listeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }
        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }


        public static List<Auteur> listeAuteurs()
        {
            return monModel.Auteurs.ToList();
        }
    }
}


