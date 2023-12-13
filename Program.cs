var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Serilizing to json doesnt include keys for properties/fields that are null in the model object.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
});

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(corsBuilder =>
    {
        corsBuilder.AllowAnyOrigin() // Adjust in projects with a larger attack surface or increased exposure to production environments.
                   .AllowAnyMethod()
                   .AllowAnyHeader();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Listen to all connections on port 8003.
app.Urls.Add("http://*:8003");

app.UseHttpsRedirection();

app.UseAuthorization();

// Enable CORS
app.UseCors();

app.MapControllers();

app.Run();
