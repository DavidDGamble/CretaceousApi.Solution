# _Cretaceous Api_

#### By: _**David Gamble**_

#### _Example of creating your own API_

## Technologies Used

* _C#_
* _.NET 6_
* _ASP.NET Core MVC 6_
* _Entity Framework Core_
* _MySql_
* _MS Tests_

## Description

_This is an example of building your own API using C#/.NET Core MVC.  There are examples of different routes in the controller to querry your MySQL database and process the API requests.  There are also more examples of model validation in the model.  For an example on scaffolding api controllers delete the AnimalsController.cs and follow the scaffolding instructions below.  You must first create your model and database contextn before scaffolding a controller._

## Setup/Installation Requirements

* _Clone the repository to your desktop from: {Enter the repository url here}_
* _Run [$ dotnet run] in the {ProjectName} repository in {ProjectName.Solutions}_
* _create appsettings.json file in ProjectName folder_
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[database_name];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
* _in the CretacuousAip folder run the following commands_
```
dotnet restore
```
```
dotnet ef database update
```
```

* _to run project in developement mode_
```
dotnet watch run
```
* _to run project in production mode_
```
dotnet watch run --launch-profile "production"
```

## Scafollding a controller 

* _in the CretacuousAip folder run the following commands_
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 6.0.0
```
```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 6.0.0
```
```
dotnet aspnet-codegenerator controller -name AnimalsController -async -api -m Animal -dc CretaceousApiContext -outDir Controllers
```
* _^^^^^ The above command invokes the asp-netcodegenerator to do the following ^^^^^_
* _- controller : create a controller_
* _- name AnimalsController : use the name AnimalsController_
* _- async : use asynchronous actions_
* _- api : create the controller for an API_
* _- m Animal : use the Animal model for the controller actions_
* _- dc CretaceousApiContext : create a database context of type CretaceousApiContext_
* _- outDir Controllers : add the new controller file to the Controllers/ directory_

## Known Bugs

* _No known issues_

## License

_Copyright (c) 2022 David Gamble_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
