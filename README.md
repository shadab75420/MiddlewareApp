# MiddlewareApp – .NET Core Middleware & Static Files

## Project Overview

This project demonstrates the use of ASP.NET Core middleware along with static file handling and basic security practices. It fulfills the requirement of building a .NET Core application that processes HTTP requests using middleware components.

---

## Objectives

* Understand middleware pipeline in ASP.NET Core
* Log HTTP requests and responses
* Handle global exceptions
* Serve static files (HTML, CSS, JavaScript)
* Apply basic security (HTTPS and Content Security Policy)

---

## Technologies Used

* ASP.NET Core (.NET 8 or latest)
* C#
* HTML, CSS, JavaScript

---

## Project Structure

```
MiddlewareApp/
 ├── Program.cs
 ├── wwwroot/
 │    ├── index.html
 │    ├── style.css
 │    └── script.js
 ├── appsettings.json
 ├── appsettings.Development.json
 └── MiddlewareApp.csproj
```

---

## Features Implemented

### 1. Middleware Logging

Logs incoming HTTP requests and outgoing responses in the console.

### 2. Global Error Handling

Handles unhandled exceptions and returns a custom error message.

### 3. Static File Serving

Serves HTML, CSS, and JavaScript files from the wwwroot folder.

### 4. HTTPS Redirection

Redirects HTTP requests to HTTPS for secure communication.

### 5. Security (Content Security Policy)

Adds a CSP header to protect against common vulnerabilities such as XSS.

---

## How to Run the Project

1. Open terminal in the project folder
2. Run the following command:

   ```
   dotnet run
   ```
3. Open browser and navigate to:

   ```
   http://localhost:5187/
   ```

---

## Expected Output

* A web page displaying content from index.html
* CSS styling applied
* JavaScript button functionality working
* Console logs showing request and response details

Example console output:

```
Request: GET /
Response Status: 200
```

---

## Learning Outcomes

* Understanding middleware execution flow
* Configuring and using ASP.NET Core pipeline
* Serving static content in a web application
* Implementing basic security measures

---

## Conclusion

This project provides a practical understanding of ASP.NET Core middleware, request handling, and static file serving. It also introduces essential security practices required in modern web applications.
