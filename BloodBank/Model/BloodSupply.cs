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

        public int APos { get { return GetAvailableUnits(BloodType.Apos); } }
    
        public int BPos { get { return GetAvailableUnits(BloodType.Bpos); } }

        public int ABPos { get { return GetAvailableUnits(BloodType.ABpos); } }

        public int OPos { get { return GetAvailableUnits(BloodType.Opos); } }

        public int GetAvailableUnits(BloodType bloodType)
        {
            if (!unitsByBloodType.TryGetValue(bloodType, out int units))
            {
                unitsByBloodType[bloodType] = 0;
            }
            return units;
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
