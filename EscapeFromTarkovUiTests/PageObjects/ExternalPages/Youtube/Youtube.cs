using OpenQA.Selenium;

namespace EscapeFromTarkovUiTests.PageObjects.ExternalPages
{
    public class Youtube : ExternalPages
    {
        public Youtube(IWebDriver driver) : base(driver)
        {
            _driver.SwitchTo().DefaultContent();
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//iframe[@id='VideoPlayer_39']")));
        }

        private BaseElement playButton => new BaseElement(By.XPath("//button[@title='Play (k)']"), "Play Button", _driver);

        private BaseElement playingVideo => new BaseElement(By.XPath("//*[@class='html5-video-player ytp-exp-bottom-control-flexbox ytp-title-enable-channel-logo ytp-embed ytp-embed-playlist ytp-large-width-mode playing-mode' or @class='html5-video-player ytp-exp-bottom-control-flexbox ytp-title-enable-channel-logo ytp-embed ytp-embed-playlist ytp-large-width-mode playing-mode ytp-autohide']"), "Play Button", _driver);

        public void ClickPlayButton()
        {
            playButton.Click();
        }
        public bool IsVideoPlaying()
        {
            playingVideo.WaitForElementIsPresent(5000);
            return playingVideo.IsPresent(5000);
        }
    }
}
