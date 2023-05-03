using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordGenerator.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PasswordGenerator
{
    public partial class PasswGen : Form
    {
        /// <summary>
        /// В самом начале класса нашей формы зададим 4 строковых массива,
        /// которые будут содержать те символы, из которых будет генерироваться пароль, 
        /// а также определим 4 целочисленные константы, которые будут соответствовать этим массивам 
        /// и использоваться для определения, из какого именно массива мы будем брать очередной 
        /// генерируемый символ пароля:
        /// </summary>

        public string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public string[] lowercaseLetters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public string[] uppercaseLetters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public string[] specialSymbols = new string[] { "#", "!", "$", ";", "_", "&", "^", "%", "&", "*", "(", ")", "{", "}", "[", "]" };
        public string[] englishMats = new string[] { "shit", "crap", "fuck", "fuckaround", "fuckoff", "fuckup" };

        public const int USE_DIGITS = 1;
        public const int USE_LOWERCASE_LETTERS = 2;
        public const int USE_UPPERCASE_LETTERS = 3;
        public const int USE_SPECIAL_SYMBOLS = 4;
        public const int USE_ENGLISH_MATS = 5;



        private void EnableDisableGeneratePasswordButton()
        {
            ButtonGeneratePassword.Enabled = CheckBoxUseDigits.Checked || CheckBoxUseLowercaseLetters.Checked || CheckBoxUseUppercaseLetters.Checked || CheckBoxUseSpecialSymbols.Checked || CheckBoxEnglisMats.Checked;

        }
        public PasswGen()
        {
            InitializeComponent();
            this.TextBoxGeneratedPassword.Height = 50;
        }

        private void CheckBoxUseSpecialSymbols_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private void CheckBoxUseDigits_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private void CheckBoxUseLowercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private void CheckBoxUseUppercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }
        private void enlishMats_CheckedChanged(object sender, EventArgs e)
        {

            EnableDisableGeneratePasswordButton();
        }
        private string GetGeneratedPassword(int passwordLength)
        {
            StringBuilder sbPassword = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < passwordLength; i++)
            {
                int randomArrayNumber;
                do
                {
                    randomArrayNumber = random.Next(1, 5);
                } while (IsNeedToSkip(randomArrayNumber));

                switch (randomArrayNumber)
                {
                    case USE_DIGITS:
                        int randomDigitIndex = random.Next(0, digits.Length);
                        sbPassword.Append(digits[randomDigitIndex]);
                        break;
                    case USE_LOWERCASE_LETTERS:
                        int randomLowercaseLetterIndex = random.Next(0, lowercaseLetters.Length);
                        sbPassword.Append(lowercaseLetters[randomLowercaseLetterIndex]);
                        break;
                    case USE_UPPERCASE_LETTERS:
                        int randomUppercaseLetterIndex = random.Next(0, uppercaseLetters.Length);
                        sbPassword.Append(uppercaseLetters[randomUppercaseLetterIndex]);
                        break;
                    case USE_SPECIAL_SYMBOLS:
                        int randomSpecialSymbolIndex = random.Next(0, specialSymbols.Length);
                        sbPassword.Append(specialSymbols[randomSpecialSymbolIndex]);
                        break;
                    case USE_ENGLISH_MATS:
                        int randomEnglishLetterIndex = random.Next(0, englishMats.Length);
                        sbPassword.Append(englishMats[randomEnglishLetterIndex]);
                        break;
                }
            }
            return sbPassword.ToString();
        }
        private bool IsNeedToSkip(int arrayNumber)
        {
            if (arrayNumber == USE_DIGITS && !CheckBoxUseDigits.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_LOWERCASE_LETTERS && !CheckBoxUseLowercaseLetters.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_UPPERCASE_LETTERS && !CheckBoxUseUppercaseLetters.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_SPECIAL_SYMBOLS && !CheckBoxUseSpecialSymbols.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_ENGLISH_MATS && !CheckBoxEnglisMats.Checked)
            {
                return true;
            }
            return false;
        }

        private void ButtonClearPassword_Click(object sender, EventArgs e)
        {
            TextBoxGeneratedPassword.Text = "";
        }

        private void ButtonGeneratePassword_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            TextBoxGeneratedPassword.Text = englishMats[random.Next(0, englishMats.Length)];
            int passwordLength = TrackBarPasswordLength.Value;
            TextBoxGeneratedPassword.Text = GetGeneratedPassword(passwordLength);
            Clipboard.SetText(TextBoxGeneratedPassword.Text);
        }
        private void LoadSettings()
        {
            CheckBoxUseDigits.Checked = Settings.Default.IsUseDigits;
            CheckBoxUseSpecialSymbols.Checked = Settings.Default.IsUseSpecialSymbols;
            CheckBoxUseUppercaseLetters.Checked = Settings.Default.IsUseUppercaseLetters;
            CheckBoxUseLowercaseLetters.Checked = Settings.Default.IsUseLowercaseLetters;
            CheckBoxEnglisMats.Checked = Settings.Default.IsUseEnglishMats;
            TrackBarPasswordLength.Value = Settings.Default.PasswordLength;

            UpdatePasswordLengthValue();
        }
        private void UpdatePasswordLengthValue()
        {
            LabelPasswordLengthValue.Text = TrackBarPasswordLength.Value.ToString();
        }
        private void SaveSettings()
        {
            Settings.Default.IsUseDigits = CheckBoxUseDigits.Checked;
            Settings.Default.IsUseSpecialSymbols = CheckBoxUseSpecialSymbols.Checked;
            Settings.Default.IsUseUppercaseLetters = CheckBoxUseUppercaseLetters.Checked;
            Settings.Default.IsUseLowercaseLetters = CheckBoxUseLowercaseLetters.Checked;
            Settings.Default.IsUseEnglishMats = CheckBoxEnglisMats.Checked;
            Settings.Default.PasswordLength = TrackBarPasswordLength.Value;
            Settings.Default.Save();
        }

        private void PasswGen_Load(object sender, EventArgs e)
        {
            LoadSettings();
            EnableDisableGeneratePasswordButton();

        }
        private void SaveSettingsAndExitApp()
        {
            SaveSettings();
            Application.Exit();
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            SaveSettingsAndExitApp();
        }

        private void PasswGen_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettingsAndExitApp();
        }

        private void TextBoxGeneratedPassword_TextChanged(object sender, EventArgs e)
        {
            ButtonClearPassword.Enabled = TextBoxGeneratedPassword.TextLength > 0;
        }

        private void TrackBarPasswordLength_Scroll(object sender, EventArgs e)
        {
            LabelPasswordLengthValue.Text = TrackBarPasswordLength.Value.ToString();
        }

        private void LabelPasswordLengthValue_Click(object sender, EventArgs e)
        {

        }

        private void saveTextToFile(string filename, string textToSave)
        {
            try
            {
                File.WriteAllText(filename, textToSave);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибко тут: " + ex.Message);
            }
        }
        private void savepasswword_button_Click(object sender, EventArgs e)
        {

            StreamWriter incdate = new StreamWriter(@".\..\..\Passwords.txt", true);
            incdate.WriteLine(TextBoxGeneratedPassword.Text, '\n');
            incdate.Close();
        }
    }

    }
