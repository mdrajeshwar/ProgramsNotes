# Selenium & API Automation Framework (C#)

This framework provides a simple structure for web UI automation using Selenium and API automation using RestSharp. It follows best practices for maintainability and easy updates.

## Structure
- `Pages/` - Page Object Model classes for web automation
- `Tests/` - Test classes for UI and API
- `Utils/` - Utilities (WebDriver, Config, API helpers)
- `Api/` - API service classes

## Getting Started
1. Install dependencies:
   - Selenium.WebDriver
   - Selenium.Support
   - RestSharp
   - NUnit (or xUnit)
2. Add your test cases in `Tests/`
3. Add page classes in `Pages/`
4. Add API service classes in `Api/`

## Example
- See `Tests/SampleWebTest.cs` and `Tests/SampleApiTest.cs` for usage.

---
Feel free to extend and organize as needed for your project.