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
        public static bool IsValidName(string textBoxNom)
        {


            return (Regex.Match(textBoxNom, "^[a-zA-Z]*$").Success) && (textBoxNom.Length <= 25) && (textBoxNom != "");

        }

        public static bool IsValidPrenom(string textBoxPrenom)
        {


            return (Regex.Match(textBoxPrenom, "^[a-zA-Z]*$").Success) && (textBoxPrenom.Length <= 25) && (textBoxPrenom != "");

        }

        public static bool IsValidDate(DateTime dateentree, DateTime datessortie)
        {
            
            
            if (dateentree < datessortie)
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
