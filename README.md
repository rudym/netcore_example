# Welcome

This prototype is for demonstrating purposes only. It shows some patterns of using Bootstrap, jQuery, AJAX at front-end and RESTful API service, plus DTO, plus dependency injections throughout all application, plus repository pattern and Entity Framework 7 (with TPH inheritance just to make it crazier) for SQLite at back-end.  All using ASP.NET 5 .NET Core with help of Visual Studio Code on OS X El Capitan.

OK, now as it sounds scary enough, I can move forward.

* * * 

## Starting the engine

> Make sure you installed the framework [.NET Core] (http://docs.asp.net/en/latest/getting-started/index.html)

* Restore all packages  
`dnu restore`

* Create the local database and seed starter data  
`dnx ef database update`

* Build the sources  
`dnu build`

* Start the app  
`dnx web`
