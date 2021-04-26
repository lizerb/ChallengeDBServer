using OpenQA.Selenium;
using TechTalk.SpecFlow;
using ChallengeDBServer.Hooks;
using ChallengeDBServer.PageObjects;
using FluentAssertions;
using System;
using OpenQA.Selenium.Support.UI;

namespace ChallengeDBServer.Features
{
    [Binding]
    public class MakeAPurchaseSteps
    {
        private readonly IWebDriver _driver;

        private HomePO _homePO;
        private ProductPO _productPO;
        private SignInPO _signInPO;
        private ShoppingCartPO _shoppingCartPO;
        private CreateAccountPO _createAccountPO;

        public MakeAPurchaseSteps(Context context)
        {
            _driver = context.Driver;
            _homePO = new HomePO(_driver);
            _productPO = new ProductPO(_driver);
            _signInPO = new SignInPO(_driver);
            _shoppingCartPO = new ShoppingCartPO(_driver);
            _createAccountPO = new CreateAccountPO(_driver);
        }


        [Given(@"that I am a user who does not have an account")]
        public void GivenThatIAmAUserWhoDoesNotHaveAnAccount()
        {
            _homePO.Visit();
        }
        
        [Given(@"I choose a product")]
        public void GivenIChooseAProduct()
        {
            _homePO.ClickProductImg();
        }
        
        [When(@"insert the product to the shopping cart")]
        public void WhenInsertTheProductToTheShoppingCart()
        {
            _productPO.ClickAddToCartButton();
        }
        
        [When(@"I go to checkout")]
        public void WhenIGoToCheckout()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));            
            _productPO.ClickProceedToCheckoutButton();
        }
        
        [When(@"I create an account")]
        public void WhenICreateAnAccount()
        {
            _signInPO.InsertEmailCreate($"{Guid.NewGuid()}@hotmail.com");
            _signInPO.ClickCreateAccountButton();

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            _createAccountPO.InsertFirstName("Jane");
            _createAccountPO.InsertLastName("Doe");
            _createAccountPO.InsertPassword("12345");
            _createAccountPO.InsertAddress("Columbus street");
            _createAccountPO.InsertCity("Montgomery");
            _createAccountPO.SelectState("Alabama");
            _createAccountPO.InsertPostalCode("90540");
            _createAccountPO.SelectCountry("United States");
            _createAccountPO.InsertMobilePhone("98765432");

            _createAccountPO.ClickRegisterButton();
        }
        
        [When(@"I accept the terms of service")]
        public void WhenIAcceptTheTermsOfService()
        {
            _shoppingCartPO.ClickTermsOfServiceCheckBox();
            _shoppingCartPO.ClickProceedToCheckoutShippingButton();
        }
        
        [When(@"I select a payment method")]
        public void WhenISelectAPaymentMethod()
        {
            _shoppingCartPO.ClickPayByBankWireButton();
            _shoppingCartPO.ClickConfirmOrderButton();
        }
        
        [Then(@"the product must be at the shopping cart")]
        public void ThenTheProductMustBeAtTheShoppingCart()
        {
            _driver.PageSource.Should().Contain("Shopping-cart summary");
            _driver.PageSource.Should().Contain("Your shopping cart contains");
            _driver.PageSource.Should().Contain("Blouse");
            _shoppingCartPO.ClickProceedToCheckoutButton();
        }

        [Then(@"the address must be correct")]
        public void ThenTheAddressMustBeCorrect()
        {
            _driver.PageSource.Should().Contain("Your delivery address");
            _driver.PageSource.Should().Contain("Columbus street");
            _driver.PageSource.Should().Contain("Montgomery, Alabama 90540");
            _shoppingCartPO.ClickProceedToCheckoutAddressButton();
        }
        
        [Then(@"the total price must be correct")]
        public void ThenTheTotalPriceMustBeCorrect()
        {
            _driver.PageSource.Should().Contain("Please choose your payment method");
            _driver.PageSource.Should().Contain("$30.16");            
        }
        
        [Then(@"I successfully finish my order")]
        public void ThenISuccessfullyFinishMyOrder()
        {
            _driver.PageSource.Should().Contain("Order confirmation");
            _driver.PageSource.Should().Contain("Your order on My Store is complete.");
            _driver.PageSource.Should().Contain("Please send us a bank wire with");
        }
    }
}
