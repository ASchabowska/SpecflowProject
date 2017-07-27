using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoupleFramework.Pages;
using CoupleFramework;

namespace Tests
{
    [TestClass]
    public class SmokeTests : BaseTest
    {
    
        [TestMethod]
        public void Are_We_At_Agnieszka_Page()
        {
            //klikamy autora
            HomePage.SelectAuthor("Agnieszka").Click();
            //sprawdzamy czy weszlismy na strone autora
            Assert.AreEqual(AuthorsPage.Title(),"Agnieszka");
        }

        [TestMethod]
        public void Are_We_At_Krzysztof_Page()
        {
            //klikamy autora
            HomePage.SelectAuthor("Krzysztof").Click();
            //sprawdzamy czy weszlismy na strone autora
            Assert.AreEqual(AuthorsPage.Title(), "Krzysztof");
        }

       [TestMethod]
        public void Can_We_Do_A_Search()
        {
            //szukamy searchboxa
            //wpisujemy cos 
            HomePage.Search("java");
            //patrzymy czy jestesmy na stronie z wynikami
            Assert.AreEqual(SearchPage.Title(), "Wyniki wyszukiwania dla: java");
        }

       [TestMethod]
        public void Sending_Messages_Without_All_Data()
        {
            //wchodzimy w kontakt
            HomePage.SelectContact();
            //uzupelniamy dane
            ContactPage.CreateMessage("name","topic","body").Send();
            //sprawdzamy
            Assert.IsTrue(ContactPage.Error());
        }

        [TestMethod]
        public void Can_We_Search_Java()
        {
            //klikamy Java
            HomePage.Java();
            //sprawdzamy czy jestesmy na stronie wyszukania
            Assert.AreEqual(SearchPage.Title(),"Java");
        }

      
    }
}
