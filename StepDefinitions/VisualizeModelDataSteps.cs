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
    public sealed class VisualizeModelDataSteps
    {
        [Then(@"verify Selected Model\.")]
        public void ThenVerifySelectedModel_()
        {
            ExplicitWaiting.waitForTime(15000);
            IWebElement selectormode = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._selectorModeIdentifier));
          //  selectormode.Click();
            string selectedmode = selectormode.Text;
            Console.WriteLine(selectormode);
            string filename = "VHB_GPH-060GF_smallstrain_MDC_MasterCurve";
            if (selectedmode != filename)
            {
                Assert.Fail("Selector Mode file Name mismatch");
            }
        }
        [Then(@"select chart type from dropdown\.")]
        public void ThenSelectChartTypeFromDropdown_(Table table)
        {

            ExplicitWaiting.waitForTime(15000);
            GetValues _type = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectChartType(_type.ChartType);
        }
        [Then(@"click on save chart as png\.")]
        public void ThenClickOnSaveChartAsPng_()
        {
            ExplicitWaiting.waitForTime(15000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._saveChartBtn)).Click();
        }
        [Then(@"verify file saved\.")]


        public void ThenVerifyFileSaved_()
        {
            ExplicitWaiting.waitForTime(5000);
            string currentFile = "C:\\Users\\KRITI\\Downloads\\VHB_GPH-060GF_smallstrain_MDC_MasterCurve–Rheology Master Curve.png"; // the zip filename is stored in a variable
            if (File.Exists(currentFile))
            {
                //Console.WriteLine("hi");
                File.Delete(currentFile);
            }
            else
            {
                Assert.Fail("chart download failed.");
                

            }

        }




    }
}
