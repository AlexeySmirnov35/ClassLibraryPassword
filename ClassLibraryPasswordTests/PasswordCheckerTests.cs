using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Chek_Pass_8Symbol()
        {
            string pasword = "ASqw12$$";
            bool expect = true;
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod()]
        public void Chek_Pass_4Symbol()
        {
            string pasword = "Aq1$";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Chek_Pass_30Symbol()
        {
            string pasword = "ASDqwe123SASDqwe123SASDqwe123S";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Chek_Pass_NumberTrue()
        {
            string pasword = "ASDqwe1S&";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void Chek_Pass_NumberFalse()
        {
            string pasword = "ASDqweASDS";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Chek_Pass_SumbolSpecTrue()
        {
            string pasword = "Aqwel23_";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void Chek_Pass_SumbolSpecFalse()
        {
            string pasword = "ASDqwe123";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsFalse( actual);
        }
        [TestMethod()]
        public void Chek_Pass_SumbolStrochTrue()
        {
            string pasword = "Aqwa123$";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsTrue( actual);
        }
        [TestMethod()]
        public void Chek_Pass_SumbolStrochFalse()
        {
            string pasword = "asdqwe123$";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsFalse( actual);
        }
        [TestMethod()]
        public void Chek_Pass_SumbolGlacTrue()
        {
            string pasword = "ASDq123$";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void Chek_Pass_SumbolGlavFalse()
        {
            string pasword = "ASDQWE123$";
            bool actual = PasswordChecker.ValidPassword(pasword);
            Assert.IsFalse( actual);
        }
    }
}