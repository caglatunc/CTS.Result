# CTS.Result NuGet Package

## Overview

The `CTS.Result` package is a library designed to facilitate error management and processing results in .NET projects. This library presents both the results of successful operations and the error messages and status codes encountered in case of failure in a standard format.

## Features

- **Generic Result Type**: Supports all data types for consistent and type-safe operation results.

- **Error Handling**: Enables detailed feedback for complex errors, enhancing user comprehension.

- **HTTP Status Code Integration**: Facilitates API response alignment with HTTP standards for straightforward management in web services.

- **Implicit Conversions**: Simplifies result object handling by allowing direct conversion from data or errors to Result type.


## Getting Started

### Installation

To integrate `CTS.Result` into your .NET project, you can use the NuGet package manager or the .NET CLI.

**Via NuGet Package Manager:**

```shell
Install-Package CTS.Result
```
Or through the .NET CLI:

```shell
dotnet add package CTS.Result
```

## Usage

### Creating a Successful Result:

**For a successful operation**, instantiate a Result object with the desired data:
  
  ```csharp
  var successResult = new Result<string>("Operation successful.");
  ```

**Alternatively**, leverage implicit conversion from data:
  ```csharp
  Result<string> result = "Operation successful.";
  ```

 ### Creating a Failed Result:

**For failures**, create a Result object with an HTTP status code and a list of error messages:
```csharp
var errorResult = new Result<string>(400, new List<string> { "Error 1", "Error 2" });
```

**Or** use implicit conversion from error details:
```csharp
Result<string> result = (400, new List<string> { "Error 1", "Error 2" });
```

**For single error messages**:
```csharp
Result<string> result = (400, "Single error message");
```
### Checking the Result:

You can check if an operation was successful by inspecting the `IsSuccess` property:

```csharp
if (result.IsSuccess)
{
    // Handle success
}
else
{
    // Handle failure
    var statusCode = result.StatusCode;
    var errors = result.ErrorMessages;
}
```

## Contributing

We welcome contributions! Feel free to open an issue or submit a pull request on our GitHub repository for any suggestions or improvements.

## License

`CTS.Result` is licensed under the MIT License. See the LICENSE file in the source repository for full details.

```rust
This Markdown formatted README provides a comprehensive guide on how to use the `CTS.Result` package, suitable for your project's repository or documentation.
```
