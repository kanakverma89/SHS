using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Sharkspray_3M_QA.Utility;
using OpenQA.Selenium;
using Sharkspray_3M_QA;
//using Sharkspray_3M_QA.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using System.Windows.Forms;
using AutoItX3Lib;
using TechTalk.SpecFlow.Assist;
//// import org.openqa.selenium.Keys;



using OpenQA.Selenium.Interactions;
using Keys = OpenQA.Selenium.Keys;
using Sharkspray_3M_QA.Utility;

namespace Sharkspray_3M_QA.StepDefinitions
{
    [Binding]
    public sealed class EditYourModelsSteps
    {
        [When(@"Click on Edit Your Models\.")]
        public void WhenClickOnEditYourModels_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._editYourModelsIdentifier)).Click();
        }
        [When(@"click on searchbox button and send search input\.")]
        public void WhenClickOnSearchboxButtonAndSendSearchInput_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._searchboxEditModelButton)).Click();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._searchBoxInputIdentifier)).SendKeys(";
        }
        [When(@"Select on model to delete\.")]
        public void WhenSelectOnModelToDelete_()
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._checkboxEditModel)).Click();
        }
        [Then(@"click on Delete Selected Models Button\.")]
        public void ThenClickOnDeleteSelectedModelsButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deleteSelectedModelBtn)).Click();
        }
        [Then(@"click on button to confirm delete\.")]
        public void ThenClickOnButtonToConfirmDelete_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deleteConfirmBtn)).Click();
        }

        [When(@"Select on model to be edited\.")]
        public void WhenSelectOnModelToBeEdited_()
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelEditCheckboxBtn)).Click();
        }
        [When(@"Update model\.")]
        public void WhenUpdateModel_()
        {
            ExplicitWaiting.waitForTime(5000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._descrptionTextboxIdentifier)).Clear();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._descrptionTextboxIdentifier)).SendKeys("this is a model");
        }
        [Then(@"click on Update selected Model Button\.")]
        public void ThenClickOnUpdateSelectedModelButton_()
        {
            ExplicitWaiting.waitForTime(5000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._updateSelectedModelBtn)).Click();
        }

        [Then(@"verify that model was updated\.")]
        public void ThenVerifyThatModelWasUpdated_()
        {
            ExplicitWaiting.waitForTime(3000);
            IWebElement description = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._descrptionTextboxIdentifier));
            string descriptionText = description.Text;
            Assert.AreEqual(descriptionText, "this is a model");
        }

    }
}
