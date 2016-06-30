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
namespace Warewolf.AcceptanceTesting.Deploy
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DeployTabFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DeployTab.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DeployTab", "\tIn order to Deploy resource.\r\n\tAs a warewolf user\r\n\tI want to Deploy aresource f" +
                    "rom one server to another server.", ProgrammingLanguage.CSharp, new string[] {
                        "DeployTab"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "DeployTab")))
            {
                Warewolf.AcceptanceTesting.Deploy.DeployTabFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy Tab", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
  testRunner.And("selected Destination Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
  testRunner.Then("\"Deploy\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
  testRunner.And("the validation message is \"Source and Destination cannot be the same.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy button is enabling when selecting resource in source side")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployButtonIsEnablingWhenSelectingResourceInSourceSide()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy button is enabling when selecting resource in source side", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
  testRunner.When("I select \"Examples\\Utility - Date and Time\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
  testRunner.Then("\"Deploy\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
  testRunner.When("\"Remote\" is Disconnected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
  testRunner.Then("\"Deploy\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy is successfull")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployIsSuccessfull()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy is successfull", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
  testRunner.When("I select \"Examples\\Utility - Date and Time\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
  testRunner.And("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
  testRunner.And("the Deploy validation message is \"1 Resource Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conflicting resources on Source and Destination server")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void ConflictingResourcesOnSourceAndDestinationServer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conflicting resources on Source and Destination server", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 58
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
  testRunner.And("I select \"Examples\\bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
  testRunner.When("I click OK on Resource exists in the destination server popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
  testRunner.And("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Source Resource",
                        "Destination Resource"});
            table1.AddRow(new string[] {
                        "1",
                        "bob",
                        "DifferentNameSameID"});
#line 66
  testRunner.Then("Resource exists in the destination server popup is shown", ((string)(null)), table1, "Then ");
#line 69
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
  testRunner.And("the Deploy validation message is \"1 Resource Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conflicting resources on Source and Destination server deploy is not successful")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void ConflictingResourcesOnSourceAndDestinationServerDeployIsNotSuccessful()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conflicting resources on Source and Destination server deploy is not successful", ((string[])(null)));
#line 72
this.ScenarioSetup(scenarioInfo);
#line 73
      testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
  testRunner.And("I select \"Examples\\bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
  testRunner.When("I click Cancel on Resource exists in the destination server popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
  testRunner.Then("deploy is not successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploying a connector with a source")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployingAConnectorWithASource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploying a connector with a source", ((string[])(null)));
#line 82
this.ScenarioSetup(scenarioInfo);
#line 83
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 84
   testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
  testRunner.When("I select \"DB Service\\FetchPlayers\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
  testRunner.Then("\"Deploy\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
  testRunner.And("\"Select All Dependencies\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
  testRunner.When("I Select All Dependecies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
  testRunner.Then("\"sqlServers\\DemoDB\" from Source Server is \"Selected\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
  testRunner.And("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
  testRunner.And("the Deploy validation message is \"2 Resources Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Filtering and clearing filter on source side")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void FilteringAndClearingFilterOnSourceSide()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filtering and clearing filter on source side", ((string[])(null)));
#line 97
this.ScenarioSetup(scenarioInfo);
#line 98
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 99
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
     testRunner.When("I type \"Date and Time\" in Source Server filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
  testRunner.Then("visibility of \"Examples\\Utility - Date and Time\" from Source Server is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
  testRunner.And("visibility of \"Examples\\Data - Data - Data Split\" from Source Server is \"Not Visi" +
                    "ble\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
  testRunner.And("visibility of \"Examples\\Control Flow - Switch\" from Source Server is \"Not Visible" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
  testRunner.And("visibility of \"Examples\\Control Flow - Sequence\" from Source Server is \"Not Visib" +
                    "le\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
  testRunner.And("visibility of \"Examples\\File and Folder - Copy\" from Source Server is \"Not Visibl" +
                    "e\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
  testRunner.And("visibility of \"Examples\\File and Folder - Create\" from Source Server is \"Not Visi" +
                    "ble\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
  testRunner.When("I type \"\" in Source Server filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
  testRunner.Then("visibility of \"Examples\\Utility - Date and Time\" from Source Server is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
  testRunner.And("visibility of \"Examples\\Data - Data - Data Split\" from Source Server is \"Visible\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
  testRunner.And("visibility of \"Examples\\Control Flow - Switch\" from Source Server is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
  testRunner.And("visibility of \"Examples\\Control Flow - Sequence\" from Source Server is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
  testRunner.And("visibility of \"Examples\\File and Folder - Copy\" from Source Server is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
  testRunner.And("visibility of \"Examples\\File and Folder - Create\" from Source Server is \"Visible\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploying with filter enabled")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployingWithFilterEnabled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploying with filter enabled", ((string[])(null)));
#line 115
this.ScenarioSetup(scenarioInfo);
#line 116
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 117
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
     testRunner.When("I type \"Date and Time\" in Source Server filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
  testRunner.Then("visibility of \"Examples\\Utility - Date and Time\" from Source Server is \"Visible\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
  testRunner.And("visibility of \"Examples\\Data - Data - Data Split\" from Source Server is \"Not Visi" +
                    "ble\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
  testRunner.And("visibility of \"Examples\\Control Flow - Switch\" from Source Server is \"Not Visible" +
                    "\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
  testRunner.And("visibility of \"Examples\\Control Flow - Sequence\" from Source Server is \"Not Visib" +
                    "le\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
  testRunner.And("visibility of \"Examples\\File and Folder - Copy\" from Source Server is \"Not Visibl" +
                    "e\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
  testRunner.And("visibility of \"Examples\\File and Folder - Create\" from Source Server is \"Not Visi" +
                    "ble\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
  testRunner.When("I select \"Examples\\Utility - Date and Time\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
  testRunner.When("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 130
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
  testRunner.And("the Deploy validation message is \"1 Resource Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Selected for deploy items type is showing on deploy tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void SelectedForDeployItemsTypeIsShowingOnDeployTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Selected for deploy items type is showing on deploy tab", ((string[])(null)));
#line 133
this.ScenarioSetup(scenarioInfo);
#line 134
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 135
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
  testRunner.When("I select \"Examples\\Utility - Date and Time\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
  testRunner.And("I select \"DB Service\\FetchPlayers\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
  testRunner.And("I select \"sqlServers\\DemoDB\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
  testRunner.Then("Services is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
  testRunner.And("Sources is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy Summary is showing new and overiding resources")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeploySummaryIsShowingNewAndOveridingResources()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy Summary is showing new and overiding resources", ((string[])(null)));
#line 147
this.ScenarioSetup(scenarioInfo);
#line 148
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 149
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 152
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
  testRunner.And("I select \"Examples\\bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
  testRunner.Then("New Resource is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
  testRunner.And("Override is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
  testRunner.When("I select \"DB Service\\FetchPlayers\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 157
  testRunner.Then("New Resource is \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
  testRunner.And("Override is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
  testRunner.When("I Unselect \"Examples\\bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 160
  testRunner.Then("Override is \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy is enabled when I change server after validation thrown")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployIsEnabledWhenIChangeServerAfterValidationThrown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy is enabled when I change server after validation thrown", ((string[])(null)));
#line 162
this.ScenarioSetup(scenarioInfo);
#line 163
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 164
   testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
     testRunner.When("selected Destination Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 167
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
  testRunner.When("I select \"Examples\\Utility - Date and Time\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 169
  testRunner.Then("\"Deploy\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 170
  testRunner.And("the validation message is \"Source and Destination cannot be the same.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 172
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
  testRunner.Then("\"Deploy\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 174
   testRunner.And("the validation message is \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploying items from one server to the next with the same name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployingItemsFromOneServerToTheNextWithTheSameName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploying items from one server to the next with the same name", ((string[])(null)));
#line 179
this.ScenarioSetup(scenarioInfo);
#line 180
  testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 181
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 184
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
  testRunner.And("I select \"Examples\\bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 186
  testRunner.When("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 187
  testRunner.Then("the User is prompted to \"Rename or Delete\" one of the resources", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Warning message no longer appears")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void WarningMessageNoLongerAppears()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Warning message no longer appears", ((string[])(null)));
#line 190
this.ScenarioSetup(scenarioInfo);
#line 191
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 192
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 193
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 194
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 195
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
  testRunner.And("I select \"Examples\\bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
  testRunner.When("I click OK on Resource exists in the destination server popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 198
  testRunner.And("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 200
  testRunner.And("the Deploy validation message is \"1 Resource Deployed Successfully.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploying to an Older server version")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployingToAnOlderServerVersion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploying to an Older server version", ((string[])(null)));
#line 203
this.ScenarioSetup(scenarioInfo);
#line 204
 testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 205
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 207
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 208
     testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 209
  testRunner.And("destination Server Version is \"0.0.0.1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 210
  testRunner.And("I select \"Utility - Date and Time\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 211
  testRunner.When("I deploy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 212
  testRunner.Then("a warning message appears \"Deploying to an older server version could result in r" +
                    "esources not working on destination server\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 213
  testRunner.Then("deploy is successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Select All resources to deploy")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void SelectAllResourcesToDeploy()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select All resources to deploy", ((string[])(null)));
#line 216
this.ScenarioSetup(scenarioInfo);
#line 217
    testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 218
 testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 219
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 220
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 221
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 222
 testRunner.And("I check \"localhost\" on Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 223
 testRunner.Then("\"All\" the resources are checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 224
 testRunner.And("\"Deploy\" is \"Enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy Based on permission Deploy To")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployBasedOnPermissionDeployTo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy Based on permission Deploy To", ((string[])(null)));
#line 226
this.ScenarioSetup(scenarioInfo);
#line 227
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 228
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 229
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 230
  testRunner.And("I select \"Examples\\bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 231
     testRunner.And("I cannot deploy to destination", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 232
  testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 233
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 234
  testRunner.Then("\"Deploy\" is \"Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 235
  testRunner.And("the validation message is \"Destination server permission Deploy To not allowed.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Deploy Based on permission Deploy From")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeployTab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DeployTab")]
        public virtual void DeployBasedOnPermissionDeployFrom()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deploy Based on permission Deploy From", ((string[])(null)));
#line 237
this.ScenarioSetup(scenarioInfo);
#line 238
     testRunner.Given("I have deploy tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 239
  testRunner.And("I cannot deploy from source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 240
  testRunner.And("selected Source Server is \"localhost\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 241
  testRunner.And("source is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 242
  testRunner.And("I select \"Examples\\bob\" from Source Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 243
     testRunner.When("selected Destination Server is \"Remote\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 244
  testRunner.And("destination is connected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
