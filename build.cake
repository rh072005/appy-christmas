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
        DotNetCoreRestore("./", new DotNetCoreRestoreSettings {
            Sources = new [] { "https://api.nuget.org/v3/index.json" },
            Verbosity = DotNetCoreRestoreVerbosity.Warning
        });
});

Task("Build")
    .IsDependentOn("Restore")
    .Does(ctx => {
        var projects = GetFiles("./**/project.json");
        foreach(var project in projects)
        {
            DotNetCoreBuild(project.GetDirectory().FullPath, new DotNetCoreBuildSettings {
                Configuration = configuration
            });
        }
});

Task("Run")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetCoreRun("./src/ProductApi");
});

Task("AppVeyor")
    .IsDependentOn("Build")

Task("Default")
	.IsDependentOn("Run");

RunTarget(target);