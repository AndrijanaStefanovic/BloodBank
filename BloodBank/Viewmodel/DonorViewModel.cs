using BloodBank.Model;
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

        public void CreateDonor(string firstName, string lastName, string email, string password, BloodType bloodType)
        {
            donors.Add(new Donor(firstName, lastName, email, password, bloodType));
        }
    }
}
