FROM microsoft/aspnetcore

COPY out /app

WORKDIR /app

EXPOSE 5000

ENTRYPOINT ["dotnet", "App.dll"]