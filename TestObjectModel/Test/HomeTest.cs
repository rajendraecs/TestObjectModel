using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Pages;


namespace PageObjectModel.Tests
{
    public class HomeTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            _driver = new ChromeDriver();
        }
        
        [Test]
        public void SearchBrowserStack()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://www.amazon.in/");
            _driver.Manage().Window.Maximize();
            hp.Search("selenium book");
            Assert.True(_driver.Title.Contains("selenium book"));
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}