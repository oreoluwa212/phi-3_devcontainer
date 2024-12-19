FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /app
RUN apt-get update && apt-get install -y \
    python3 \
    python3-pip \
    git
COPY . .
RUN dotnet restore