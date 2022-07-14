# PowerUtils.BuildingBlocks.Data

![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.BuildingBlocks.Data/main/assets/logo/logo_128x128.png)

***Helpers to work with data layers***

![Tests](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Data/actions/workflows/test-project.yml/badge.svg)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.BuildingBlocks.Data&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.BuildingBlocks.Data)

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.BuildingBlocks.Data.svg)](https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Data)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.BuildingBlocks.Data.svg)](https://www.nuget.org/packages/PowerUtils.BuildingBlocks.Data)
[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.BuildingBlocks.Data.svg)](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Data/blob/main/LICENSE)



## Support to
- .NET 3.1 or more
- .NET Framework 4.6.2 or more
- .NET Standard 2.0 or more



## Features

- [Interfaces](#Interfaces)
  - [IUnitOfWork](#Interfaces.IUnitOfWork)
  - [IRepositoryBase](#Interfaces.IRepositoryBase)



## Documentation

### How to use

#### Install NuGet package
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



## Contribution

*Help me to help others*



## LICENSE

[MIT](https://github.com/TechNobre/PowerUtils.BuildingBlocks.Data/blob/main/LICENSE)



## Changelog

[Here](./CHANGELOG.md)
