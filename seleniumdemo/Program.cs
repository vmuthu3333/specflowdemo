using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace seleniumdemo
{
    class Program
    {
        static void Main(string[] args)
        {      
        
        }
        [SetUp]
        public void Initalise()
        {
            propertycollection.driver = new ChromeDriver();
            propertycollection.driver.Navigate().GoToUrl("https://likelyloans.com/");
            Console.WriteLine("opened browser");
        }
        [Test]
        public void Execute()
        {
            Homepage page = new Homepage();
            quotespage qp = new quotespage();
     //       page.Getmyquotelink.Click();
       //     Thread.Sleep(500);
       //     qp.loan_details(2010,36, "Holiday");
       //     qp.customer_Details("Testfirst", "TestLast");
       //     qp.cust_address();
       //     qp.cust_income(1000);
       //     Console.WriteLine("Execute browser");

        }
        [TearDown]
        public void cleanup()
        {
            propertycollection.driver.Close();
            Console.WriteLine("closed browser");

        }
    }
}
