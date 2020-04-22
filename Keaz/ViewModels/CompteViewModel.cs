using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Keaz.Models;

namespace Keaz.ViewModels
{
    public class CompteViewModel : BaseViewModel
    {
        //private Command SaveCustomer { get; set; }
        public ObservableCollection<Compte> Comptes { get; private set; }
        public ObservableCollection<Operations> Operations { get; private set; }
        readonly IList<Compte> comptes_source;
        readonly IList<Operations> operations_source;


        public CompteViewModel()
        {
            comptes_source = new List<Compte>();
            operations_source = new List<Operations>();

            ListComptes();
            ListOperations();
        }

        void ListComptes()
        {
            comptes_source.Add(new Compte()
            {
                montant = "50 766 XOF",
                numero_compte = "*****2309",
                type_compte = "Compte courant résidant",
                type_operation = "Solde"
            });
            comptes_source.Add(new Compte()
            {
                montant = "100 243,56 XOF",
                numero_compte = "*****0187",
                type_compte = "Epargne ordinaire",
                type_operation = "Solde"
            });
            comptes_source.Add(new Compte()
            {
                montant = "58 000 XOF",
                numero_compte = "*****0189",
                type_compte = "Eparge garantie",
                type_operation = "Solde"
            });

            Comptes = new ObservableCollection<Compte>(comptes_source);
        }

        void ListOperations()
        {
            operations_source.Add(new Operations()
            {
                heure = "18:17",
                montant = "-16 000 XOF",
                type_operation = "Retrait d'espèces GAB",
                magic = "R"
            });

            operations_source.Add(new Operations()
            {
                heure = "09:54",
                montant = "-23 356,97 XOF",
                type_operation = "VISA Paiement NOOO",
                magic = "V"
            });

            Operations = new ObservableCollection<Operations>(operations_source);
        }
    }

}
