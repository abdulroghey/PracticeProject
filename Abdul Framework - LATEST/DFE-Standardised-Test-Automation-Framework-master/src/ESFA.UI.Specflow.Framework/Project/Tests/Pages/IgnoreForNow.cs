﻿using System;
using ESFA.UI.Specflow.Framework.Project.Framework.Helpers;
using ESFA.UI.Specflow.Framework.Project.Tests.TestSupport;
using OpenQA.Selenium;

namespace ESFA.UI.Specflow.Framework.Project.Tests.Pages
{
    public class IgnoreForNow : BasePage
    {
        private static String PAGE_TITLE = "Welcome to GOV.UK";

        public IgnoreForNow(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By searchField = By.Name("q");
        private By searchButton = By.CssSelector(".search-submit");

        //internal SearchResultsPage EnterSearchTextAndSubmit(String searchText)
        //{
        //    FormCompletionHelper.EnterText(searchField, searchText);
        //    FormCompletionHelper.ClickElement(searchButton);
        //    return new SearchResultsPage(webDriver);
        //}
    }
}