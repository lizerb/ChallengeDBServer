using OpenQA.Selenium;

namespace ChallengeDBServer.PageObjects
{
    public class SignInPO
    {
        private readonly IWebDriver _driver;
        private By byEmailCreateInput;
        private By byCreateAccountButton;

        public SignInPO(IWebDriver driver)
        {
            _driver = driver;
            byEmailCreateInput = By.Id("email_create");
            byCreateAccountButton = By.Id("SubmitCreate");
        }

        public void InsertEmailCreate(string email)
        {
            _driver.FindElement(byEmailCreateInput).SendKeys(email);
        }

        public void ClickCreateAccountButton()
        {
            _driver.FindElement(byCreateAccountButton).Click();
        }
    }
}
