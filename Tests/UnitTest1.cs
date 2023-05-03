using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator;
using System;
using System.Windows.Forms;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        
        public void TestMethod1()
        {
            //arange

            PasswGen passwGen = new PasswGen();
            //act
            passwGen.ButtonGeneratePassword.Enabled = passwGen.CheckBoxUseDigits.Checked || passwGen.CheckBoxUseLowercaseLetters.Checked || passwGen.CheckBoxUseUppercaseLetters.Checked || passwGen.CheckBoxUseSpecialSymbols.Checked || passwGen.CheckBoxEnglisMats.Checked;
           
            //assert
        }
        [TestMethod]
        public void TestMethod2()
        {
            PasswGen passwGen = new PasswGen();

 
           
            Button button = passwGen.Controls["ButtonGeneratePassword"] as Button;  
            button.PerformClick();

            Assert.IsNotNull(button);
        }
        [TestMethod]
        public void TestMethod3()
        {
            PasswGen passwGen = new PasswGen();
            TextBox textBox = passwGen.Controls["TextBoxGeneratedPassword"] as TextBox;
            textBox.Text = "";

            bool containsAtSymbol = textBox.Text.Contains("");

            Assert.IsTrue(containsAtSymbol);
        }
    }
    
}
