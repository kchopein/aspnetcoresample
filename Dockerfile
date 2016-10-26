FROM microsoft/aspnetcore:1.0.1

WORKDIR /app

COPY project.json /app
RUN ["dotnet", "restore"]

COPY . /app
RUN ["dotnet", "build"]

ENTRYPOINT ["dotnet", "myapp.dll"]
