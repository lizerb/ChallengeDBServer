using OpenQA.Selenium;

namespace ChallengeDBServer.PageObjects
{
    public class ShoppingCartPO
    {
        private readonly IWebDriver _driver;
        private By byProceedToCheckoutButton;
        private By byProceedToCheckoutAddressButton;
        private By byTermsOfServiceCheckbox;
        private By byProceedToCheckoutShippingButton;
        private By byPaymentMethodButton;
        private By byConfirmOrderButton;

        public ShoppingCartPO(IWebDriver driver)
        {
            _driver = driver;
            byProceedToCheckoutButton = By.CssSelector("a.standard-checkout");
            byProceedToCheckoutAddressButton = By.Name("processAddress");
            byTermsOfServiceCheckbox = By.Id("cgv");
            byProceedToCheckoutShippingButton = By.Name("processCarrier");
            byPaymentMethodButton = By.CssSelector("a.bankwire");
            byConfirmOrderButton = By.CssSelector("button.button-medium");
        }

        public void ClickProceedToCheckoutButton()
        {
            _driver.FindElement(byProceedToCheckoutButton).Click();
        }

        public void ClickProceedToCheckoutAddressButton()
        {
            _driver.FindElement(byProceedToCheckoutAddressButton).Click();
        }//assert YOUR DELIVERY ADDRESS

        public void ClickTermsOfServiceCheckBox()
        {
            _driver.FindElement(byTermsOfServiceCheckbox).Click();
        }

        public void ClickProceedToCheckoutShippingButton()
        {
            _driver.FindElement(byProceedToCheckoutShippingButton).Click();
        }

        public void ClickPayByBankWireButton()
        {
            _driver.FindElement(byPaymentMethodButton).Click();
        }

        public void ClickConfirmOrderButton()
        {
            _driver.FindElement(byConfirmOrderButton).Click();
        }

        //asserts ORDER CONFIRMATION 
        //Your order on My Store is complete.

        //Please send us a bank wire with
        //- Amount $30.16
    }
}
