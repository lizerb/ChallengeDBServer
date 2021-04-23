using OpenQA.Selenium;
using TechTalk.SpecFlow;
using ChallengeDBServer.Hooks;
using ChallengeDBServer.PageObjects;
using FluentAssertions;

namespace ChallengeDBServer.Features
{
    [Binding]
    public class MakeAPurchaseSteps
    {
        private readonly IWebDriver _driver;

        private HomePO homePO;
        private ProductPO productPO;
        private SignInPO signInPO;
        private ShoppingCartPO shoppingCartPO;
        private CreateAccountPO createAccountPO;

        public MakeAPurchaseSteps(Context context)
        {
            _driver = context.Driver;
            homePO = new HomePO(_driver);
            productPO = new ProductPO(_driver);
            signInPO = new SignInPO(_driver);
            shoppingCartPO = new ShoppingCartPO(_driver);
            createAccountPO = new CreateAccountPO(_driver);
        }


        [Given(@"that I am a user who does not have an account")]
        public void GivenThatIAmAUserWhoDoesNotHaveAnAccount()
        {
            homePO.Visit();
        }
        
        [Given(@"I choose a product")]
        public void GivenIChooseAProduct()
        {
            homePO.ClickProductImg();
        }
        
        [When(@"insert the product to the shopping cart")]
        public void WhenInsertTheProductToTheShoppingCart()
        {
            productPO.ClickAddToCartButton();
        }
        
        [When(@"I go to checkout")]
        public void WhenIGoToCheckout()
        {
            productPO.ClickProceedToCheckoutButton();
        }
        
        [When(@"I create an account")]
        public void WhenICreateAnAccount()
        {
            createAccountPO.
        }
        
        [When(@"I accept the terms of service")]
        public void WhenIAcceptTheTermsOfService()
        {
            shoppingCartPO.ClickTermsOfServiceCheckBox();
        }
        
        [When(@"I select a payment method")]
        public void WhenISelectAPaymentMethod()
        {
            shoppingCartPO.ClickPayByBankWireButton();
        }
        
        [Then(@"the product must be at the shopping cart")]
        public void ThenTheProductMustBeAtTheShoppingCart()
        {
            _driver.PageSource.Should().Contain("Shopping-cart summary");
            _driver.PageSource.Should().Contain("Your shopping cart contains");
            _driver.PageSource.Should().Contain("Blouse");            
        }

        [Then(@"the address must be correct")]
        public void ThenTheAddressMustBeCorrect()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the total price must be correct")]
        public void ThenTheTotalPriceMustBeCorrect()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I successfully finish my order")]
        public void ThenISuccessfullyFinishMyOrder()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
