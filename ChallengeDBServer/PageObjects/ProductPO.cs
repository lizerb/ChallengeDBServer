using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

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

        public void ClickProceedToCheckoutButton()
        {            
            _driver.FindElement(byProceedToCheckoutButton).Click();
        }        
    }
}
