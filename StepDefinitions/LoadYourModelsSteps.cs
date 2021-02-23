using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Sharkspray_3M_QA.Utility;
using OpenQA.Selenium;
using Sharkspray_3M_QA;
//using Sharkspray_3M_QA.Utility;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using System.Windows.Forms;
using AutoItX3Lib;
using TechTalk.SpecFlow.Assist;
//org.openqa.selenium.io.TemporaryFileSystem
//// import org.openqa.selenium.Keys;



using OpenQA.Selenium.Interactions;
using Keys = OpenQA.Selenium.Keys;
using Sharkspray_3M_QA.Utility;
using System.IO;

namespace Sharkspray_3M_QA.StepDefinitions
{
    [Binding]
    public sealed class LoadYourModelsSteps
    {
        [When(@"Click on Load your Models \.")]
        public void WhenClickOnLoadYourModels_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loadYourModelsIdentifier)).Click();
        }
        [Then(@"search for a model\.")]
        public void ThenSearchForAModel_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelSearchboxButton)).Click();
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelSearchboxIdentifier)).SendKeys("Vijay_Test");
        }
        [Then(@"verify if model is retreived or not\.")]
        public void ThenVerifyIfModelIsRetreivedOrNot_()
        {
            ExplicitWaiting.waitForTime(3000);
          String Modelname =  BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelNameIdentifier)).Text;
            if(Modelname != "Vijay_Test")
            {
                Assert.Fail("search failed");
            }
        }
    
        [Then(@"Select a model to load\.")]
        public void ThenSelectAModelToLoad_()
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelNameCheckboxIdentifier)).Click();
        }

        [Then(@"Verify model selection\.")]
        public void ThenVerifyModelSelection_()
        {
            String Modelnameselect = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelNameTextBox)).Text;
            if (Modelnameselect != "1 Model(s) Selected")
            {
                Assert.Fail("Model Selection Failed");
            }
        }

        [Then(@"click on load constitutive mechanical model button\.")]
        public void ThenClickOnLoadConstitutiveMechanicalModelButton_()
        {
            Thread.Sleep(5000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._loadConstitutiveModelButton)).Click();
        }
        [Then(@"Verify load constitutive mechanical model button clicked\.")]
        public void ThenVerifyLoadConstitutiveMechanicalModelButtonClicked_()
        {
            Thread.Sleep(10000);
            //IWebElement visualizeModelDataElement = BrowserConfig._driver.FindElement(By.CssSelector(ObjectIdentifiers._visualizeModelCss));
            // string color = visualizeModelDataElement.GetCssValue("color");
            // Console.WriteLine(color);
            // Assert.AreEqual(color, "rgba(30, 144, 255, 1)");
            IWebElement chartElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._saveChartBtn));
            HelpingFunctions.elementVisible(chartElement);

        }


    }
}
