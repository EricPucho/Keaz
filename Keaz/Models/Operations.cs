using System;
using System.Collections.Generic;

namespace Keaz.Models
{
    public class Operations
    {
        public string heure { get; set; }
        public string magic { get; set; }
        public string montant { get; set; }
        public string type_operation { get; set; }
        public string date { get; set; }
    }

    public class OperationsGroup : List<Operations>
    {
        public string date { get; private set; }

        public OperationsGroup(string date_, List<Operations> ope) : base(ope)
        {
            date = date_;
        }
    }
}
