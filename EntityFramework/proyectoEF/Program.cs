var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello xD!");
app.MapGet("/Hi", () => "Hello Ronald Ris!");

app.Run();
