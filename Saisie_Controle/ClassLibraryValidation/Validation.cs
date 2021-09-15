using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibraryValidation
{
    public class Validation
    {
        public static bool IsValidName(string textBoxName)
        {
            
            if ((Regex.Match(textBoxName, "^[a-zA-Z]*$").Success) && (textBoxName.Length <= 30) && (textBoxName != ""))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
