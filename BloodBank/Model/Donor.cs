using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Model
{
    public class Donor
    {
        private long Id { get; }
        private string firstName { get; set; }
        private string lastName;
        private BloodType bloodType;

        public Donor(long id, string firstName, string lastName, BloodType bloodType)
        {
            Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.bloodType = bloodType;
        }


    }
}
