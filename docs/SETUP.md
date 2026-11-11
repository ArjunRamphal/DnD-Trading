# Development setup

## Requirements

Use a Windows development machine with:

- Visual Studio with the **.NET desktop development** workload. The solution was saved with Visual Studio 2022.
- The [.NET Framework 4.7.2 Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472).
- [SAP Crystal Reports, developer version for Microsoft Visual Studio](https://help.sap.com/docs/SAP_CRYSTAL_REPORTS%2C_DEVELOPER_VERSION_FOR_MICROSOFT_VISUAL_STUDIO), including a runtime compatible with your application's process architecture. The project references CrystalDecisions assemblies with version `13.0.4000.0`.
- SQL Server access to a database compatible with the application's DataSet.

The application targets .NET Framework and Windows Forms. Its reports require the SAP runtime and development integration; the current project has no NuGet package configuration to restore those components automatically.

## Configure the database

From the repository root in PowerShell:

```powershell
Copy-Item 'src\DnD.Trading\ConnectionStrings.example.config' 'src\DnD.Trading\ConnectionStrings.config'
notepad 'src\DnD.Trading\ConnectionStrings.config'
```

Create this file before opening the solution or building. Replace `YOUR_SQL_SERVER` and `YOUR_DATABASE` with the server and database you are authorised to use. The example uses Windows authentication.

For SQL Server authentication, replace the example's connection string with your local values using this format:

```text
Data Source=YOUR_SQL_SERVER;Initial Catalog=YOUR_DATABASE;User ID=YOUR_USERNAME;Password=YOUR_PASSWORD;Encrypt=True;TrustServerCertificate=False
```

Keep the connection name `DnD_Trading.Properties.Settings.WstGrp22ConnectionString` and the provider `System.Data.SqlClient` unchanged. XML-escape special characters in attribute values, such as `&` as `&amp;`.

The project copies the local configuration file to the output folder during a build. `App.config` reads it through the .NET Framework [external connection strings configuration](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/connection-strings-and-configuration-files) mechanism.

The local file is ignored by Git. The tracked Settings designer definition and generated settings class contain no database password. Do not save real credentials into those tracked files while using the Visual Studio Settings or DataSet designers.

### Database availability

A working database is a separate prerequisite. This repository does not contain a SQL database creation script or a backup. `WstGrp22DataSet.xsd` describes the tables, result sets, mappings and queries used by the application; it is not a complete database deployment script.

The main entities include:

- Client
- User
- Product and Supplier
- SupplierProduct
- Order and ClientOrderProduct
- OrderSupplierProduct
- Payment

Several TableAdapters also use joined query results. A replacement database must support the columns and queries in the DataSet. Sign-in requires an existing user record; no demo login is supplied.

## Build and run

1. Open `DnD Trading.sln`.
2. Confirm the application project is the startup project.
3. Confirm the CrystalDecisions references resolve on your machine.
4. Build the solution.
5. Run with Visual Studio or launch the executable from `src/DnD.Trading/bin/Debug/`.

The executable remains named `DnD Trading.exe`. Password visibility icons are loaded from embedded resources, so they do not depend on your working directory.

## Configure client email

The payment request email uses the existing Gmail SMTP endpoint, `smtp.gmail.com`, on port `587` with SSL enabled.

Set these environment variables before starting the application:

| Variable | Value |
| --- | --- |
| `DND_SMTP_USER` | The Gmail sender address. |
| `DND_SMTP_PASSWORD` | The SMTP credential for that account, such as an app password where required. |

For a temporary PowerShell session, enter your sender address and read the password without displaying it:

```powershell
$env:DND_SMTP_USER = 'your-address@gmail.com'
$smtpSecret = Read-Host 'SMTP app password' -AsSecureString
$env:DND_SMTP_PASSWORD = [System.Net.NetworkCredential]::new('', $smtpSecret).Password
& '.\src\DnD.Trading\bin\Debug\DnD Trading.exe'
```

The executable inherits the variables from that PowerShell session. A Visual Studio process that was already running will not inherit newly set variables; launch the built executable from the same shell when checking email.

If the variables are missing, the application saves the order and displays an email configuration message. Sending failures also leave the saved order intact. Use a test client record when checking email, because creating an order with configured SMTP sends a real payment request to that client's email address.

## Troubleshooting

| Problem | Check |
| --- | --- |
| Database configuration message at startup | Create the local configuration file in the project folder and rebuild so it is copied beside the executable. |
| SQL connection or sign-in failure | Verify the configured server, database, authentication, network access and compatible schema. |
| SQL certificate error | Confirm the SQL Server certificate is trusted and its name matches the configured server. |
| Missing CrystalDecisions references | Install the SAP Visual Studio integration and resolve references using the compatible SDK installation. |
| Crystal Reports runtime load error | Match the runtime and application process architecture. Do not rely on old DLL copies from a build folder. |
| Missing .NET Framework reference assemblies | Install the 4.7.2 Developer Pack. |
| Email is skipped | Set both SMTP variables in the process that launches the application. |

## Repository maintenance

Commit the application source, `.Designer.cs` and `.resx` files, DataSet definitions and `.rpt` report files together when they change. They are project inputs.

Build output, `obj`, Visual Studio caches and per-user project settings are generated locally and are ignored. Removing those files from the current tree preserves their earlier Git history and does not reduce the size of older clones.

Previously committed database and SMTP credentials must be rotated. Removing current copies does not invalidate them or erase them from Git history.
