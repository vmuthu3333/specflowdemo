using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace seleniumdemo
{
    class quotespage
    {
        public quotespage()
        {
            PageFactory.InitElements(propertycollection.driver, this);
        }
        //setting property for elements
        [FindsBy(How = How.XPath, Using = "//*[@id='LoanAmount_Input']")]
        public IWebElement borrowamount { get; set; }
        [FindsBy(How= How.CssSelector, Using = "button#LoanTerm_12")]
        public IWebElement borrowmonth_12 { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#LoanTerm_24")]
        public IWebElement borrowmonth_24 { get; set; }
       [FindsBy(How = How.CssSelector, Using = "button#LoanTerm_36")]
        public IWebElement borrowmonth_36 { get; set; }
        [FindsBy(How = How.Id, Using = "LoanPurpose")]
        public IWebElement loanpurpose { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button#CurrentCustomer_Yes")]
        public IWebElement currentloan { get; set; }
        [FindsBy(How = How.CssSelector, Using = "html > body > div > div > div > div > div > div > div > button")]
        public IWebElement closebutton { get; set; }
        [FindsBy(How = How.Id, Using = "Title")]
        public IWebElement title { get; set; }
        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement Firstname { get; set; }
        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement Lastname { get; set; }
        [FindsBy(How = How.Id, Using = "DateOfBirth_Day")]
        public IWebElement Daybirth { get; set; }
        [FindsBy(How = How.Id, Using = "DateOfBirth_Month")]
        public IWebElement Daymonth { get; set; }
        [FindsBy(How = How.Id, Using = "DateOfBirth_Year")]
        public IWebElement Dayyear { get; set; }
        [FindsBy(How = How.Id, Using = "Dependants")]
        public IWebElement dependant { get; set; }
        [FindsBy(How = How.Id, Using = "MobilePhoneNumber")]
        public IWebElement phone { get; set; }
        [FindsBy(How = How.Id, Using = "EmailAddress")]
        public IWebElement EmailAddress { get; set; }
        [FindsBy(How = How.Id, Using = "EmailAddressConfirmation")]
        public IWebElement EmailAddressConfirmation { get; set; }
        [FindsBy(How = How.Id, Using = "ResidentialStatus")]
        public IWebElement ResidentialStatus { get; set; }
        [FindsBy(How = How.Id, Using = "Address_Address_AddressSearch")]
        public IWebElement postcode { get; set; }
        [FindsBy(How = How.CssSelector,Using = "button#Address_AddressSearch > span > i")]
        public IWebElement search { get; set; }
        [FindsBy(How = How.Id, Using = "EmploymentStatus")]
        public IWebElement EmploymentStatus { get; set; }
        [FindsBy(How = How.Id, Using = "IncomeCalculator_GrossIncomeAmount")]
        public IWebElement IncomeCalculator_GrossIncomeAmount { get; set; }
        [FindsBy(How = How.Id, Using = "IncomeCalculator_SelectedIncomeFrequency_Weekly")]
        public IWebElement Frequency_Weekly { get; set; }
        [FindsBy(How = How.Id, Using = "HousingContribution")]
        public IWebElement HousingContribution { get; set; }
        public void loan_details(int borrow, int months, string purpose)
        {
            //borrowamount.SendKeys(borrow.ToString());
            Thread.Sleep(200);
            borrowamount.SendKeys(Convert.ToString(borrow));
            if(months==12)
            borrowmonth_12.Click();
            if (months == 24)
                borrowmonth_24.Click();
            else
              borrowmonth_36.Click();
            SelectElement select = new SelectElement(loanpurpose);
            select.SelectByText(purpose);
            IJavaScriptExecutor ijava = (IJavaScriptExecutor)propertycollection.driver;
            ijava.ExecuteScript("arguments[0].click()", currentloan);
            closebutton.Click();
            //currentloan.Click();
        }

        public void customer_Details(String firstname, String lastname)
            {
            SelectElement select = new SelectElement(title);
            select.SelectByText("Mr");
            Firstname.SendKeys(firstname);
            Lastname.SendKeys(lastname);
            Daybirth.SendKeys("10");
            Daymonth.SendKeys("12");
            Dayyear.SendKeys("1990");
            SelectElement depen = new SelectElement(dependant);
            depen.SelectByValue("4");
            phone.SendKeys("07777777777");
            EmailAddress.SendKeys("test@gmail.com");
            EmailAddressConfirmation.SendKeys("test@gmail.com");
           
        }
        public void cust_address()
        {
            SelectElement select = new SelectElement(ResidentialStatus);
            Random rnd = new Random();
            int index = rnd.Next(0, 4);
            select.SelectByIndex(index);
            Thread.Sleep(2000);
            //select.SelectByIndex(2);
            postcode.SendKeys("Ng2 3hx");
            IJavaScriptExecutor ijava = (IJavaScriptExecutor)propertycollection.driver;
            ijava.ExecuteScript("arguments[0].click()", search);
           

        }

        public void cust_income(int amount)
        {
            SelectElement select = new SelectElement(EmploymentStatus);
            select.SelectByIndex(4);
            IncomeCalculator_GrossIncomeAmount.SendKeys(amount.ToString());
            IJavaScriptExecutor ijava = (IJavaScriptExecutor)propertycollection.driver;
            ijava.ExecuteScript("arguments[0].click()", Frequency_Weekly);
            HousingContribution.SendKeys("500");

        }
    }
}
