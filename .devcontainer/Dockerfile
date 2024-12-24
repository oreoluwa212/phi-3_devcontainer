FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /app
COPY . .
RUN apt-get update && apt-get install -y \
    wget \
    libfoo-dev \
    libbar-dev && \
    rm -rf /var/lib/apt/lists/* && \
    dotnet restore
RUN dotnet publish -c Release -o out
WORKDIR /app/out
CMD ["dotnet", "SampleProject.dll"]
