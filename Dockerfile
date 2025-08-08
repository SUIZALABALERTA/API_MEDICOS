FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ./ ./
WORKDIR /src/SUIZASOFT_MEDICOS/
RUN dotnet restore "./SUIZASOFT_MEDICOS.csproj" --disable-parallel
RUN dotnet publish "./SUIZASOFT_MEDICOS.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

RUN ln -sf /usr/share/zoneinfo/America/Lima /etc/localtime
RUN dpkg-reconfigure --frontend noninteractive tzdata

ENTRYPOINT ["dotnet", "SUIZASOFT_MEDICOS.dll"]