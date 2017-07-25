using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupleFramework.Pages
{
    public class SearchPage
    {
        public static string Title()
        {
            var title = Driver.Instance.FindElement(By.ClassName("page-title"));
            return title.Text;
        }
    }
}
