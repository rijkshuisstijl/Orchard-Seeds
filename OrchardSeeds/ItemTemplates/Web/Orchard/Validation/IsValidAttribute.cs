#region

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

#endregion

namespace $rootnamespace$
{
    [AttributeUsage(AttributeTargets.Property)]
    public class $safeitemname$Attribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            return true;
        }
    }
}