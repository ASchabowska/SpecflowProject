using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupleFramework.Pages
{
    public class AuthorsPage
    {
        public static string Title()
        {
                var title = Driver.Instance.FindElement(By.ClassName("entry-title"));
                return title.Text;
        }

        public static void Search(string search)
        {
            Driver.Instance.FindElement(By.Name("s")).SendKeys(search);
            Driver.Instance.FindElement(By.Name("submit")).Click();
        }
    }
}
