FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster
WORKDIR /src
COPY ["Demo.Tests/Demo.Tests.csproj", "Demo.Tests/"]
COPY ["Demo.Pages/Demo.Pages.csproj", "Demo.Pages/"]
COPY ["Demo.Core/Demo.Core.csproj", "Demo.Core/"]
RUN dotnet restore "Demo.Tests/Demo.Tests.csproj"
COPY . .
CMD ["dotnet", "test"]