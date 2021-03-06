///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");


///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Clean")
.Does(() => {   
   CleanDirectories(new [] {
      new DirectoryPath("./temp"), 
      new DirectoryPath("./output")});
});

Task("Restore")
.Does(() => {
   DotNetCoreRestore(".");
});

Task("Build")
.Does(() => {
   var settings = new DotNetCoreBuildSettings 
   {
      NoRestore = true,
      Configuration = configuration
   };
   DotNetCoreBuild(".", settings);
});

Task("Test")
.Does(() => {
   var settings = new DotNetCoreTestSettings
   {
      NoBuild = true,
      Configuration = configuration
   };
   DotNetCoreTest(".", settings);
});

Task("Pack")
.Does(() => {
   var settings = new DotNetCorePackSettings
   {
      NoBuild = true,
      Configuration = configuration
   };
   DotNetCorePack(".", settings);
});

Task("Default")
.IsDependentOn("Restore")
.IsDependentOn("Build")
.IsDependentOn("Test")
.IsDependentOn("Pack");

RunTarget(target);