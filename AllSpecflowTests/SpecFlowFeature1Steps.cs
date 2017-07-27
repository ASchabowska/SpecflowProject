using CoupleFramework;
using CoupleFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AllSpecflowTests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        public SpecFlowFeature1Steps()
        {
            Driver.Initialize();
        }

        [Given(@"I am on codecouple page")]
        public void GivenIAmOnCodecouplePage()
        {
            HomePage.GoTo();
        }
        
        [When(@"I go to contact page")]
        public void WhenIGoToContacts()
        {
            HomePage.SelectContact();
        }
        
        [When(@"I create uncomplete message")]
        public void WhenICreateUncompleteMessage()
        {
            ContactPage.CreateMessage("name", "topic", "body").Send();
        }
        
        [Then(@"It should be an error")]
        public void ThenItShouldBeAnError()
        {
            Assert.IsTrue(ContactPage.Error());
            Driver.Close();
        }

        [When(@"I search java")]
        public void WhenISearchJava()
        {
            HomePage.Search("java");
        }

        [Then(@"I should be on search page")]
        public void ThenIShouldBeOnSearchPage()
        {
            Assert.AreEqual(SearchPage.Title(), "Wyniki wyszukiwania dla: java");
            Driver.Close();
        }

    }
}
