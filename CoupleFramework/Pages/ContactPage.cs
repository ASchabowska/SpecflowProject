using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupleFramework.Pages
{
   public class ContactPage
    {
        

        public static ContactPageCommand CreateMessage(string user_name,string topic,string body)
        {
            return new ContactPageCommand(user_name,topic,body);
        }

        public class ContactPageCommand
        {
            private readonly string user_name;
            private readonly string topic;
            private readonly string body;

            public ContactPageCommand(string user_name,string topic,string body)
            {
                this.user_name = user_name;
                this.topic = topic;
                this.body = body;
                Driver.Instance.FindElement(By.Name("your-name")).SendKeys(user_name);
                Driver.Instance.FindElement(By.Name("your-subject")).SendKeys(topic);
                Driver.Instance.FindElement(By.Name("your-message")).SendKeys(body);
            }

            public void Send()
            {
                Driver.Instance.FindElement(By.XPath("/html/body/div/div[2]/div/div/div[1]/main/article/div/div/form/p[5]/input")).Click();

            }


        }

        public static bool Error()
        {
            return Driver.Instance.FindElement(By.XPath("/html/body/div/div[2]/div/div/div[1]/main/article/div/div/form/p[2]/span/span")).Text == "Please fill in the required field.";

        }
    }
}
