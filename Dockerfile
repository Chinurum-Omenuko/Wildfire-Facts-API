# Use the official image as a parent image.
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory.
WORKDIR /WildfireFacts

# Copy the file from your host to your current location.
COPY . ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /WildfireFacts
COPY --from=build /WildfireFacts/out ./
ENTRYPOINT ["dotnet", "WildfireFacts.dll"]
