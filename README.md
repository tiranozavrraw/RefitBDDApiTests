# TripadviserTests

## Overview
This project is a test suite for interacting with the TripAdvisor RapidAPI. It uses .NET 8.0, xUnit for testing, and Refit for API client generation. The project is configured to support dependency injection, logging with Serilog, and configuration management.

## Prerequisites
- .NET 8.0 SDK
- Visual Studio or JetBrains Rider IDE
- Access to the TripAdvisor RapidAPI with a valid API key (which I don't have)

## Project Structure
- **TripadviserTests.csproj**: Project configuration and dependencies.
- **appSettings.json**: Contains base configuration for the API.
- **StartUp.cs**: Configures services, logging, and API clients.
- **HttpHandlers**: Custom HTTP handlers for request/response processing.
- **TripAdvicerClient**: Contains API client interfaces and related logic.

## Configuration
1. Update `appSettings.local.json` with your API key:
   ```json
   {
     "TripAdvisorRapidAPI": {
       "ApiKey": "Your-API-Key-Here"
     }
   }
