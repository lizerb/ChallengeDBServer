using OpenQA.Selenium;

namespace ChallengeDBServer.PageObjects
{
    public class HomePO
    {
        private readonly IWebDriver _driver;
        private By byProductImg; 

        public HomePO(IWebDriver driver)
        {
            _driver = driver;
            byProductImg = By.XPath("//*[@id='homefeatured']/li[2]/div/div[1]/div/a[1]");
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void ClickProductImg()
        {
            _driver.FindElement(byProductImg).Click();
        }
        
    }
}
