﻿using System.IO;
using System.Windows.Forms;

namespace DeleteLines.Domain
{
    public sealed class DeleteLineValidator
    {
        private static DeleteLineValidator instance = null;

        private DeleteLineValidator()
        {
        }

        public static DeleteLineValidator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeleteLineValidator();
                }
                return instance;
            }
        }

        public static bool ValidateTextBox(TextBox textbox, ErrorProvider errorProvider, string message, bool checkIfNumeric,bool checkValidDIr)
        {
            bool result = true;
            bool isNumber = false;
          
            if (string.IsNullOrEmpty(textbox.Text))
            {
                errorProvider.SetError(textbox, message);
                result = false;
                return result;
            }

            if (checkValidDIr)
            {
                if (!Directory.Exists(textbox.Text))
                {
                    errorProvider.SetError(textbox, message);
                    result = false;
                    return result;
                }
            }

            if (checkIfNumeric)
            {
                isNumber = int.TryParse(textbox.Text, out int n);

                if (!isNumber)
                {
                    errorProvider.SetError(textbox, message);
                    result = false;
                    return result;
                }
            }

            return result;
        }
    }
}