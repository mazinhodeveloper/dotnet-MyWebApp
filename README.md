# .Net C# Web Application     
.Net C# Web Application Project using .NET ASP.NET SQLServer.        
1 Starting the project on:      
1.1 Windows 11 or Ubuntu 24.04;         
1.2 Visual Studio Communit 2026;     
1.3 SQL Studio Management 22.04;         
1.4 Microsoft SQL Server      
1.5 ASP.NET workload installed in Visual Studio      
     
## Mazinho Developer    
I've been a Web Developer for many years in Brazil. I am learning JavaScript, PHP, Python, Cloud, Git, GitHub, Docker, and more every day.     
https://github.com/mazinhodeveloper     
       
## Fist step:      
.Net C# Web Application. Creating .NET C# Web Applications on Ubuntu 24.04.     
https://github.com/mazinhodeveloper/dotnet-webapp    
    
### .NET CLI tools, SDK, and Runtime    
sudo snap install dotnet --classic    
     
### Listing installed/available components and versions    
dotnet-installer list        
dotnet --version      
dotnet --list-sdks    
    
#### Creating .NET C# web application    
dotnet new mvc -n dotnet-MyWebApp     
cd dotnet-MyWebApp    
dotnet run     
    
##### listening on (Check your terminal)    
http://localhost:xxxx      
http://localhost:5086      
https://localhost:xxxx     
https://localhost:7271     
     
## Second step:    
.Net C# Web Application. Creating .NET C# Web Applications on Ubuntu 24.04. 
      
### .Net C# Web Application
1 Create new project     
2 ASP.NET Core Web API      
   - Framework     
     .NET 8.0 (Long Term Support)      
   - Authentication type      
     None      
     - Configure for HTTPS      
     - Enable OpenAPI support      
     - Use controls   

### SQL Server Database      
Configurations/SQLQuery1.sql     
       
#### Install Entity Framework Core     
In Visual Studio:     
- Tools - NuGet Package Manager - Manage NuGet Packages       
- Install:      
  - Install-Package Microsoft.EntityFrameworkCore.SqlServer       
  - Install-Package Microsoft.EntityFrameworkCore.Tools       
- Or install (Using terminal):       
  - dotnet add package Microsoft.EntityFrameworkCore.SqlServer       
  - dotnet add package Microsoft.EntityFrameworkCore.Tools      
            
##### Run the Project on (Check your terminal)    
Press: F5         
http://localhost:xxxx        
http://localhost:5006        
https://localhost:xxxx/Clientes     
https://localhost:7271/Clientes     
     