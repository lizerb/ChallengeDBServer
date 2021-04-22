using OpenQA.Selenium;

namespace ChallengeDBServer.PageObjects
{
    public class HomePO
    {
        private readonly IWebDriver _driver;
       

        public HomePO(IWebDriver driver)
        {
            _driver = driver;
            
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        
    }
}
