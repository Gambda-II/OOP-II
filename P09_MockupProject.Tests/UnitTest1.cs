using Microsoft.VisualStudio.TestPlatform.TestHost;
using P09_MockupProject;
using System.Runtime.CompilerServices;

namespace P09_MockupProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddTwoPositiveNumbers()
        {
            Assert.AreEqual(15.0, Orig.AddTwoNumbers(8.0,7.0));
            Assert.AreEqual(500000.0, Orig.AddTwoNumbers(354845.0, 145155.0));
            Assert.AreEqual(5.0, Orig.AddTwoNumbers(1.99,3.01));

        }

        [TestMethod]
        [DataRow(0,true)]
        [DataRow(1, false)]
        [DataRow(-1, false)]
        [DataRow(10, true)]
        [DataRow(9999999, false)]
        public void TestIsEven(int number, bool boolvalue)
        {
            Assert.AreEqual(boolvalue, Orig.IsEven(number));
        }

        [TestMethod]
        [DataRow(1,"Bert","Herr")]
        public void TestKonstruktorKunde(int id, string name, string vorname)
        {
            Kunde kunde = new P09_MockupProject.Kunde(id, name, vorname);

            Assert.AreEqual(id, kunde.ID);
            Assert.AreEqual(name, kunde.Name);
            Assert.AreEqual(vorname, kunde.Vorname);
            
            Assert.AreEqual(DateOnly.FromDateTime(DateTime.Now), kunde.RegistrierungsDatum);
            
            Assert.AreEqual(DateTime.Now, kunde.LetzterLogin);
        }

        [TestMethod]
        public void TestLogin()
        {
            Kunde kunde = new Kunde(1, "Mustermann", "Max");
            DateTime erstellt = DateTime.Now;
            DateTime erstelltImKunden = kunde.LetzterLogin;
            Assert.AreEqual(erstellt, erstelltImKunden);

            Thread.Sleep(1000);
 
            kunde.Login();
            DateTime loggedin = DateTime.Now;
            DateTime loggedinImKunden = kunde.LetzterLogin;

            Assert.AreEqual(loggedin, loggedinImKunden);

            Assert.AreEqual(loggedin - erstellt, loggedinImKunden - erstelltImKunden);
        }
    }

}