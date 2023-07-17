# ticketManagementPractice
Internal project for Student's Practice 2023

# How to install

You need a version of [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) installed.

In [`appsettings.Development.json`](https://github.com/ciprianilie/ticketManagementPractice/blob/main/TicketManagementSystem/TMS.Api/appsettings.Development.json) the section `ConnectionStrings` contains the connection string to an instance of a SQL Server. The data source needs to be updated with your own instance.

You need the latest version of [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) installed.
Once installed, go to upper menu: `Tools/NuGet Package Manager/Package Manager Console`.
In console, run `update-database`. This should create from scracth the DB, having some tables pre-populated with data.

Once finished, hit the full-green arrow button (named as TMS.Api) below the upper menu. This should start the app.
A browser tab should open with some Swagger specs that you can test.

[`launchSettings.json`](https://github.com/ciprianilie/ticketManagementPractice/blob/main/TicketManagementSystem/TMS.Api/Properties/launchSettings.json) holds some startup props. 
Under `profile` section, feel free to change any port in `applicationUrl` that is relevant to you, not blocked by any other app: `applicationUrl`: `https://localhost:7260;http://localhost:5264`,

Feel free to call the API accordingly.
