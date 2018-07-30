# SpecFlow-example
QTM4J Automation Sample Projects.


# SpecFlow
This is sample solution in C# .net. It shows how to generate spec flow result file for given spec flow feature file.

Step 1: Import the given Solution.
Step 2: Open Text Explorer in visual studio by Test->Windows->Test Explorer
Step 3: Execute command in visual studio terminal -> Install-Package NUnitTestAdapter.
	Ignore this step if you have already installed NUnitTestAdapter.
Step 4: Select Run All. 
Step 5: Your result file will be generated at 
{solution_directory} \SpecResults.ApprovalTestSuite\approvals\SpecResults.Json.JsonReporter\
Output.json.
Now, you can Modify Calculator class in CalculatorLibrary in Test, TestSuit.features and Steps.Definitions.cs in SpecResults.ApprovalTestSuite in Test project to generate result file as per your requirement.

This Project is created by taking reference from
https://github.com/timschlechter/SpecResults

# Specflow_Cucumber

This is sample solution in C# .net. It shows how to generate cucumber result file for given spec flow feature file.

Requirement .Net framework 4.5 minimum to Run this project.
Step 1: Import the given Solution.
Step 2: Open Text Explorer in visual studio by Test->Windows->Test Explorer
Step 3: Select Run All.
Step 4: In visual Studio Console, select show output from Test and open Report File as path given in Console.
Step 5: At the End of Report file path of Result File is given. This is generated cucumber Result file for    given spec flow feature file.

Now, you can Modify Calculator class in Calc, SpecFlowFeature1.feature and CalcSteps.cs in SpecFlow project to generate result file as per your requirement.

This Project is created by taking reference from
http://specflow.org/getting-started/.
To generate report 
https://www.nuget.org/packages/SpecNuts/   and 
https://www.nuget.org/packages/SpecNuts.Json/


