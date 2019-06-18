using BloodBank.Model;
using BloodBank.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Viewmodel
{
    public class BloodSupplyViewModel
    {
        public BloodSupply BloodSupply { get; set; }

        public BloodSupplyViewModel()
        {
            BloodSupply = new BloodSupply(new DatabaseHandler());
        }
    }
}
