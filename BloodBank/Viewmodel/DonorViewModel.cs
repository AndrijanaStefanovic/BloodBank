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
        private List<Donor> donors = new List<Donor>();
        private DatabaseHandler databaseHandler = new DatabaseHandler();

        public BloodType BloodType { get; set; }

        public IList<BloodType> BloodTypes
        {
            get
            {
                return Enum.GetValues(typeof(BloodType)).Cast<BloodType>().ToList();
            }
        }

        public void CreateDonor(string firstName, string lastName, string email, string password, BloodType bloodType)
        {
            Donor d = new Donor(firstName, lastName, email, password, bloodType);
            donors.Add(d);
            databaseHandler.TryCreateDonor(d);
        }
    }
}
