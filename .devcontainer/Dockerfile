# Use the ASP.NET 7.0 runtime as the base image
FROM mcr.microsoft.com/dotnet/aspnet:7.0

# Set the working directory
WORKDIR /app

# Copy the project file and restore dependencies
COPY Phi3Sample.csproj ./
RUN dotnet restore
RUN apt-get update && apt-get install -y docker.io

# Copy the rest of the application files
COPY . ./

# Optional: Build the application
RUN dotnet build --configuration Release