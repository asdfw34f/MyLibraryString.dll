using System;
using System.Text;
using System.Windows.Forms;

namespace MyStringLibrary
{
    public class CheckingString
    {
        string SetRightCaps_RU;
        string SetRight_RU;
        string SetRightCaps_ENG;
        string SetRight_ENG;
        string SetSpecial_Characters;
        string SetNumeric;
        public CheckingString()
        {
            SetRightCaps_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";
            SetRightCaps_ENG = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            SetRight_RU = SetRightCaps_RU.ToLower();
            SetRight_ENG = SetRightCaps_ENG.ToLower();
            SetSpecial_Characters = @",.'"";:\|/{}[]_-+=~`!@#$%^&*()№<>";
            SetNumeric = "1234567890";
        }

        internal string EditName(string SetAlshebetCaps, string SetAlshebet, string Name)
        {
            StringBuilder stringBuilder = new StringBuilder(Name);

            for (int i = 0; i < SetAlshebetCaps.ToString().Length - 1; i++)
                if (Name[0] == SetAlshebetCaps[i])
                    break;
                else if (Name[0] == SetAlshebet[i])
                {
                    stringBuilder[0] = SetAlshebetCaps[i];
                    return stringBuilder.ToString();
                }
                else if (i == SetAlshebetCaps.ToString().Length - 2)
                    return null;

            return Name;
        }

        internal bool CheckStringSpec_Simbol(string text)
        {
            for (int i = 0; i < text.ToString().Length; i++)
                for (int j = 0; j < SetSpecial_Characters.ToString().Length; j++)
                    if (text[i] == SetSpecial_Characters[j])
                        return false;
                    else if (text[i] != SetSpecial_Characters[j])
                        continue;

            return true;
        }

        internal bool CheckStringNumbers(string text)
        {
            for (int i = 0; i < text.ToString().Length; i++)
                for (int j = 0; j < SetNumeric.ToString().Length; j++)
                    if (text[i] == SetNumeric[j])
                        return false;
                    else if (text[i] != SetSpecial_Characters[j])
                        continue;

            return true;
        }

        public string RedactRightName_RU(string text)
        {
            StringBuilder stringBuilder = new StringBuilder(text);

            if (text == null)
                return null;

            if (!CheckStringSpec_Simbol(text) || !CheckStringNumbers(text))
            {
                MessageBox.Show("Строка не прошла проверку: Специальные символы запрещены",
                    "Ошибка ввода данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }

            text = EditName(SetRightCaps_RU, SetRight_RU, text);

            return text;
        }

        public string RedactRightName_ENG(string text)
        {
            StringBuilder stringBuilder = new StringBuilder(text);

            if (text == null)
                return null;

            if (!CheckStringSpec_Simbol(text) || !CheckStringNumbers(text))
            {
                MessageBox.Show("The string failed validation: Special characters are prohibited",
                    "Data entry error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }

            text = EditName(SetRightCaps_ENG, SetRight_ENG, text);

            return text;
        }
    }
}
