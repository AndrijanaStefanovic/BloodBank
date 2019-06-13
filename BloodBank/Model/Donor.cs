using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Model
{
    public class Donor
    {
        public long Id { get; }
        public string EmailAddress { get; set; }
        public string Password { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BloodType BloodType { get; set; }

        public Donor(string firstName, string lastName, string emailAddress, string password, BloodType bloodType)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
            BloodType = bloodType;
        }
    }
}
