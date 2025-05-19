# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY BlazorRecipeBook/*.csproj ./BlazorRecipeBook/
RUN dotnet restore

# copy everything else and build
COPY BlazorRecipeBook/. ./BlazorRecipeBook/
WORKDIR /app/BlazorRecipeBook
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/BlazorRecipeBook/out ./
ENTRYPOINT ["dotnet", "BlazorRecipeBook.dll"]
