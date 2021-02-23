﻿

using OpenQA.Selenium;
//using Sharkspray_3M_QA.ConfigFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sharkspray_3M_QA
{
    class TakeScreenshot
    {
        public static string _filename = "";
        /// <summary>
        /// Takes screenshot of failed test cases
        /// </summary>
        /// <param name="_stepInfo"></param>
        public static void captureScreenshot(string _stepInfo)
        {
            var _takeScreenshot = BrowserConfig._driver as ITakesScreenshot;
            if (_takeScreenshot != null)
            {
                var _rootPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Screenshots");
                bool _dirExists = Directory.Exists(_rootPath);
                if (_dirExists)
                {
                    var screenshot = _takeScreenshot.GetScreenshot();
                    var _tmpFileName = Path.Combine(_rootPath, Path.GetFileNameWithoutExtension(_stepInfo)) + ".jpg";
                    _filename = _tmpFileName;
                    screenshot.SaveAsFile(_filename, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);
                    Console.WriteLine($"SCREENSHOT[ file:///{_tmpFileName} ]SCREENSHOT");
                }
                else
                {
                    DirectoryInfo _di = Directory.CreateDirectory(_rootPath);
                    var screenshot = _takeScreenshot.GetScreenshot();
                    var _tmpFileName = Path.Combine(_rootPath, Path.GetFileNameWithoutExtension(_stepInfo)) + ".jpg";
                    _filename = _tmpFileName;
                    screenshot.SaveAsFile(_filename, OpenQA.Selenium.ScreenshotImageFormat.Jpeg);
                    Console.WriteLine($"SCREENSHOT[ file:///{_tmpFileName} ]SCREENSHOT");
                }
            }
        }
    }
}

