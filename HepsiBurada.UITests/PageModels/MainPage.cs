using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HepsiBurada.UITests.PageModels
{
    public class MainPage : BasePage
    {
        private IWebDriver webDriver;

        public MainPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        #region WebElements
        [FindsBy(How = How.XPath, Using = "//div[@id='SearchBoxOld']/div/div/div[1]/div[2]/input")]
        public IWebElement txtSearch;

        [FindsBy(How = How.XPath, Using = "//div[@class='SearchBoxOld-buttonContainer']")]
        public IWebElement btnSearch;
        #endregion

        public void SearchProduct(string product)
        {
            Wait(15, txtSearch);
            if (txtSearch.Displayed && btnSearch.Displayed)
            {
                SetText(txtSearch, product);
                txtSearch.SendKeys(Keys.Enter);
            }
            else
                Assert.Fail("Arama işlemi gerçekleşemedi.");
        }
    }
}
