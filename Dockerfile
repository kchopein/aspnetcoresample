FROM microsoft/dotnet

WORKDIR /out

# copy project.json and restore as distinct layers
# COPY project.json .
# RUN dotnet restore

EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000

# copy and build everything else
# COPY . .
# RUN dotnet publish -c Release -o out
RUN dotnet aspnetcoresample.dll
