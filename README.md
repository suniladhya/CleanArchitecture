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

dotnet sln remove CleanArch.UI.Mvc
dotnet sln add CleanArch.UI.Mvc -s Presentation

dotnet new classlib CleanArch.Domain -o CleanArch.Domain
dotnet sln add .\CleanArch.Domain\CleanArch.Domain.csproj -s Domain

dotnet new classlib -n CleanArch.Infra.Data -o CleanArch.Infra/Data

create Context class in above step


C:\Users\sadhya\Documents\Project\CleanArchitecture\CleanArch.Infra\Data>
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.4

CTOR :public UniversityDBContext(DbContextOptions options):base(options)

{
  "ConnectionStrings": {
    "UniversityIdentityDBConnection": "Server=(localdb)\\mssqllocaldb;Database=UniversityIdentityDB;Trusted_Connection=True;MultipleActiveResultSets=true",
    "UniversityDBConnection": "Server=(localdb)\\mssqllocaldb;Database=UniversityDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  },

dotnet ef migrations add initialcreate --context UniversityDBContext -p .\..\CleanArch.Infra\Data\CleanArch.Infra.Data.csproj

dotnet ef database update
dotnet ef database update --context UniversityDBContext -p .\..\CleanArch.Infra\Data\CleanArch.Infra.Data.csproj



