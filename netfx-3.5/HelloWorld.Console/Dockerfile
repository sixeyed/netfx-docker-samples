# escape=`
FROM microsoft/dotnet-framework-build:3.5-windowsservercore-ltsc2016 AS builder
WORKDIR C:\src\HelloWorld.Console
COPY . .
RUN msbuild HelloWorld.Console.sln /p:OutputPath=c:\out

# app image
FROM microsoft/dotnet-framework:3.5-windowsservercore-10.0.14393.1884
WORKDIR C:\hello-world
COPY --from=builder C:\out .
CMD HelloWorld.Console.exe