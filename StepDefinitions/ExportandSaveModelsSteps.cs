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
//import org.openqa.selenium.support.Color;


namespace Sharkspray_3M_QA.StepDefinitions
{
    [Binding]
    public sealed class ExportandSaveModelsSteps
    {
        [Then(@"click on Model Name\.")]
        public void ThenClickOnModelName_()
        {
            ExplicitWaiting.waitForTime(12000);
            //IJavaScriptExecutor jd = (IJavaScriptExecutor)BrowserConfig._driver;
            //jd.ExecuteScript("window.scrollBy(0,250)", "");
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelNameSelectButton)).Click();
        }


        [Then(@"Verify Selection Of Model Name\.")]
        public void ThenVerifySelectionOfModelName_()
        {
            IWebElement saveSelectModelelement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._saveSelectedModelsButton));
            HelpingFunctions.SaveSelectedModelsVisible(saveSelectModelelement);
           
        }

        [Then(@"Click on Save Selected  Models Button\.")]
        public void ThenClickOnSaveSelectedModelsButton_()
        {
             //  IWebElement svgCircle = BrowserConfig._driver.FindElement(By.XPath("//*[name()='svg']//*[name()='jss01574']"));
            //   string tickElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._modelSavedTickIdentifier)).GetCssValue("Color");
            //  Console.WriteLine(tickElement);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._saveSelectedModelsButton)).Click();
        }
        [Then(@"Verify Model saved\.")]
        public void ThenVerifyModelSaved_()
        {
            ExplicitWaiting.waitForTime(5000);
            IWebElement tickElement2= BrowserConfig._driver.FindElement(By.CssSelector(ObjectIdentifiers._tick1));
            String colour =  tickElement2.GetAttribute("style");
            Assert.AreEqual(colour, "fill: green;");

            //String hexacolor = Color.fromString(tickElement).asHex();
           

        }


    }
}
