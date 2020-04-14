# NugetTests

This repo shows how to include local dependent projects in a single nuget package. 

The hopes are to find a way to also include Package References from that project in the nuget package.

Currently the project layout is like so:

ProjectA
-> AutoMapper
-> ProjectB
   -> Newtonsoft.Json
   
The resulting nupkg from `dotnet pack` has the following:

Files:
> lib/netstandard2.0/ProjectA.dll
> lib/netstandard2.0/ProjectB.dll

Refernces:
> AutoMapper

Missing is the reference to Newtonsoft.Json
