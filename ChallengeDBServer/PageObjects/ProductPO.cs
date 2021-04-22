using OpenQA.Selenium;

namespace ChallengeDBServer.PageObjects
{
    public class ProductPO
    {
        private readonly IWebDriver _driver;

        private By byAddToCartButton;
        private By byProceedToCheckoutButton;

        public ProductPO(IWebDriver driver)
        {
            _driver = driver;
            byAddToCartButton = By.CssSelector("button.exclusive");
            byProceedToCheckoutButton = By.CssSelector("a.button-medium");
        }

        public void ClickAddToCartButton()
        {
            _driver.FindElement(byAddToCartButton).Click();
        }

        public void ClickProceedToCheckoutButton()//esperar para isso abrir
        {
            _driver.FindElement(byProceedToCheckoutButton).Click();
        }
        // assert SHOPPING-CART SUMMARY
    }
}
