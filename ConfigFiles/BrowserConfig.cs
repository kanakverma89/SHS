

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Sharkspray_3M_QA

{
    class BrowserConfig
    {
        public static IWebDriver _driver;
        public static readonly string _baseUrl = ConfigurationManager.AppSettings.Get("url");
        public static readonly string _browser = ConfigurationManager.AppSettings.Get("browsers");
        public static string _sftwrDwnldPortalUrl = "https://download-qa.3m.com/Home/ViewSoftwareAno";
        public static string _approveUrl = "https://download-qa.3m.com/Organizations/ViewOrganizationDetailsAsync";
        public static string _signinUrl = "https://salemappb2c.b2clogin.com/salemappb2c.onmicrosoft.com/b2c_1_signin_forpass_qa_v2/oauth2/v2.0/authorize?client_id=760453f5-8888-44c9-8a88-92c2208cc68b&redirect_uri=https%3A%2F%2Fdownload-qa.3m.com%2Fsignin-oidc&response_type=code%20id_token&scope=openid%20profile%20offline_access%20https%3A%2F%2Fsalemappb2c.onmicrosoft.com%2Fapiqa%2Fuser_impersonation&response_mode=form_post&nonce=637378166135776444.NWU0ZjY5ZGEtMDkyYi00ZDg0LTkzYTktOTg1YTk1YjczN2UxODgyN2E5NGYtZjAwYi00NjdhLTgwYzEtNjdhOThmNmRjM2I5&state=CfDJ8MwiKyUh9IBGvmHYlluf3FKoESZjej2nBEBvT0TZj-Ubm4ohJiT_bSeSwJhkMFzDfnIBauzUrQ-qIay9pyG4H25BYn6MzgWBTUJWJGCn0y7Ourf7JjtQlj_hm55XnzpbjVDywk6M24fXYHldvdIMu-dHmLXpbJtaIRWeCx6jlCDR-wZdALsWV_EEsSgDPkR6i0GyVTpHEcfpZ6W7WRziNtQVZvT2jzeOA4Uar80OSvLJg5tFVnEThsVq0-tneNdjF9JHVOkixSXIrpjnDGI6OnbXrulN8xTY37RCofX8dMox&x-client-SKU=ID_NETSTANDARD2_0&x-client-ver=5.3.0.0";
        public static void Init()
        {
            Thread.Sleep(2000);
            if (_driver != null)
            {
                string _currentUrl = _driver.Url;
                if (_currentUrl.Equals(_sftwrDwnldPortalUrl))
                {
                    Console.WriteLine("Already on the 3M Software Download Portal.");
                }
                else
                {
                    Goto(_baseUrl);
                }
            }
            else if (_driver != null)
            {
                string _currentUrl = _driver.Url;
                if (_currentUrl.Contains(_approveUrl))
                {
                    Goto(_baseUrl);

                }
                else
                {
                    Console.WriteLine("Already on create organisation page.");
                }
            }
            else if (_driver != null)
            {
                string _currentUrl = _driver.Url;
                if (_currentUrl.Equals(_signinUrl))
                {
                    Console.WriteLine("sign in page");
                }
                else
                {
                    Goto(_baseUrl);
                }
            }
            else
            {
                switch (_browser)
                {
                    case "Chrome":
                        _driver = new ChromeDriver();
                        // Cookie ck = new Cookie("COOKIE", "csrftoken", "pvXnYte7iQP80KQxyFzQf8BfpLX67mMHBRHpY6Swpj1jK1Rsm2o1RHVAQvI4Z2Mu");
                        //  _driver.Manage().Cookies.AddCookie(ck);
                        // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                        //csrftoken = pvXnYte7iQP80KQxyFzQf8BfpLX67mMHBRHpY6Swpj1jK1Rsm2o1RHVAQvI4Z2Mu; sessionid = hhj5jm3tvlklsivna3prp2v720sw7ay2; sessionid = hhj5jm3tvlklsivna3prp2v720sw7ay2

                        break;
                    case "IE":
                        _driver = new InternetExplorerDriver();
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                        break;
                    case "Firefox":
                        _driver = new FirefoxDriver();
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                        break;
                }
                _driver.Manage().Window.Maximize();
                Goto(_baseUrl);

            }
        }

        public static void Goto(string baseUrl)
        {
            _driver.Url = baseUrl;
        }

        public static void setCookie()
        {

            Cookie ck = new Cookie("csrftoken", "TQrDpfoL2g0lmqvxbgnN6gambo6y5NDUmNdXlQPGzhENT6uCUsTl60cHIyM21P5o");
            Cookie ck1 = new Cookie("sessionid", "lutm76uklk916e41kgn39aky8c76a2r3");

            _driver.Manage().Cookies.AddCookie(ck);
            _driver.Manage().Cookies.AddCookie(ck1);



        }
    }
}


