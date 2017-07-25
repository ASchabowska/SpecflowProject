using OpenQA.Selenium;

namespace CoupleFramework.Pages
{
    public class HomePage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://codecouple.pl/");
        }

        public static void Subscribe()
        {
            Driver.Instance.FindElement(By.Name("button")).Click();
        }

        public static void Search(string search)
        {
            Driver.Instance.FindElement(By.Name("s")).SendKeys(search);
            Driver.Instance.FindElement(By.Name("submit")).Click();

        }

        public static HomePageCommand SelectAuthor(string authors_name)
        {
            return new HomePageCommand(authors_name);
        }

        public static bool IsTextPresent(string warning)
        {
            var exc = Driver.Instance.FindElement(By.PartialLinkText(warning));
            if (exc != null)
            {
                return true;
            }
            else return false;
        }

        public static void Java()
        {
            Driver.Instance.FindElement(By.XPath("//img[@alt='Java']")).Click();
        }
    }

    public class HomePageCommand
    {
        private readonly string authors_name;

        public HomePageCommand(string authors_name)
        {
            this.authors_name = authors_name;
        }

        public void Click()
        {
            Driver.Instance.FindElement(By.LinkText(authors_name)).Click();
        }
       

      
    }
}
