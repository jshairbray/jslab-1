FROM mcr.microsoft.com/dotnet/runtime:10.0-noble-chiseled
WORKDIR /app
COPY publish/ .
ENTRYPOINT ["dotnet", "JsLab1.App.dll"]
