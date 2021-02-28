using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace HepsiBurada.UITests.PageModels
{
    public class ProductDetailsPage : BasePage
    {
        private IWebDriver webDriver;

        public ProductDetailsPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        #region WebElements
        [FindsBy(How = How.XPath, Using = "//a[@id='productReviewsTab']")]
        public IWebElement tabReview;

        [FindsBy(How = How.XPath, Using = "//div[@id='hermes-voltran-comments']/div[3]/div[3]/div/div")]
        public IList<IWebElement> reviewList;

        [FindsBy(How = How.XPath, Using = "//div[@id='hermes-voltran-comments']/div[3]/div[3]/div/div[1]/div[2]/div[4]/div[1]/div/div[1]/div[1]")]
        public IWebElement btnLikeReview;

        [FindsBy(How = How.XPath, Using = "//div[@id='hermes-voltran-comments']/div[3]/div[3]/div/div[1]/div[2]/div[4]/div[2]/span[2]")]
        public IWebElement txtReviewAlert;

        string xpathReviewTab = "//a[@id='productReviewsTab']";
        string xpathReviewAlert = "//div[@id='hermes-voltran-comments']/div[3]/div[3]/div/div[1]/div[2]/div[4]/div[2]/span[2]";
        #endregion

        public void ClickReviewTab()
        {
            Wait(15, tabReview);
            if (tabReview.Displayed)
            {
                ScrollInToView(tabReview);
                ClickElement(tabReview);
            }
            else
                Assert.Fail("Değerlendirmeler tabına tıklanamadı.");
        }

        public void CheckReviews()
        {
            if (!IsReviewExisting())
                Assert.Pass("Ürüne hiç yorum yapılmamış.");
            else
            {
                for (int i = 0; i < reviewList.Count; i++)
                {
                    Wait(15, reviewList[i]);
                    if (!reviewList[i].Displayed)
                    {
                        Assert.Fail("Yorumlar yüklenemedi.");
                    }
                }
            }
        }

        public bool IsReviewExisting()
        {
            string txtTabReview = tabReview.FindElement(By.XPath(xpathReviewTab)).Text.Trim();
            int cntReview = Int32.Parse(txtTabReview.Substring(18, txtTabReview.Length - 19));
            if (cntReview == 0)
                return false;
            return true;
        }

        public void LikeReview()
        {
            Wait(15, btnLikeReview);
            if (btnLikeReview.Displayed)
            {
                ScrollInToView(btnLikeReview);
                ClickElement(btnLikeReview);
            }
            else
                Assert.Fail("Değerlendirme beğenme butonuna tıklanamadı.");
        }

        public void CheckLikeReviewAlert(string likeReviewText)
        {
            Wait(15, txtReviewAlert);
            if (txtReviewAlert.Displayed)
            {
                Wait(2);
                string txtLikeReviewAlert = txtReviewAlert.FindElement(By.XPath(xpathReviewAlert)).Text.Trim();
                Assert.AreEqual(likeReviewText, txtLikeReviewAlert, "Beğeni uyarısı düzgün yüklenemedi.");
            }
            else
                Assert.Fail("Beğeni uyarısı yüklenemedi.");
        }
    }
}
