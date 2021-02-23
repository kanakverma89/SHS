using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using TechTalk.SpecFlow;
//using Sharkspray_3M_QA.ConfigFiles;
//using Sharkspray_3M_QA.Utility;


namespace Sharkspray_3M_QA
{
    [Binding]

    public sealed class SalemHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        static int _rowCount = 3;
        // static int _r1 = 3;
        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }
        [AfterStep]
        public static void InitiateScreenshotInFailure()
        {
            var _stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError != null)
            {
                if (_stepType == "Given")
                {
                    string _stepInfo = ScenarioStepContext.Current.StepInfo.Text;
                    TakeScreenshot.captureScreenshot(_stepInfo);
                }
                else if (_stepType == "Then")
                {
                    string _stepInfo = ScenarioStepContext.Current.StepInfo.Text;
                    TakeScreenshot.captureScreenshot(_stepInfo);
                }
                else if (_stepType == "When")
                {
                    string _stepInfo = ScenarioStepContext.Current.StepInfo.Text;
                    TakeScreenshot.captureScreenshot(_stepInfo);
                }
                else if (_stepType == "And")
                {
                    string _stepInfo = ScenarioStepContext.Current.StepInfo.Text;
                    TakeScreenshot.captureScreenshot(_stepInfo);
                }
            }
            else
            {
                //TODO: implement logic that has to run before executing each scenario
            }
        }
        [AfterScenario]
        public void FlushResultToDataFile()
        {
            //kv
            //int _rowNumber = _sno;
            string _fileName = "";
            int _colNumber = 5;
            int _sheet = 1;
            if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_01 Loaded Models Selection."))
            {
                _fileName = "ExportNSaveModels";
                _colNumber = 5;
                _sheet = 1;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_02 'Save Selected Model' Button Verification.")) 
            {
                _fileName = "ExportNSaveModels";
                _colNumber = 5;
                _sheet = 2;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_01 Verify AdhesiveType dropdown."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 1;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_02 Verify Model Phase Dropdown."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 2;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_03 DMA files upload verification."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 3;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_04 Cancel Upload Button verification."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 4;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_05 Remove file button verification."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 5;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_06 Verifcation of display of files."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 6;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_07 Verification of Clear All Files Button."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 7;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_08 Verification of Deformation Mode dropdown."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 8;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_09 Verification of Density."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 9;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_10 Verification of generate constitutive  mechanical model button."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 10;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_11 Multiple DMA file upload."))
            {
                _fileName = "CreateNewModel";
                _colNumber = 5;
                _sheet = 11;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_01 Verify Selected Model."))
            {
                _fileName = "VisualizeModelData";
                _colNumber = 5;
                _sheet = 1;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_02 Verify Chart Type Dropdown."))
            {
                _fileName = "VisualizeModelData";
                _colNumber = 5;
                _sheet =2;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_03 Verify Chart save."))
            {
                _fileName = "VisualizeModelData";
                _colNumber = 5;
                _sheet = 3;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_01 Verify Searchbox"))
            {
                _fileName = "LoadYourModels";
                _colNumber = 5;
                _sheet = 1;

            }
            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_02 Model Name Selection."))
            {
                _fileName = "LoadYourModels";
                _colNumber = 5;
                _sheet = 2;

            }

            else if (ScenarioContext.Current.ScenarioInfo.Title.Equals("_03 Load Constitutive Mechanical Model Verification."))
            {
                _fileName = "LoadYourModels";
                _colNumber = 5;
                _sheet = 3;

            }






            if (ScenarioContext.Current.TestError == null)
            {
                string _msg = "Test passed successfully.";
                string _res = "PASS";
                WriteResult.writeResultToExcel(_res, _msg, _rowCount, _fileName, _colNumber, _sheet);

            }
            else if (ScenarioContext.Current.TestError != null)
            {
                string _msg = ScenarioContext.Current.TestError.Message;
                string _res = "FAIL";
                WriteResult.writeResultToExcel(_res, _msg, _rowCount, _fileName, _colNumber, _sheet);
            }
            _rowCount = _rowCount + 1;




        }
        [AfterFeature]
        public static void CloseBrowserInstance()
        {
            BrowserConfig._driver.Quit();
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            string chromedriverbatchfile = path + "\\killChromedriver" + ".bat";
            //TODO: implement logic that has to run after executing each scenario
            System.Diagnostics.Process.Start(chromedriverbatchfile);
            BrowserConfig._driver = null;
        }
    }
}


