using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Keaz.Models;

namespace Keaz.ViewModels
{
    public class DetailsVirementViewModel
    {
        public ObservableCollection<List<OperationsGroup>> Operations { get; private set; }
        public List<OperationsGroup> Operations_ { get; private set; }

        public DetailsVirementViewModel()
        {
            Operations_ = new List<OperationsGroup>();
            ListOperations();
        }

        void ListOperations()
        {
            Operations_.Add(new OperationsGroup("Aujourd'hui", new List<Operations>
            {
            new Operations()
            {
                heure = "18:17",
                montant = "-16 000 XOF",
                type_operation = "Retrait d'espèces GAB",
                magic = "R",
                date = "Aujourd'hui"
            },

            new Operations()
            {
                heure = "09:54",
                montant = "-23 356,97 XOF",
                type_operation = "VISA Paiement N000",
                magic = "V",
                date = "Aujourd'hui"

            },
            }));

            Operations_.Add(new OperationsGroup("12/03/2020", new List<Operations>
            {
            new Operations()
            {
                heure = "12:54",
                montant = "75 000,00 XOF",
                type_operation = "Virement reçu Comm...",
                magic = "V",
                date = ""

            },
            new Operations()
            {
                heure = "10:32",
                montant = "-23 356,97 XOF",
                type_operation = "VISA Paiement N000",
                magic = "V",
                date = "12/03/2020"

            },
            new Operations()
            {
                heure = "09:54",
                montant = "100 000,00 XOF",
                type_operation = "Dépôt d'espèces Agen...",
                magic = "D",
                date = "12/03/2020"

            },
            new Operations()
            {
                heure = "08:22",
                montant = "-23 356,97 XOF",
                type_operation = "VISA Paiement N000",
                magic = "V",
                date = "12/03/2020"

            }
            }));

        }
    }
}
