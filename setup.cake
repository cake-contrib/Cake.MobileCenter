#load nuget:?package=Cake.Recipe&version=1.1.1

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context, 
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src",
    title: "Cake.MobileCenter",
    repositoryOwner: "cake-contrib",
    repositoryName: "Cake.MobileCenter",
    appVeyorAccountName: "cakecontrib",
	shouldRunDupFinder: false,
    shouldRunInspectCode: false,
	shouldRunCodecov: false);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(
    context: Context,
    dupFinderExcludePattern: new string[] { BuildParameters.RootDirectoryPath + "/src/Cake.MobileCenter.Tests/*.cs" },
    testCoverageFilter: "+[*]* -[nunit.*]* -[Cake.Core]* -[Cake.Testing]* -[*.Tests]* ",
    testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
    testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs");
Build.RunDotNetCore();
