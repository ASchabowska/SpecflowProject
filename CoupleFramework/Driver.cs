using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CoupleFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }


        public static void Initialize()
        {
            Instance = new ChromeDriver(@"C:\Drivers");
            Instance.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromSeconds(5));
        }

        public static void Close()
        {
            Driver.Instance.Close();
        }
    }
}