///////////////////////////////////////////////////////////////////////////////
// Tools and Addins
///////////////////////////////////////////////////////////////////////////////
#addin nuget:?package=Cake.Figlet

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Debug");

///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////

Setup(ctx =>
{
	// Executed BEFORE the first task.
	Information(Figlet("Appy Christmas"));
});

Teardown(ctx =>
{
	// Executed AFTER the last task.
	Information("Finished running tasks.");
});

///////////////////////////////////////////////////////////////////////////////
// USER TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(ctx => {
        CleanDirectories("./src/**/bin/" + configuration);
        CleanDirectories("./src/**/obj/" + configuration);
});

Task("Restore")
    .IsDependentOn("Clean")
    .Does(ctx => {
        DotNetCoreRestore("./src/ProductApi/ProductApi.csproj", new DotNetCoreRestoreSettings {
            Sources = new [] { "https://api.nuget.org/v3/index.json" }
        });
});

Task("Build")
    .IsDependentOn("Restore")
    .Does(ctx => {
        DotNetCoreBuild("./src/ProductApi/ProductApi.csproj", new DotNetCoreBuildSettings {
            Framework = "netcoreapp1.1",
            Configuration = configuration
        });
});

Task("Publish")
    .IsDependentOn("Build")
    .Does(ctx => {
        var settings = new DotNetCorePublishSettings
        {
            Framework = "netcoreapp1.1",
            Configuration = "Release",
            OutputDirectory = "./artifacts/"
        };
        DotNetCorePublish("./src/", settings);
});

Task("Run")
    .IsDependentOn("Build")
    .Does(() => {
        DotNetCoreRun("./src/ProductApi/ProductApi.csproj");
});

Task("AppVeyor")
    .IsDependentOn("Publish");

Task("Default")
	.IsDependentOn("Run");

RunTarget(target);