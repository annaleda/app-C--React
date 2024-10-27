# app-C#-React
#

### Set the download URL for the latest .NET SDK installer
```plaintext
$dotnetInstallerUrl = "https://dotnet.microsoft.com/download/dotnet/scripts/v1/dotnet-install.ps1"
```
### Scarica lo script di installazione .NET
```plaintext
Invoke-WebRequest -Uri $dotnetInstallerUrl -OutFile "dotnet-install.ps1"
```
### Esegui lo script di installazione
```plaintext
& .\dotnet-install.ps1 -Channel STS
```
### Aggiungi il percorso di .NET al PATH
```plaintext
$env:Path += ";C:\Program Files\dotnet"
```
### verifica version
```plaintext
donnet --version
```
### create app BE
```plaintext
dotnet new webapi -n MyAppBackend
```
