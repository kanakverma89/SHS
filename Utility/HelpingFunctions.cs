


    using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using Sharkspray_3M_QA.ConfigFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sharkspray_3M_QA
{
    class HelpingFunctions
    {
        public static void SelectAdhesiveType(string _adhesive)
        {
            //var _adhesiveTypeIdentifier = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._adhesiveDropdown));
            //var adhesiveTypeSelectElement = new SelectElement(_adhesiveTypeIdentifier);
            //adhesiveTypeSelectElement.SelectByIndex(1);
            switch (_adhesive)
            {
                case "Pressure Sensitive Transfer Tape(PSA-ATT)":
                    //BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._pstt)).Click();
                    break;
                case "Pressure Sensitive Double-Coated Tape (PSA-DCT)":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._pstt)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._psdct)).Click();
                    break;
                case "VHB":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._pstt)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._vha)).Click();
                    break;
            }
        }
        public static void SelectModelPhase(string _model)
        {
            switch (_model)
            {
                case "Phase 1(DMA)":
                    //BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._pstt)).Click();
                    break;
                case "Phase 2(DMA + Compression)":
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._phase1)).Click();
                    ExplicitWaiting.waitForTime(3000);
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._phase2)).Click();
                    break;
                case "Phase 3(DMA + Compression + Tensile)":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._phase1)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._phase3)).Click();
                    break;
            }
        }
        public static void ScrollToElement()
        {
            Actions actions = new Actions(BrowserConfig._driver);

        }
        public static void elementVisible(IWebElement element)
        {
            bool visibility = element.Displayed;
            if (visibility == false)
            {
                Assert.Fail("Fail.");

            }
        }
     
        public static void SaveSelectedModelsVisible(IWebElement saveSelectModelelement)
        {
            bool visibilityBtn = saveSelectModelelement.Displayed;
            if (visibilityBtn == false)
            {
                Assert.Fail("Model Name Not selected.");

            }
        }

        public static void SelectDeformationMode(string _deformationType)
        {
            switch (_deformationType)
            {
                case "Shear":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;
                case "Tensile":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;
                case "Dual-Cantilever Beam":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;
                case "Single-Cantilever Beam":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;
                case "Three Point Bending":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformationModeDropdownBtn)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._deformModeVal1)).Click();
                    break;

            }
        }
        public static void TickElementVisible(IWebElement tickElement)
        {
            bool visibility = tickElement.Displayed;
            if (visibility == false)
            {
                Assert.Fail("Model not saved.");

            }
        }


        public static void SelectChartType(string _type)
        {

            switch (_type)
            {
                case "Rheology Master Curve + Prony Series":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal1)).Click();
                    break;
                case "Simulated Compression":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal2)).Click();
                    break;
                case "Simulated Tensile":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal3)).Click();
                    break;
                case "Simulated Stress Relaxation":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal4)).Click();
                    break;
                case "Rheology Master Curve":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal5)).Click();
                    break;
                case "Shift Factors vs. Temperature (°C)":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal6)).Click();
                    break;
                case "Simulated Temperature Sweep":
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeDropdown)).Click();
                    BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._chartTypeVal7)).Click();
                    break;

            }
        }
    }
}
