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

        public delegate void DelegateNomValide(Validation sender);
        public event DelegateNomValide LenomEstOk;


        public static bool IsValidName(string _textBoxName)
        {


            return (Regex.Match(_textBoxName, "^[a-zA-Z]*$").Success) && (_textBoxName.Length <= 30) && (_textBoxName != "");
            
        }

        public static bool IsValidMontant(string _textBoxMontant)
        {
            return (Regex.Match(_textBoxMontant, "^[0-9]+([.,]{1}[0-9]{2})?$").Success);

        }

        public static bool IsValidDate(string _textBoxDate)
        {
            
                DateTime resultDate;
                DateTime.TryParse(_textBoxDate, out resultDate);
                DateTime dateDuJour = DateTime.Now;
                return resultDate > dateDuJour;
            
        }

        public static bool IsValidCodePostal(string _textBoxCP)
        {
            return (_textBoxCP.Length < 6) && (_textBoxCP != "") && (Regex.Match(_textBoxCP, "^[0-9]*$").Success);
            
        }

        public bool AllisOK(string _textBoxName, string _textBoxMontant, string _textBoxDate, string _textBoxCP)
        {



            bool isOk = false;

            if (IsValidName(_textBoxName) && IsValidMontant(_textBoxMontant) && IsValidDate(_textBoxDate) && IsValidCodePostal(_textBoxCP))
            {
                isOk = true;
                LenomEstOk(this);

            }
            return isOk;
        }

    }
}
