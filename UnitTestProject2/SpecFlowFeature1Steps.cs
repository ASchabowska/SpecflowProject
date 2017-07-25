using CoupleFramework;
using CoupleFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject2
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        public SpecFlowFeature1Steps()
        {
            Driver.Initialize();
        }

        [Given(@"I am at code couple")]
        public void GivenIAmAtCodeCouple()
        { 
            HomePage.GoTo();
        }
        
        [Given(@"I go to Krzysztof page")]
        public void GivenIGoToKrzysztofPage()
        {
            HomePage.SelectAuthor("Krzysztof").Click();
        }
        
        [When(@"I search java")]
        public void WhenISearchJava()
        {
            AuthorsPage.Search("Java");
        }
        
        [Then(@"the result be on screen")]
        public void ThenTheResultBeOnScreen()
        {
            Assert.AreEqual(SearchPage.Title(), "Wyniki wyszukiwania dla: java");
        }
    }
}
