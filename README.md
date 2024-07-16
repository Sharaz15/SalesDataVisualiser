# Sales Summary Blazor Application

This Blazor Server application reads sales data from a CSV file, processes it using CsvHelper, and logs events using Serilog. Below are the steps to run the application and details on the implementation.


Using CsvHelper
CsvHelper is utilized to parse the CSV file containing sales data. The following steps detail how CsvHelper is used in the project:

Mappers
Custom ClassMap: A custom ClassMap is created to map the CSV columns to the Product model properties. This ensures each column in the CSV is correctly assigned to its corresponding property in the model.
Trimming Headers: The headers are trimmed to remove any leading or trailing whitespace. This is crucial to avoid errors during mapping if the CSV headers have unintended spaces.
Converters
String Trimming Converter: A custom converter is used to trim any leading or trailing whitespace in string fields and to remove spaces within the strings.
Date Converter: A custom date converter is implemented to handle specific date formats in the CSV file, ensuring dates are correctly parsed and formatted.
Logging with Serilog
Serilog is used for logging events and errors to a file. The following configurations and usages are implemented:

Configuration
File and Console Logging: Serilog is configured to log information to both the console and a rolling file. This setup helps in monitoring the application during development and maintaining logs for production diagnostics.
Minimum Logging Level: The minimum logging level is set to Debug to capture detailed information, which is useful during development and troubleshooting.
Usage
Dependency Injection: Serilog is integrated into the Blazor application using dependency injection. This allows it to be used throughout the application for consistent logging practices.
Error Handling: In Blazor components, Serilog is used to log exceptions and errors, ensuring that any issues during data fetching or processing are recorded for later review.
Screenshots
Success

Error
