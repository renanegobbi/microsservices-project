using Basket.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

// Redis Configuration
builder.Services.AddStackExchangeRedisCache(options =>
    options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString"));

builder.Services.AddScoped<IBasketRepository, BasketRepository>();

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
