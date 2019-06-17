using System;
using System.ComponentModel;
using System.Reflection;

namespace BloodBank.Util
{
    static class EnumHelper
    {
        public static string GetDescription(this Enum e)
        {
            MemberInfo[] memberInfos = e.GetType().GetMember(e.ToString());
            if (memberInfos.Length == 0)
            {
                return "";
            }
            var mi = memberInfos[0];
            var att = (DescriptionAttribute)mi.GetCustomAttribute(typeof(DescriptionAttribute));
            return att.Description;
        }
    }
}
