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

        public static bool IsValidDate(string _textBoxDate)
        {
            
                DateTime resultDate;
                DateTime.TryParse(_textBoxDate, out resultDate);
                DateTime dateDuJour = DateTime.Now;
                return resultDate > dateDuJour;
            
        }




        public static bool IsValidMontant(string _textBoxMontant)
        {
            if(Regex.Match(_textBoxMontant, "^[0-9]+([.,]{1}[0-9]{2})?$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidCodePostal(string _textBoxCP)
        {
            if((_textBoxCP.Length < 6) && (_textBoxCP!= "") && (Regex.Match(_textBoxCP, "^[0-9]*$").Success))
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
