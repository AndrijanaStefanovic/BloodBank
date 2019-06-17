using BloodBank.Util;
using System;
using System.Collections.Generic;

namespace BloodBank.Model
{
    public class BloodSupply
    {
        private DatabaseHandler databaseHandler;
        private Dictionary<BloodType, int> unitsByBloodType = new Dictionary<BloodType, int>();

        public BloodSupply(DatabaseHandler databaseHandler)
        {
            this.databaseHandler = databaseHandler;
            foreach (Tuple<BloodType, int> record in databaseHandler.ReadBloodSuply())
            {
                unitsByBloodType[record.Item1] = record.Item2;
            }
        }

        public int GetAvailableUnits(BloodType bloodType)
        {
            return unitsByBloodType[bloodType];
        }

        public void AddUnits(BloodType bloodType, int units)
        {
            unitsByBloodType[bloodType] += units;
        }

        public void AddUnit(BloodType bloodType)
        {
            unitsByBloodType[bloodType]++;
        }


    }
}
