using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace HepsiBurada.UITests.PageModels
{
    public class ProductPage : BasePage
    {
        private IWebDriver webDriver;
        Random random = new Random();

        public ProductPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        #region WebElements
        [FindsBy(How = How.XPath, Using = "//ul[@class='product-list results-container do-flex list']/li/div/a")]
        public IList<IWebElement> productList;
        #endregion

        public void SelectProduct()
        {
            CheckProducts();
            int productNumber = random.Next(productList.Count);
            ClickElement(productList[productNumber]);
        }

        public void CheckProducts()
        {
            Wait(5);
            for(int i = 0; i < productList.Count; i++)
            {
                Wait(15, productList[i]);
                if (!productList[i].Displayed)
                {
                    Assert.Fail("Ürünler yüklenemedi.");
                }
            }
        }
    }
}
