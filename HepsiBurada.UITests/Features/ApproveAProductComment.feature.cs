﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HepsiBurada.UITests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ApproveAProductComment")]
    public partial class ApproveAProductCommentFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ApproveAProductComment.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ApproveAProductComment", "Hepsiburada sitesi açılır, ürün araması yapılır,\r\nbir ürün detayına gidilir, ürün" +
                    "e yapılan yorum beğenilir", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line 6
 testRunner.And("\'https://www.hepsiburada.com/\' sitesine gidilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ApproveAProductComment")]
        public virtual void ApproveAProductComment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ApproveAProductComment", ((string[])(null)));
#line 8
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 9
 testRunner.And("Arama çubuğundan \'iphone\' ürünü aratılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 10
 testRunner.And("Arama sonucunda gelen ürün listesinden rastgele bir ürün seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 11
 testRunner.And("Ürün detay sayfasından değerlendirmeler tabına tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 12
 testRunner.And("Yorumların geldiği kontrol edilir, eğer yorum yapılmamışsa test bitirilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 13
 testRunner.And("Gelen yorumlar arasından ilk yorumun evet butonuna basılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 14
 testRunner.And("\'Teşekkür Ederiz.\' yazısının geldiği görülür", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

