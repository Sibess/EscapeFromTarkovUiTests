using System;
using EscapeFromTarkovUiTests.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EscapeFromTarkovUiTests
{
    public class DriverInitialization
    {
        public IWebDriver InitializeDriver()
        {
            IWebDriver driver;

            switch (GlobalRunSettings.BrowserName)
            {
                case BrowserName.Chrome:
                    var chromeOptions = new ChromeOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Normal,
                        AcceptInsecureCertificates = true,
                        UnhandledPromptBehavior = UnhandledPromptBehavior.Accept
                    };
                    chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
                    chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);
                    chromeOptions.AddUserProfilePreference("download.directory_upgrade", true);
                    chromeOptions.AddUserProfilePreference("safebrowsing.enabled", true);
                    chromeOptions.AddArgument("no-sandbox");
                    driver = new ChromeDriver(chromeOptions);
                    break;
                default:
                    throw new Exception($"{GlobalRunSettings.BrowserName} driver can not be initialized");
            }
            return driver;
        }
    }
}
