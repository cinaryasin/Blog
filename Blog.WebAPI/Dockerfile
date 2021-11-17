#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Blog.WebAPI/Blog.WebAPI.csproj", "Blog.WebAPI/"]
COPY ["Blog.Entities/Blog.Entities.csproj", "Blog.Entities/"]
COPY ["Core/Core.csproj", "Core/"]
COPY ["Blog.Business/Blog.Business.csproj", "Blog.Business/"]
COPY ["Blog.DataAccess/Blog.DataAccess.csproj", "Blog.DataAccess/"]
RUN dotnet restore "Blog.WebAPI/Blog.WebAPI.csproj"
COPY . .
WORKDIR "/src/Blog.WebAPI"
RUN dotnet build "Blog.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blog.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.WebAPI.dll"]