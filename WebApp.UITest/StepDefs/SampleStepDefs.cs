using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebApp.AppFramework;
using WebApp.UITest.Tests;

namespace WebApp.UITest.StepDefs
{

    [Binding]

    public sealed class SampleStepDefs
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        //private IWebDriver browser = WebDriverFactory.GetDriver();
        private HomePage HP;

        [Given(@"I have navigated to the About page")]
        public void GivenIHaveNavigatedToTheAboutPage()
        {
            AboutPage AP = Navigation.GoToAboutPage(WebDriverFactory.GetDriver());
        }

        [Given(@"I have navigated to the Home page")]
        public void GivenIHaveNavigatedToTheHomePage()
        {
            HP = Navigation.GoToHomePage(WebDriverFactory.GetDriver());
        }

        [Given(@"I have navigated back to the home page\. \(Navigating with menu items\)")]
        public void GivenIHaveNavigatedBackToTheHomePage_NavigatingWithMenuItems()
        {
            AboutPage AP2 = EAPage.NavigateThroughMenuItems(WebDriverFactory.GetDriver(), Bys.EAPage.Menu_About);
        }

        [Given(@"I have navigated to the Home page again")]
        public void GivenIHaveNavigatedToTheHomePageAgain()
        {
            Navigation.GoToHomePage(WebDriverFactory.GetDriver());
        }

        [When(@"I enter ""(.*)"" into the email text box")]
        public void WhenIEnterIntoTheEmailTextBox(string p0)
        {
            HP.EmailTxt.SendKeys("blah");
        }

        [Then(@"the text box should contain ""(.*)""")]
        public void ThenTheTextBoxShouldContain(string p0)
        {
            Assert.AreEqual("blah", HP.EmailTxt.GetAttribute("value"));
        }

    }
}
