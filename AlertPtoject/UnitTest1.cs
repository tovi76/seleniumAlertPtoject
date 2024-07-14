using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Xml.XPath;

namespace AlertPtoject
{
    public class Tests
    { 
        private IWebDriver driver;
        string path = "T:\\הנדסת תוכנה\\שנה ב\\קבוצה ב\\תלמידות\\מירי קרלנשטיין\\פיתוח אוטומציה\\drivers";
        private WebDriverWait wait;
        private IAlert alert;
        public Tests()
        {

        }
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(path);
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
        }
        //public void clickElement(string pathElement)
        //{
        //    IWebElement cardAlert = driver.FindElement(By.XPath(pathElement));
        //    cardAlert.Click();
        //}

        public void clickElementById(string idElement)
        {
            IWebElement idAlert = driver.FindElement(By.Id(idElement));
            idAlert.Click();
        }

        [Test]
        public void Test1()
        {
            //1
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");

            //2
            //string XPath = "*[@id=\"app\"]/div/div/div[2]/div/div[4]";
            //clickElement(XPath);

            //string idButton = "item-1";
            //clickElementById(idButton);

            //3
            string idtimerButton = "timerAlertButton";
            clickElementById(idtimerButton);

            //4
            System.Threading.Thread.Sleep(10000);

            //5
            alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}