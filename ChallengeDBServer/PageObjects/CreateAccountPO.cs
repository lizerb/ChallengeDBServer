using OpenQA.Selenium;

namespace ChallengeDBServer.PageObjects
{
    public class CreateAccountPO
    {
        private readonly IWebDriver _driver;

        private By byFirstNameInput;
        private By byLastNameInput;
        private By byPasswordInput;        
        private By byAddressInput;
        private By byCityInput;
        private By byStateInput;
        private By byPostalCodeInput;
        private By byCountryInput;
        private By byMobilePhoneInput;
        private By byRegisterButton;

        public CreateAccountPO(IWebDriver driver)
        {
            _driver = driver;
            byFirstNameInput = By.Id("customer_firstname");
            byLastNameInput = By.Id("customer_lastname");
            byPasswordInput = By.Id("passwd");            
            byAddressInput = By.Id("address1");
            byCityInput = By.Id("city");
            byStateInput = By.Id("id_state");
            byPostalCodeInput = By.Id("postcode");
            byCountryInput = By.Id("id_country");
            byMobilePhoneInput = By.Id("phone_mobile");
            byRegisterButton = By.Id("submitAccount");
        }

        public void InsertFirstName(string firstName)
        {
            _driver.FindElement(byFirstNameInput).SendKeys(firstName);
        }

        public void InsertLastName(string lastName)
        {
            _driver.FindElement(byLastNameInput).SendKeys(lastName);
        }

        public void InsertPassword(string password)
        {
            _driver.FindElement(byPasswordInput).SendKeys(password);
        }        

        public void InsertAddress(string address)
        {
            _driver.FindElement(byAddressInput).SendKeys(address);
        }

        public void InsertCity(string city)
        {
            _driver.FindElement(byCityInput).SendKeys(city);
        }

        public void InsertState(string state)   // select
        {
            _driver.FindElement(byStateInput).SendKeys(state);
        }

        public void InsertPostalCode(string postalCode)
        {
            _driver.FindElement(byPostalCodeInput).SendKeys(postalCode);
        }

        public void InsertCountry(string country)  // select
        {
            _driver.FindElement(byCountryInput).SendKeys(country);
        }

        public void InsertMobilePhone(string mobilePhone)
        {
            _driver.FindElement(byMobilePhoneInput).SendKeys(mobilePhone);
        }

        public void ClickRegisterButton()
        {
            _driver.FindElement(byRegisterButton).Click();
        }
    }
}
