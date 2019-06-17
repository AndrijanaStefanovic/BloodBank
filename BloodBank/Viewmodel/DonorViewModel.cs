using BloodBank.Model;
using BloodBank.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Viewmodel
{
    class DonorViewModel
    {
        private DatabaseHandler databaseHandler = new DatabaseHandler();

        public IEnumerable<object> BloodTypes
        {
            get
            {
                return Enum.GetValues(typeof(BloodType))
                           .Cast<object>()
                           .Select(e => new { Value = (int)e, DisplayName = ((BloodType)e).GetDescription()});
            }
        }

        public bool CreateDonor(long id, string firstName, string lastName, string email, BloodType bloodType)
        {
            return databaseHandler.TryCreateDonor(new Donor(id, firstName, lastName, email, bloodType));
        }
    }
}
