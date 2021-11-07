using EscapeFromTarkovUiTests.PageObjects.HomePage;
using OpenQA.Selenium;
using EscapeFromTarkovUiTests.PageObjects.Error208Page;

namespace EscapeFromTarkovUiTests.PageObjects.SupportPage
{
    public class Support : Home
    {
        public Support(IWebDriver driver) : base(driver)
        {
        }

        public Error208 Error208 => new Error208(_driver);
        private BaseElement error208Link => new BaseElement(By.XPath("(//a[contains(text(),'Error 208')])[1]"), "'Error 208' link", _driver);

        public void Clickerror208Link()
        {
            error208Link.Click();
        }
    }
}
