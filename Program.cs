using MyApi.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add controller + global filters
builder.Services.AddControllers(options =>
{
    options.Filters.Add<LoggingActionFilter>();   // Global Action Filter
    options.Filters.Add<ExceptionFilter>();       // Global Exception Filter
});

// Register DI for filters
builder.Services.AddScoped<LoggingActionFilter>();
builder.Services.AddScoped<TimeActionFilter>();
builder.Services.AddScoped<ResultFilter>();
builder.Services.AddScoped<ExceptionFilter>();
builder.Services.AddScoped<ResourceFilter>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Swagger only in Development (recommended)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    // Optional (if you want swagger in production too)
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ✅ Missing parts
app.UseHttpsRedirection();   // add this
app.UseAuthorization();       // required for swagger to load securely

app.MapControllers();

app.Run();
