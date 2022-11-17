using System.Text;
using System.Windows.Forms;

namespace MyStringLibrary
{
    internal class CheckingString
    {
        string SetRightCaps_RU;
        string SetRight_RU;
        string SetRightCaps_ENG;
        string SetRight_ENG;
        string SetDate;
        string SetSpecial_Characters;

        CheckingString()
        {
            SetRightCaps_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";
            SetRightCaps_ENG = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            SetRight_RU = SetRightCaps_RU.ToLower();
            SetRight_ENG = SetRightCaps_ENG.ToLower();
            SetDate = "1234567890.";
            SetSpecial_Characters = @",.'"";:\|/{}[]_-+=~`!@#$%^&*()№<>";
        }

        protected internal bool CheckRightName(string text)
        {
            if (text == null)
                return false;

            foreach (int i in text)
                foreach (int j in SetSpecial_Characters)
                    if (text[i] == SetSpecial_Characters[j])
                        return false;
                    else if (text[i] != SetSpecial_Characters[j])
                        continue;

            return true;
        }

        protected internal string RedactRightName_RU(string text)
        {
            StringBuilder stringBuilder = new StringBuilder(text);
            if (text == null)
                return null;

            if (!CheckRightName(text))
            {
                MessageBox.Show("Строка не прошла проверку: Специальные символы запрещены",
                    "Ошибка ввода данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }

            foreach (int i in text)
                foreach (int j in SetSpecial_Characters)
                    if (text[0] == SetRightCaps_RU[j])
                        continue;
                    else if (text[0] == SetRight_RU[j])
                        stringBuilder[i] = SetRightCaps_RU[j];

            return text;
        }
    }
}
