
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
//using Dotnetselenium
using System.IO;
using OpenQA.Selenium.Interactions;
using System.Collections;
using OpenQA.Selenium.Edge;
using NUnit.Framework.Internal;
using System.Data;
using IronXL;
using Selenium_Demo;
using seleniumlearning.utilities;



namespace seleniumlearning
{
    public class clsConditional
    {
        [Test]
        public void verifyCondition()
        {
            string name = "TS";
            if (name == "TS")
            {
                Console.WriteLine("captial city is hyderabad");
            }
            else
            {
                Console.WriteLine("unknown captial");
            }
        }

        [Test]
        public void verifyIfstatement()
        {
            int x = 45;
            if (x > 10 && x < 30)
            {
                Console.WriteLine("x is > 10 and < 30");
            }
            else if (x > 30 && x < 40)
            {
                Console.WriteLine("x is > 30");
            }
            else
            {
                Console.WriteLine("x is > 40");
            }
        }
        [Test]
        public void Addition()
        {
            int x = 1;
            int y = 2;
            int sum = x + y;

            Console.WriteLine(sum);//print the sum of x+y

        }
        [Test]
        public void substraction()
        {
            int x = 3;
            int y = 7;
            int sub = x - y;

            Console.WriteLine(sub);//print the sub of x-y
        }
        [Test]
        public void multiplication()
        {
            int x = 3;
            int y = 7;
            int mult = x * y;
            Console.WriteLine(mult);

        }
        [Test]
        public void division()
        {
            int x = 0;
            int y = 2;
            int div = x / y;
            Console.WriteLine(div);
        }
    [Test]
        public void OpenGoogle()
        {
        IWebDriver dr = new EdgeDriver(@"C:\\Users\\hp\\Downloads\\edge driver\");
            dr.Navigate().GoToUrl("https://google.com");
            dr.Manage().Window.Maximize();
            IWebElement webElement = dr.FindElement(By.Name("q"));
            webElement.SendKeys("surprise");
            webElement.SendKeys(Keys.Enter);
        }
        [Test]
        public void Openhotel()

        {
            IWebDriver dr = new EdgeDriver(@"C:\\Users\\hp\\Downloads\\edge driver\");
            dr.Navigate().GoToUrl("https://in.hotels.com/?locale=en_IN&pos=HCOM_IN&siteid=300000036");
            dr.Manage().Window.Maximize();
            IWebElement webElement = dr.FindElement(By.XPath("//button[@ name='EGDSDateRange-date-selector-trigger']"));
            
        }
        [Test]
        public void Datadriventest2()
        {

            clsMyLogger logger = new clsMyLogger();
            clsUtilities _utilities = new clsUtilities();
            IWebDriver dr = new EdgeDriver(@"C:\\Users\\hp\\Downloads\\edge driver\");
            DataTable dtAnvesh = _utilities.ReadExcel("C:\\Users\\hp\\OneDrive\\Documents\\list.xlsx", "");
           // Console.WriteLine("Rows count is:" + dtAnvesh.Rows);
            for (int i = 0; i < dtAnvesh.Rows.Count; i++)
            {
                
                dr.Navigate().GoToUrl("http://google.com");
                //logger.LogMessage("Opened Google site");
                dr.FindElement(By.Name("q")).SendKeys(dtAnvesh.Rows[i][0].ToString());
                dr.FindElement(By.Name("q")).SendKeys(Keys.Enter);
                //logger.LogMessage("searched for:" + dtAnvesh.Rows[i][0].ToString());

            }
            dr.Close();

        }


    }
}

        
