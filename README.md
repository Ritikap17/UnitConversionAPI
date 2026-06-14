# Unit Conversion API

## About Project

This is a simple ASP.NET Core Web API project to convert values from one unit to another. It supports conversions for length, temperature, and weight.

## Conversions Supported

### Length

* Meter to Feet
* Feet to Meter

### Temperature

* Celsius to Fahrenheit
* Fahrenheit to Celsius

### Weight

* Kilogram to Pound
* Pound to Kilogram

## Technologies Used

* ASP.NET Core Web API
* C#
* Swagger for API testing
* Git and GitHub

## API Endpoints

* GET /api/Conversion/length
* GET /api/Conversion/temperature
* GET /api/Conversion/weight

## How to Run

1. Open the project in Visual Studio 2022.
2. Build the project.
3. Press F5 to run the application.
4. Swagger page will open where you can test all APIs.

## Sample Test

Length Conversion:

/api/Conversion/length?from=meter&to=feet&value=10

Temperature Conversion:

/api/Conversion/temperature?from=celsius&to=fahrenheit&value=25

Weight Conversion:

/api/Conversion/weight?from=kilogram&to=pound&value=10

## Error Handling

If an invalid conversion is entered, the API returns a Bad Request response with an error message.

## Author

Ritika Patil
