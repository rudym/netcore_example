# Welcome

This prototype is for demonstrating purposes only. It shows some patterns of using Bootstrap, jQuery, AJAX at front-end and RESTful API service, plus DTO, plus dependency injections throughout the all all application, plus repository pattern and Entity Framework 7 (with TPH inheritance) for SQLite at back-end. Framework used: ASP.NET 5 .NET Core, IDE used: Visual Studio Code on OS X El Capitan.

OK, now when it sounds scary enough, I can move forward.

* * * 

## Starting the engine

> Make sure you installed the framework [.NET Core](http://docs.asp.net/en/latest/getting-started/index.html)
> Here is a article worth reading [DNVM, DNX, and DNU - Understanding the ASP.NET 5 Runtime Options](http://www.codeproject.com/Articles/1005145/DNVM-DNX-and-DNU-Understanding-the-ASP-NET-Runtime)

* Restore all packages  
`dnu restore`

* Create the local database and seed starter data  
`dnx ef database update`

* Build the sources  
`dnu build`

* Start the app  
`dnx web`
