using System.ComponentModel;

namespace BloodBank.Model
{
    public enum BloodType
    {
        [Description("A+")]
        Apos,
        [Description("B+")]
        Bpos,
        [Description("AB+")]
        ABpos,
        [Description("0+")]
        Opos,
        [Description("A-")]
        Aneg,
        [Description("B-")]
        Bneg,
        [Description("AB-")]
        ABneg,
        [Description("0-")]
        Oneg
    }
}
