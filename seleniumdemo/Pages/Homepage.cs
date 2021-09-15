using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumdemo
{
    class Homepage
    {
        public Homepage()
        {
          PageFactory.InitElements(propertycollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='https://enquiry.likelyloans.com/apply?LoanAmount=2000&LoanTermInMonths=24&']")]
        public IWebElement Getmyquotelink { get; set; }
     
    }
}