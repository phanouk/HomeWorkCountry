using HomeWorkCountry.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register HttpClient
builder.Services.AddHttpClient();

// Register CountryService and ICountryService
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddSingleton<IMemberService, MemberService>();

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Country API V1");
    });
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
