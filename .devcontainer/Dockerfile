FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /app
COPY Samples/Phi3Sample.csproj ./Samples/
RUN dotnet restore ./Samples/Phi3Sample.csproj
COPY . .
RUN dotnet publish ./Samples/Phi3Sample.csproj -c Release -o out
WORKDIR /app/out
CMD ["dotnet", "Phi3Sample.dll"]
