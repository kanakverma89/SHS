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
    
    public sealed class CreateNewModelsSteps
    {
        /// <summary>
        /// Go to website url. And use cookies to avoid MFA.
        /// </summary>
        [Given(@"Go to url\.")]
        public void GivenGoToUrl_()
        {

            BrowserConfig.Init();
            BrowserConfig.setCookie();
            BrowserConfig.Goto("https://3m-sharkspray-d.azurewebsites.net");
        }
        /// <summary>
        /// Click on AdhesiveType DropDown.
        /// </summary>
        [When(@"After landing on sharkspray page, click on AdhesiveType Dropdown\.")]
        public void WhenAfterLandingOnSharksprayPageClickOnAdhesiveTypeDropdown_()
        {
            ExplicitWaiting.waitForAnElementUntilClickable(ObjectIdentifiers._adhesiveDropdown);
        }

        /// <summary>
        /// Select from adhesive type dropdown.
        /// </summary>
        [Then(@"Select adhesive type from dropdown\.")]
        public void ThenSelectAdhesiveTypeFromDropdown_(Table table)
        {
            GetValues _adhesive = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectAdhesiveType(_adhesive.AdhesiveType);

        }
        [Then(@"Select Model Phase from dropdown\.")]
        public void ThenSelectModelPhaseFromDropdown_(Table table)
        {
            GetValues _model = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectModelPhase(_model.ModelPhase);
           
        }



        /// <summary>
        /// Click on DMA files button and upload file.
        /// </summary>
        [When(@"Click on open DMA files button and upload file\.")]
        public void WhenClickOnOpenDMAFilesButtonAndUploadFile_()
        {
            ExplicitWaiting.waitForTime(3000);

            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._dropDmaFilesIdentifier)).Click();
            AutoItX3 _autoIT = new AutoItX3();
            _autoIT.WinActivate("Open");
            ExplicitWaiting.waitForTime(2000);
            _autoIT.Send(@"C:\Users\KRITI\Downloads\VHB_GPH-060GF_smallstrain_MDC_InternalDataPackage\Test Data\VHB_GPH-060GF_smallstrain_MDC_MasterCurve.xlsx");
            ExplicitWaiting.waitForTime(2000);
            _autoIT.Send("{ENTER}");
        }
        [Then(@"Verify file upload\.")]
        public void ThenVerifyFileUpload_()
        {
            ExplicitWaiting.waitForTime(5000);
            IWebElement searchElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._removeFileButton));
            HelpingFunctions.elementVisible(searchElement);
        }


        /// <summary>
        /// Click on cancel upload button to stop DMA file from uploading.
        /// </summary>
        [Then(@"Click on cancel upload button to cancel uploading the file\.")]
        public void ThenClickOnCancelUploadButtonToCancelUploadingTheFile_()
        {
            ExplicitWaiting.waitForAnElement(ObjectIdentifiers._cancelUploadButton);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._cancelUploadButton)).Click();
        }
        /// <summary>
        /// Confirm upload cancellation.
        /// </summary>
        [Then(@"click on OK from the popup to confirm upload cancellation\.")]
        public void ThenClickOnOKFromThePopupToConfirmUploadCancellation_()
        {

            IAlert simpleAlert = BrowserConfig._driver.SwitchTo().Alert();
            simpleAlert.Accept();
        }

      /// <summary>
/// Click on remove file button to remove uploaded file.
/// </summary>
        [Then(@"click on remove file button to remove the uploaded file\.")]
        public void ThenClickOnRemoveFileButtonToRemoveTheUploadedFile_()
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._removeFileButton)).Click();
        }

/// <summary>
/// Verification of dispaly of files uploaded in table.
/// </summary>
        [Then(@"Verify file display\.")]
        public void ThenVerifyFileDisplay_()
        {
            ExplicitWaiting.waitForTime(3000);
            IWebElement elemTable = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._fileDisplayTable));
            List<IWebElement> lstTdElem = new List<IWebElement>(elemTable.FindElements(By.TagName("td")));

            if (lstTdElem.Count == 2)
            {
                Assert.Fail("Uploaded Files not displayed.");
            }
       
        }
        /// <summary>
        /// Click on clear all files button.
        /// </summary>
        [Then(@"Click on Clear All Files Button\.")]
        public void ThenClickOnClearAllFilesButton_()
        {
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._clearAllFilesButton));
        }

        /// <summary>
        /// verify removal of files after clicking clear all files button.
        /// </summary>
        [Then(@"Verify removal of files\.")]
        public void ThenVerifyRemovalOfFiles_()
        {

            IWebElement tableElement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._fileDisplayTable));
            List<IWebElement> lstTdElement = new List<IWebElement>(tableElement.FindElements(By.TagName("td")));

            if (lstTdElement.Count != 2)
            {
                Assert.Fail("Files not removed.");
            }
        }
        /// <summary>
        /// Click on generate constitutive model button.
        /// </summary>
        [Then(@"click on generate constitutive mechanical model button\.")]
        public void ThenClickOnGenerateConstitutiveMechanicalModelButton_()
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._generateConstitutiveModelBtn)).Click();

        }




        [Then(@"Select deformation Mode from dropdown\.")]
        public void ThenSelectDeformationModeFromDropdown_(Table table)
        {
            ExplicitWaiting.waitForTime(3000);
            GetValues _deformationType = table.CreateInstance<GetValues>();
            HelpingFunctions.SelectDeformationMode(_deformationType.DeformationMode);
        }

        [Then(@"Send density value\.")]
        public void ThenSendDensityValue_()
        {
            ExplicitWaiting.waitForTime(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._density)).SendKeys(".1");
        }

        [When(@"Upload second dma file\.")]
        public void WhenUploadSecondDmaFile_()
        {
            Thread.Sleep(3000);
            BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._dropDmaFilesIdentifier)).Click();
            AutoItX3 _autoIT = new AutoItX3();
            _autoIT.WinActivate("Open");
            ExplicitWaiting.waitForTime(2000);
            _autoIT.Send(@"C:\Users\KRITI\Downloads\Test_Data_VHB_GPH-060GF_smallstrain_MDC_MasterCurve_MasterCurve.xlsx");
            ExplicitWaiting.waitForTime(2000);
            _autoIT.Send("{ENTER}");
        }

        [Then(@"Verify multiple dma files upload\.")]
        public void ThenVerifyMultipleDmaFilesUpload_()
        {
            Thread.Sleep(3000);
            IWebElement dmafileelement = BrowserConfig._driver.FindElement(By.XPath(ObjectIdentifiers._tick1));

            HelpingFunctions.elementVisible(dmafileelement);
        }

    }
}
