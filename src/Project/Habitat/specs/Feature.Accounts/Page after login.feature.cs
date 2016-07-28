﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "UI")]
    public partial class PageAfterLoginFeature : Xunit.IClassFixture<PageAfterLoginFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Page after login.feature"
#line hidden
        
        public PageAfterLoginFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Page after login", null, ProgrammingLanguage.CSharp, new string[] {
                        "UI"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(PageAfterLoginFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Accounts_Page after login_UC1_Define custom page")]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC1_Define custom page")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_PageAfterLogin_UC1_DefineCustomPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC1_Define custom page", new string[] {
                        "Ready"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table1.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 7
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table2.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "After Login Page",
                        "/sitecore/content/Habitat/Home/Modules/Feature/Demo"});
#line 10
 testRunner.And("Value set to item field", ((string)(null)), table2, "And ");
#line 13
 testRunner.When("Actor opens Habitat website on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table3.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 14
 testRunner.And("Actor enteres following data into Login page fields", ((string)(null)), table3, "And ");
#line 17
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("Page URL ends on /Demo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.And("Demo title presents on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Accounts_Page after login_UC2_Define custom page_defined page does not exists")]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC2_Define custom page_defined page does not exists")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_PageAfterLogin_UC2_DefineCustomPage_DefinedPageDoesNotExists()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC2_Define custom page_defined page does not exists", new string[] {
                        "Ready"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table4.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 25
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table5.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "After Login Page",
                        "/sitecore/content/Habitat/Home/KOV"});
#line 28
 testRunner.And("Value set to item field", ((string)(null)), table5, "And ");
#line 31
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table6.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 32
 testRunner.When("Actor enteres following data into Login page fields", ((string)(null)), table6, "When ");
#line 35
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.Then("Page URL not ends on /KOV", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.And("Habitat Main page presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Accounts_Page after login_UC3_Define custom page_empty value")]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC3_Define custom page_empty value")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_PageAfterLogin_UC3_DefineCustomPage_EmptyValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC3_Define custom page_empty value", new string[] {
                        "Ready"});
#line 40
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table7.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 41
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table8.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "After Login Page",
                        ""});
#line 44
 testRunner.And("Value set to item field", ((string)(null)), table8, "And ");
#line 47
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table9.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 48
 testRunner.When("Actor enteres following data into Login page fields", ((string)(null)), table9, "When ");
#line 51
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.Then("Habitat Main page presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Accounts_Page after login_UC4_After login page for new registered user")]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC4_After login page for new registered user")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_PageAfterLogin_UC4_AfterLoginPageForNewRegisteredUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC4_After login page for new registered user", new string[] {
                        "Ready"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table10.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "After Login Page",
                        "/sitecore/content/Habitat/Home/Modules/Feature/News"});
#line 57
 testRunner.Given("Value set to item field", ((string)(null)), table10, "Given ");
#line 60
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table11.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 61
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table11, "When ");
#line 64
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then("Page URL ends on /News", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.And("News title presents on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Accounts_Page after login_UC5_Login pop up returns user to default page")]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC5_Login pop up returns user to default page")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_PageAfterLogin_UC5_LoginPopUpReturnsUserToDefaultPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC5_Login pop up returns user to default page", new string[] {
                        "Ready"});
#line 70
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table12.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "After Login Page",
                        "/sitecore/content/Habitat/Home/Register"});
#line 71
 testRunner.Given("Value set to item field", ((string)(null)), table12, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table13.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 74
 testRunner.And("User is registered in Habitat and logged out", ((string)(null)), table13, "And ");
#line 77
 testRunner.And("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table14.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 78
 testRunner.When("Actor enteres following data into Login form fields", ((string)(null)), table14, "When ");
#line 81
 testRunner.And("Actor clicks Login button on User form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("Habitat Main page presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Accounts_Page after login_UC6_Double redirect logic for Register page")]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC6_Double redirect logic for Register page")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_PageAfterLogin_UC6_DoubleRedirectLogicForRegisterPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC6_Double redirect logic for Register page", new string[] {
                        "Ready"});
#line 85
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table15.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "After Login Page",
                        "/sitecore/content/Habitat/Home/Register"});
#line 86
 testRunner.Given("Value set to item field", ((string)(null)), table15, "Given ");
#line 89
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table16.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 90
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table16, "When ");
#line 93
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("Habitat website is opened on Main Page /en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Accounts_Page after login_UC7_Double redirect logic for Accounts page")]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC7_Double redirect logic for Accounts page")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_PageAfterLogin_UC7_DoubleRedirectLogicForAccountsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC7_Double redirect logic for Accounts page", new string[] {
                        "Ready"});
#line 98
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table17.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "After Login Page",
                        "/sitecore/content/Habitat/Home/Modules/Feature/Accounts"});
#line 99
 testRunner.Given("Value set to item field", ((string)(null)), table17, "Given ");
#line 102
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table18.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 103
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table18, "When ");
#line 106
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.Then("Habitat website is opened on Main Page /en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PageAfterLoginFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PageAfterLoginFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion