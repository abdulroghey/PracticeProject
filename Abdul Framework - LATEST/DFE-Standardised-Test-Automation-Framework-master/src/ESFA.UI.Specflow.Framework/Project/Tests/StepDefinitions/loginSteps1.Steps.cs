using ESFA.UI.Specflow.Framework.Project.Tests.TestSupport;
using System;
using ESFA.UI.Specflow.Framework.Project.Framework.Helpers;
using ESFA.UI.Specflow.Framework.Project.Tests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System.Threading;

namespace ESFA.UI.Specflow.Framework.Project.Tests.StepDefinitions
{
    [Binding]

    public class loginSteps1 : BaseTest
    {
        [Given(@"I have navigated to the Amazon Homepage")]
        public void GivenIHaveNavigatedToTheAmazonHomepage()
        {
            webDriver.Navigate().GoToUrl(Configurator.GetConfiguratorInstance().GetBaseUrl());
        }


        [When(@"I enter something in to the search field")]
        public void WhenIEnterSomethingInToTheSearchField()
        {
            //note: this identified the searchfield and then using send keys types "Batman" in to it
            webDriver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Batman");
            Thread.Sleep(5000);
        }

        [Then(@"I will see some results")]
        public void ThenIWillSeeSomeResults()
        {
            //This next line identifies the search button using xpath and then clicks it
            webDriver.FindElement(By.XPath("//*[@id='nav-search']/form/div[2]/div")).Click();
            Thread.Sleep(5000);
        }

        [Then(@"the heading will match the text searched for")]
        public void ThenTheHeadingWillMatchTheTextSearchedFor()
        {
            //identify the element we want to assert and store it in a varibale named header
            //Note, when you store a locater you use BY and the name of the variable you want to store it in
            By header = By.XPath("//*[@id='search']/span/h1/div/div[1]/div/div/span[3]");
          
            //if you use Console.Writeline(), anything between the brackets will be printed to the console when the test is run
            Console.WriteLine(header);

            //this line is using a function called verifytext which is in the PageINteractionHelper class. I'm passing it the 
            //xpath and the expected text which I'm expecting tp be displayed on the results page
            PageInteractionHelper.VerifyText(header, "Batman");
            //
        }

    }

}
