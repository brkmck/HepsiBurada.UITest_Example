using HepsiBurada.UITests.PageModels;
using HepsiBurada.UITests.Utils;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace HepsiBurada.UITests.TestSteps
{
    [Binding, Scope(Feature = "ApproveAProductComment")]
    public class ApproveAProductCommentTest
    {
        public static IWebDriver WebDriver { get; set; }
        public BasePage basePage;
        public MainPage mainPage;
        public ProductPage productPage;
        public ProductDetailsPage productDetailsPage;
        public BrowserUtils browser;
        string driverPath = String.Empty;

        public ApproveAProductCommentTest()
        {
            browser = new BrowserUtils();
            driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            WebDriver = browser.SetupChromeDriver(driverPath);
            basePage = new BasePage(WebDriver);
            mainPage = new MainPage(WebDriver);
            productPage = new ProductPage(WebDriver);
            productDetailsPage = new ProductDetailsPage(WebDriver);
        }

        [StepDefinition("'(.*)' sitesine gidilir")]
        public void OpenHepsiBurada(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        [StepDefinition("Arama çubuğundan '(.*)' ürünü aratılır")]
        public void SearchProduct(string product)
        {
            mainPage.SearchProduct(product);
        }

        [StepDefinition("Arama sonucunda gelen ürün listesinden rastgele bir ürün seçilir")]
        public void SelectProduct()
        {
            productPage.SelectProduct();
        }

        [StepDefinition("Ürün detay sayfasından değerlendirmeler tabına tıklanır")]
        public void ClickReviewTab()
        {
            productDetailsPage.ClickReviewTab();
        }

        [StepDefinition("Yorumların geldiği kontrol edilir, eğer yorum yapılmamışsa test bitirilir")]
        public void CheckReviews()
        {
            productDetailsPage.CheckReviews();
        }

        [StepDefinition("Gelen yorumlar arasından ilk yorumun evet butonuna basılır")]
        public void LikeReview()
        {
            productDetailsPage.LikeReview();
        }

        [StepDefinition("'(.*)' yazısının geldiği görülür")]
        public void CheckLikeReviewAlert(string likeReviewText)
        {
            productDetailsPage.CheckLikeReviewAlert(likeReviewText);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.Quit();
        }
    }
}


