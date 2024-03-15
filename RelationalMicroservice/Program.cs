using Application.Interfaces;
using Application.UseCases;
using Infrastructure.Persistence;
using Infrastructure.Queries;
using Microsoft.EntityFrameworkCore;
using RelationalMicroservice.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Custom ==> Connection String PostgreSQL
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<RelationalDbContext>(options => options.UseNpgsql(connectionString));


//Config HttpClient
builder.Services.AddHttpClient<IApiTitleServices, ApiTitleServices>()
       .Services.AddSingleton<IApiTitleServices, ApiTitleServices>();

builder.Services.AddHttpClient<IApiIdServices, ApiIdServices>()
       .Services.AddSingleton<IApiIdServices, ApiIdServices>();

//Config Interfaces & Services
builder.Services.AddScoped<IGetAllGenresService, GetAllGenresService>();
builder.Services.AddScoped<IGetAllGenresQuery, GetAllGenresQuery>();

builder.Services.AddScoped<IGetAllCountriesService, GetAllCountriesService>();
builder.Services.AddScoped<IGetAllCountriesQuery, GetAllCountriesQuery>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGrpcService<MediaServices>();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


app.Run();
