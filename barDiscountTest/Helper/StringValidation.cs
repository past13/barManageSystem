using System;
using System.Linq;

namespace Helper
{
    public class StringValidation 
    {
        public static string ValidateStringInput(string couponeCode) 
        {
            couponeCode = couponeCode.ToUpper();
            return string.Concat(couponeCode.Where(c => !Char.IsWhiteSpace(c)));
        }
    }
}


