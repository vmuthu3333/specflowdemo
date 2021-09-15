using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace seleniumdemo.Steps
{
   
    [Binding]

    public sealed class quotn_step
    {
      
     /*   [Given(@"User launch the application url")]
        public void GivenUserLaunchTheApplicationUrl()
        {
            propertycollection.driver.Navigate().GoToUrl("https://likelyloans.com/");
            
        }*/


        [Given(@"User launch the application url ""(.*)""")]
        public void GivenUserLaunchTheApplicationUrl(string url)
        {
            propertycollection.driver.Navigate().GoToUrl(url);
        }


        [Given(@"click on Getmyquote link")]
        public void GivenClickOnGetmyquoteLink()
        {
            Homepage page = new Homepage();
            IJavaScriptExecutor ijava = (IJavaScriptExecutor)propertycollection.driver;
            ijava.ExecuteScript("arguments[0].click()", page.Getmyquotelink);          
        }


        [When(@"User submits their details with")]
        public void WhenUserSubmitsTheirDetailsWith(Table table)
        {
            IEnumerable<dynamic> cust_Details = table.CreateDynamicSet();
            foreach (var data in cust_Details)
            {
                Thread.Sleep(500);
                quotespage qp = new quotespage();
                qp.loan_details((int)data.borroamt, (int)data.period, (string)data.purpose);
                qp.customer_Details((string)data.firstname, (string)data.lastname);
                qp.cust_address();
                qp.cust_income(1000);
                propertycollection.driver.Navigate().Refresh();
            }

        }

        [Then(@"quotation should be submitted successfully")]
        public void ThenQuotationShouldBeSubmittedSuccessfully()
        {
            Console.WriteLine("Execute browser");
        }

    }
}
