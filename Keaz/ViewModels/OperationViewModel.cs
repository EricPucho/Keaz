using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Keaz.Models;

namespace Keaz.ViewModels
{
    public class OperationViewModel : BaseViewModel
    {
        public ObservableCollection<MenuOperations> MenuOperations { get; private set; }
        IList<MenuOperations> MenuOperations_source;

        public OperationViewModel()
        {
            MenuOperations_source = new List<MenuOperations>();
            ListMenuOperations();
        }

        void ListMenuOperations()
        {
            MenuOperations_source.Add(new MenuOperations()
            {
                icon = "operations",
                text = "Transfert de compte à compte"
            });

            MenuOperations_source.Add(new MenuOperations()
            {
                icon = "virement",
                text = "Faire un virement"
            });

            MenuOperations_source.Add(new MenuOperations()
            {
                icon = "add_user",
                text = "Ajouter un bénéficiaire"
            });

            MenuOperations_source.Add(new MenuOperations()
            {
                icon = "factures",
                text = "Paiement de factures"
            });
            MenuOperations_source.Add(new MenuOperations()
            {
                icon = "keaz_up",
                text = "Acheter un jeton KEAZ Cash"
            });

            MenuOperations_source.Add(new MenuOperations()
            {
                icon = "keaz_down",
                text = "Rembourser un jeton KEAZ Cash"
            });

            MenuOperations = new ObservableCollection<MenuOperations>(MenuOperations_source);

        }
    }
}