using System;
using TechTalk.SpecFlow;

namespace ESFA.UI.Specflow.Framework.Project
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have navigated to the Amazon Homepage")]
        public void GivenIHaveNavigatedToTheAmazonHomepage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter valid login details")]
        public void WhenIEnterValidLoginDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will see my account page")]
        public void ThenIWillSeeMyAccountPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
