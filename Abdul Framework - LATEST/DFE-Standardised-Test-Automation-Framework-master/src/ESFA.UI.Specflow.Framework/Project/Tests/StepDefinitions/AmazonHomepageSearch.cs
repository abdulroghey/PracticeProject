using System;
using TechTalk.SpecFlow;
using ESFA.UI.Specflow.Framework.Project.Tests.TestSupport;

namespace ESFA.UI.Specflow.Framework.Project.Tests.StepDefinitions
{
    [Binding]
    public class SpecFlowFeature1Steps  : BaseTest
    {
        [Given(@"I have navigated to the Amazon homepage")]
        public void GivenIHaveNavigatedToTheAmazonHomepage()
        {
            webDriver.Navigate().GoToUrl("http://www.amazon.co.uk");
        }
        
        [When(@"I enter something in the search field and press Go")]
        public void WhenIEnterSomethingInTheSearchFieldAndPressGo()
        {
            // webDriver.FindElement(By.Xpath("")).Enter;
        }
        
        [Then(@"I am shown some Results")]
        public void ThenIAmShownSomeResults()
        {
            // ScenarioContext.Current.Pending();
        }
    }
}
