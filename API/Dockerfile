FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY bin/Release/net5.0/publish/ App/
ENV HTTP_PROXY="http://192.168.1.12:3128"
WORKDIR /App
ENTRYPOINT ["dotnet", "API.dll"]