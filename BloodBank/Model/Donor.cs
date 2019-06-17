using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Model
{
    public class Donor
    {
        public long Id { get; private set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BloodType BloodType { get; set; }
        public DateTime? LastDonation { get; set; }

        public Donor(long id, string firstName, string lastName, string emailAddress, BloodType bloodType)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = emailAddress;
            BloodType = bloodType;
            LastDonation = null;
        }
    }
}
