var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 🔹 Middleware 1: Logging (Request + Response)
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

    await next();

    Console.WriteLine($"Response Status: {context.Response.StatusCode}");
});

// 🔹 Middleware 2: Global Error Handling
app.UseExceptionHandler("/error");

app.Map("/error", (HttpContext context) =>
{
    return Results.Content("Something went wrong!", "text/plain");
});

// 🔹 Middleware 3: Security (CSP Header)
app.Use(async (context, next) =>
{
    context.Response.Headers["Content-Security-Policy"] = "default-src 'self'";
    await next();
});

// 🔹 Middleware 4: HTTPS Redirection
app.UseHttpsRedirection();

// 🔹 Middleware 5: Static Files
app.UseDefaultFiles();   // loads index.html
app.UseStaticFiles();

// 🔹 Optional test endpointdotnet 
app.MapGet("/api", () => "API is working");

app.Run();