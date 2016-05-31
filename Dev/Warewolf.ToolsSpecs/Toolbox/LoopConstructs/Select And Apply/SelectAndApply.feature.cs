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
namespace Warewolf.ToolsSpecs.Toolbox.LoopConstructs.SelectAndApply
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SelectAndApplyFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SelectAndApply.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SelectAndApply", "In order to execute select and apply\r\nAs a Warewolf user\r\nI want to add a tool th" +
                    "at will allow me to construct and execute tools using an alias within the select" +
                    " and apply", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "SelectAndApply")))
            {
                Warewolf.ToolsSpecs.Toolbox.LoopConstructs.SelectAndApply.SelectAndApplyFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply tool with a mocked test tool with a json object array of" +
            " json objects")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyToolWithAMockedTestToolWithAJsonObjectArrayOfJsonObjects()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply tool with a mocked test tool with a json object array of" +
                    " json objects", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table1.AddRow(new string[] {
                        "[[Score().Value]]",
                        "0.3"});
            table1.AddRow(new string[] {
                        "[[Score().Value]]",
                        "0.45"});
            table1.AddRow(new string[] {
                        "[[Score().Value]]",
                        "0.12"});
#line 7
 testRunner.Given("There is a complexobject in the datalist with this shape", ((string)(null)), table1, "Given ");
#line 12
 testRunner.And("Alias is \"[[Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("Datasource is \"[[Score(*).Value]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("the underlying dropped activity is a(n) \"SelectAndApplyTestTool\" tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("the selectAndApply executes 3 times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[Score(*).Value]]"});
            table2.AddRow(new string[] {
                        "As = [[Score]]"});
#line 18
 testRunner.And("the debug inputs as", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply tool with a Number Format tool with a json object array " +
            "of json objects")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyToolWithANumberFormatToolWithAJsonObjectArrayOfJsonObjects()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply tool with a Number Format tool with a json object array " +
                    "of json objects", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table3.AddRow(new string[] {
                        "[[Score().Value]]",
                        "0.3"});
            table3.AddRow(new string[] {
                        "[[Score().Value]]",
                        "0.45"});
            table3.AddRow(new string[] {
                        "[[Score().Value]]",
                        "0.12"});
#line 23
 testRunner.Given("There is a complexobject in the datalist with this shape", ((string)(null)), table3, "Given ");
#line 28
 testRunner.And("Alias is \"[[Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("Datasource is \"[[Score(*).Value]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show",
                        "Result"});
            table4.AddRow(new string[] {
                        "[[Score]]",
                        "Up",
                        "2",
                        "3",
                        "[[Score]]"});
#line 30
 testRunner.And("I use a Number Format tool configured as", ((string)(null)), table4, "And ");
#line 33
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.And("\"[[Score(1).Value]]\" has a value of \"0.300\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("\"[[Score(2).Value]]\" has a value of \"0.450\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("\"[[Score(3).Value]]\" has a value of \"0.120\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply tool with a Number Format tool with a json object array " +
            "of literals")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyToolWithANumberFormatToolWithAJsonObjectArrayOfLiterals()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply tool with a Number Format tool with a json object array " +
                    "of literals", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table5.AddRow(new string[] {
                        "[[Score()]]",
                        "0.3"});
            table5.AddRow(new string[] {
                        "[[Score()]]",
                        "0.45"});
            table5.AddRow(new string[] {
                        "[[Score()]]",
                        "0.12"});
#line 40
 testRunner.Given("There is a complexobject in the datalist with this shape", ((string)(null)), table5, "Given ");
#line 45
 testRunner.And("Alias is \"[[Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("Datasource is \"[[Score(*)]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show",
                        "Result"});
            table6.AddRow(new string[] {
                        "[[Score]]",
                        "Up",
                        "2",
                        "3",
                        "[[Score]]"});
#line 47
 testRunner.And("I use a Number Format tool configured as", ((string)(null)), table6, "And ");
#line 50
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.And("\"[[Score(1)]]\" has a value of \"0.300\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("\"[[Score(2)]]\" has a value of \"0.450\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("\"[[Score(3)]]\" has a value of \"0.120\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply tool with a Number Format tool with a json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyToolWithANumberFormatToolWithAJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply tool with a Number Format tool with a json object", ((string[])(null)));
#line 56
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table7.AddRow(new string[] {
                        "[[Person.Score]]",
                        "0.3"});
#line 57
 testRunner.Given("There is a complexobject in the datalist with this shape", ((string)(null)), table7, "Given ");
#line 60
 testRunner.And("Alias is \"[[Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("Datasource is \"[[Person.Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show",
                        "Result"});
            table8.AddRow(new string[] {
                        "[[Score]]",
                        "Up",
                        "2",
                        "3",
                        "[[Score]]"});
#line 62
 testRunner.And("I use a Number Format tool configured as", ((string)(null)), table8, "And ");
#line 65
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply tool with a Number Format tool with a json object litera" +
            "l")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyToolWithANumberFormatToolWithAJsonObjectLiteral()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply tool with a Number Format tool with a json object litera" +
                    "l", ((string[])(null)));
#line 68
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table9.AddRow(new string[] {
                        "[[Person.Score.Value]]",
                        "0.3"});
#line 69
 testRunner.Given("There is a complexobject in the datalist with this shape", ((string)(null)), table9, "Given ");
#line 72
 testRunner.And("Alias is \"[[Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("Datasource is \"[[Person.Score.Value]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show",
                        "Result"});
            table10.AddRow(new string[] {
                        "[[Score]]",
                        "Up",
                        "2",
                        "3",
                        "[[Score]]"});
#line 74
 testRunner.And("I use a Number Format tool configured as", ((string)(null)), table10, "And ");
#line 77
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply tool with a Number Format tool with json object array wi" +
            "thin a json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyToolWithANumberFormatToolWithJsonObjectArrayWithinAJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply tool with a Number Format tool with json object array wi" +
                    "thin a json object", ((string[])(null)));
#line 80
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table11.AddRow(new string[] {
                        "[[Person.Score()]]",
                        "0.3"});
            table11.AddRow(new string[] {
                        "[[Person.Score()]]",
                        "0.45"});
            table11.AddRow(new string[] {
                        "[[Person.Score()]]",
                        "0.12"});
#line 81
 testRunner.Given("There is a complexobject in the datalist with this shape", ((string)(null)), table11, "Given ");
#line 86
 testRunner.And("Alias is \"[[Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("Datasource is \"[[Person.Score(*)]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show",
                        "Result"});
            table12.AddRow(new string[] {
                        "[[Score]]",
                        "Up",
                        "2",
                        "3",
                        "[[Score]]"});
#line 88
 testRunner.And("I use a Number Format tool configured as", ((string)(null)), table12, "And ");
#line 91
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.Then("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.And("\"[[Person.Score(1)]]\" has a value of \"0.300\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("\"[[Person.Score(2)]]\" has a value of \"0.450\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("\"[[Person.Score(3)]]\" has a value of \"0.120\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply over a tool using a recordset with 3 rows")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyOverAToolUsingARecordsetWith3Rows()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply over a tool using a recordset with 3 rows", ((string[])(null)));
#line 97
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table13.AddRow(new string[] {
                        "[[rs().field]]",
                        "1"});
            table13.AddRow(new string[] {
                        "[[rs().field]]",
                        "2"});
            table13.AddRow(new string[] {
                        "[[rs().field]]",
                        "3"});
#line 98
 testRunner.Given("There is a recordset in the datalist with this shape", ((string)(null)), table13, "Given ");
#line 103
 testRunner.And("Alias is \"[[rs]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("Datasource is \"[[rs(*).field]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("the underlying dropped activity is a(n) \"SelectAndApplyTestTool\" tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.Then("the selectAndApply executes 3 times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[rs(*).field]]"});
            table14.AddRow(new string[] {
                        "As = [[rs]]"});
#line 109
 testRunner.And("the debug inputs as", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply over a tool using a recordset with 4 rows")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyOverAToolUsingARecordsetWith4Rows()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply over a tool using a recordset with 4 rows", ((string[])(null)));
#line 113
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table15.AddRow(new string[] {
                        "[[rs().field]]",
                        "1"});
            table15.AddRow(new string[] {
                        "[[rs().field]]",
                        "2"});
            table15.AddRow(new string[] {
                        "[[rs().field]]",
                        "3"});
            table15.AddRow(new string[] {
                        "[[rs().field]]",
                        "6"});
#line 114
 testRunner.Given("There is a recordset in the datalist with this shape", ((string)(null)), table15, "Given ");
#line 120
 testRunner.And("Alias is \"[[rs]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("Datasource is \"[[rs(*).field]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("the underlying dropped activity is a(n) \"SelectAndApplyTestTool\" tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.Then("the selectAndApply executes 4 times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "[[rs(*).field]]"});
            table16.AddRow(new string[] {
                        "As = [[rs]]"});
#line 126
 testRunner.And("the debug inputs as", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply over an activity using a recordset with 3 rows")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyOverAnActivityUsingARecordsetWith3Rows()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply over an activity using a recordset with 3 rows", ((string[])(null)));
#line 130
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table17.AddRow(new string[] {
                        "[[rs().field]]",
                        "1"});
            table17.AddRow(new string[] {
                        "[[rs().field]]",
                        "2"});
            table17.AddRow(new string[] {
                        "[[rs().field]]",
                        "3"});
#line 131
 testRunner.Given("There is a recordset in the datalist with this shape", ((string)(null)), table17, "Given ");
#line 136
 testRunner.And("Alias is \"[[rs]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("Datasource is \"[[rs(*).field]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("I Map the input recordset \"[[rs(*).field]]\" to \"[[test(*).data]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And("I Map the output recordset \"[[test(*).data]]\" to \"[[res(*).data]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And("the underlying dropped activity is a(n) \"Activity\" tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "index"});
            table18.AddRow(new string[] {
                        "1"});
            table18.AddRow(new string[] {
                        "2"});
            table18.AddRow(new string[] {
                        "3"});
#line 142
 testRunner.Then("The mapping uses the following indexes", ((string)(null)), table18, "Then ");
#line 147
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply over an activity using a recordset with 4 rows")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyOverAnActivityUsingARecordsetWith4Rows()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply over an activity using a recordset with 4 rows", ((string[])(null)));
#line 149
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table19.AddRow(new string[] {
                        "[[rs().field]]",
                        "1"});
            table19.AddRow(new string[] {
                        "[[rs().field]]",
                        "2"});
            table19.AddRow(new string[] {
                        "[[rs().field]]",
                        "3"});
            table19.AddRow(new string[] {
                        "[[rs().field]]",
                        "6"});
#line 150
 testRunner.Given("There is a recordset in the datalist with this shape", ((string)(null)), table19, "Given ");
#line 156
 testRunner.And("Alias is \"[[rs]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And("Datasource is \"[[rs(*).field]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("I Map the input recordset \"[[rs(*).field]]\" to \"[[test(*).data]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.And("I Map the output recordset \"[[test(*).data]]\" to \"[[res(*).data]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.And("the underlying dropped activity is a(n) \"Activity\" tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "index"});
            table20.AddRow(new string[] {
                        "1"});
            table20.AddRow(new string[] {
                        "2"});
            table20.AddRow(new string[] {
                        "3"});
            table20.AddRow(new string[] {
                        "4"});
#line 162
 testRunner.Then("The mapping uses the following indexes", ((string)(null)), table20, "Then ");
#line 168
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply over a tool null alias")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyOverAToolNullAlias()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply over a tool null alias", ((string[])(null)));
#line 170
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table21.AddRow(new string[] {
                        "[[rs().field]]",
                        "1"});
#line 171
 testRunner.Given("There is a recordset in the datalist with this shape", ((string)(null)), table21, "Given ");
#line 174
 testRunner.And("Alias is \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
 testRunner.And("Datasource is \"[[rs(*).field]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.And("the underlying dropped activity is a(n) \"SelectAndApplyTestTool\" tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 178
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply over a tool null datasource")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyOverAToolNullDatasource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply over a tool null datasource", ((string[])(null)));
#line 180
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table22.AddRow(new string[] {
                        "[[rs().field]]",
                        "1"});
#line 181
 testRunner.Given("There is a recordset in the datalist with this shape", ((string)(null)), table22, "Given ");
#line 184
 testRunner.And("Alias is \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
 testRunner.And("Datasource is \"[[rs(*).field]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 186
 testRunner.And("the underlying dropped activity is a(n) \"SelectAndApplyTestTool\" tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 188
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute a selectAndApply over a tool null value")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        public virtual void ExecuteASelectAndApplyOverAToolNullValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute a selectAndApply over a tool null value", ((string[])(null)));
#line 190
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table23.AddRow(new string[] {
                        "[[rs().field]]",
                        "NULL"});
#line 191
 testRunner.Given("There is a recordset in the datalist with this shape", ((string)(null)), table23, "Given ");
#line 194
 testRunner.And("Alias is \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
 testRunner.And("Datasource is \"[[rs(*).field]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
 testRunner.And("the underlying dropped activity is a(n) \"SelectAndApplyTestTool\" tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 198
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Number Format tool with complext object multi array")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SelectAndApply")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void NumberFormatToolWithComplextObjectMultiArray()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Number Format tool with complext object multi array", new string[] {
                        "ignore"});
#line 202
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "rs",
                        "value"});
            table24.AddRow(new string[] {
                        "[[Person().Score()]]",
                        "0.3"});
            table24.AddRow(new string[] {
                        "[[Person().Score()]]",
                        "0.45"});
            table24.AddRow(new string[] {
                        "[[Person().Score()]]",
                        "0.12"});
#line 203
 testRunner.Given("There is a complexobject in the datalist with this shape", ((string)(null)), table24, "Given ");
#line 208
 testRunner.And("Alias is \"[[Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 209
 testRunner.And("Datasource is \"[[Person(*).Score(*)]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Number",
                        "Rounding",
                        "Rounding Value",
                        "Decimals to show",
                        "Result"});
            table25.AddRow(new string[] {
                        "[[Score]]",
                        "Up",
                        "2",
                        "3",
                        "[[Score]]"});
#line 210
 testRunner.And("I use a Number Format tool configured as", ((string)(null)), table25, "And ");
#line 213
 testRunner.When("the selectAndApply tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 214
 testRunner.Then("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 215
 testRunner.And("\"[[Person(1).Score(1)]]\" has a value of \"0.300\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 216
 testRunner.And("\"[[Person(2).Score(2)]]\" has a value of \"0.450\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 217
 testRunner.And("\"[[Person(3).Score(3)]]\" has a value of \"0.120\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion