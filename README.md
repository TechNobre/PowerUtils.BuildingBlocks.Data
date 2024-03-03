# PowerUtils.BuildingBlocks.Data

# :warning: DEPRECATED

This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project.

![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.BuildingBlocks.Data/main/assets/logo/logo_128x128.png)

***Helpers to work with data layers***

[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.BuildingBlocks.Data.svg)](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Data/blob/main/LICENSE)


- [Support to ](#support-to-)
- [How to use ](#how-to-use-)
  - [Install NuGet package](#install-nuget-package)
  - [Interfaces ](#interfaces-)
  - [IUnitOfWork ](#iunitofwork-)
  - [IRepositoryBase ](#irepositorybase-)
- [Contribution](#contribution)



## Support to <a name="support-to"></a>
- .NET 3.1 or more
- .NET Framework 4.6.2 or more
- .NET Standard 2.0 or more



## How to use <a name="how-to-use"></a>

### Install NuGet package
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Data

**Nuget**
```bash
Install-Package PowerUtils.BuildingBlocks.Data
```

**.NET CLI**
```
dotnet add package PowerUtils.BuildingBlocks.Data
```



### Interfaces <a name="Interfaces"></a>


### IUnitOfWork <a name="Interfaces.IUnitOfWork"></a>

```csharp
public interface IUnitOfWork : IDisposable
{
    Task<bool> CommitAsync(CancellationToken cancellationToken = default);
    Task RollbackAsync(CancellationToken cancellationToken = default);
}
```


### IRepositoryBase <a name="Interfaces.IRepositoryBase"></a>

```csharp
public interface IRepositoryBase { }
```



## Contribution<a name="contribution"></a>

If you have any questions, comments, or suggestions, please open an [issue](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Data/issues/new/choose) or create a [pull request](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Data/compare)
