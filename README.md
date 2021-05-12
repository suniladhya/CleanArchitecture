# CleanArchitecture

dotnet new -l
dotnet new sln
--dotnet new mvc -o CleanArch.UI.Mvc
[ref.](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)
--dotnet sln add ./CleanArch.UI.Mvc/CleanArch.UI.Mvc.csproj  -s CleanArch.UI.Mvc
## create a MVC Solution
dotnet new mvc --auth Individual --use-local-db -o CleanArch.UI.Mvc

dotnet sln add CleanArch.UI.Mvc

change connection String:
 "ConnectionStrings": {
    "UniversityIdentityDBConnection": "Server=(localdb)\\mssqllocaldb;Database=UniversityIdentityDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
Modify Startup.cs

Tools -> Package Maager Console
Project\CleanArchitecture\CleanArch.UI.Mvc>
dotnet ef migrations add initialcreate --context ApplicationDbContext

dotnet new gitignore
