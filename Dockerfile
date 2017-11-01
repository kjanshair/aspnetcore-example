FROM microsoft/dotnet AS build

COPY . app

WORKDIR /app

RUN dotnet restore; dotnet publish -o out

# final image

FROM microsoft/aspnetcore

COPY --from=build /app/out /out

WORKDIR /out

EXPOSE 5000

ENTRYPOINT [ "dotnet", "App.dll" ]
