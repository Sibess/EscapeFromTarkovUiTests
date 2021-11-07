using OpenQA.Selenium;

namespace EscapeFromTarkovUiTests.PageObjects.WikiPage.AK_74MPage
{
    public class AK_74M : Wiki
    {
        public AK_74M(IWebDriver driver) : base(driver)
        {
        }

        public bool IsValidCartridgeDisplayed(string cartridge)
        {
            return new BaseElement(By.XPath($"//h1[@id='firstHeading'][contains(text(),'{cartridge}')]"), "AK-74M 5.45x39 assault rifle", _driver).IsDisplayed(5000);
        }
    }
}
