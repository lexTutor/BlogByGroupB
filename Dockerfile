FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /src
COPY *.sln .
COPY BlogTest/*.csproj BlogTest/
RUN dotnet restore BlogTest/*.csproj
COPY DataContext/*.csproj DataContext/
RUN dotnet restore DataContext/*.csproj
COPY KingdomBlog/*.csproj KingdomBlog/
RUN dotnet restore KingdomBlog/*.csproj
COPY KingdomBlog.Models/*.csproj KingdomBlog.Models/
RUN dotnet restore KingdomBlog.Models/*.csproj
COPY KingdomBlog.Repository/*.csproj KingdomBlog.Repository/
RUN dotnet restore KingdomBlog.Repository/*.csproj
COPY . .

#Testing
FROM base AS testing
WORKDIR /src/DataContext
WORKDIR /src/KingdomBlog
WORKDIR /src/KingdomBlog.Models
WORKDIR /src/KingdomBlog.Repository
RUN dotnet build
WORKDIR /src/BlogTest
RUN dotnet test

#Publishing
FROM base AS publish
WORKDIR /src/KingdomBlog
RUN dotnet publish -c Release -o /src/publish

#Get the runtime into a folder called app
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
#ENTRYPOINT ["dotnet", "KingdomBlog.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet KingdomBlog.dll