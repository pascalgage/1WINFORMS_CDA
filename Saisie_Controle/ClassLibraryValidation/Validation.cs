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
        public static bool IsValidName(string _textBoxName)
        {
            
            if ((Regex.Match(_textBoxName, "^[a-zA-Z]*$").Success) && (_textBoxName.Length <= 30) && (_textBoxName != ""))
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
