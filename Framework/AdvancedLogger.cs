using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class AdvancedLogger
    {

        public void OpenChrome()
        {
            var driver = new ChromeDriver();
            Console.WriteLine("Chrome has been opened");
            System.Threading.Thread.Sleep(2000);

            driver.Close();
            driver.Quit();
        }
    }
}
