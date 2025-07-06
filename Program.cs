using ConsultaCepAPI.Adapters;
using ConsultaCepAPI.Adapters.Interfaces;
using ConsultaCepAPI.Endpoints;
using ConsultaCepAPI.Services;
using ConsultaCepAPI.Services.Interfaces;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient("ViaCep", httpClient =>
{
    httpClient.BaseAddress = new Uri("https://viacep.com.br/ws/");

    // using Microsoft.Net.Http.Headers;
    // The GitHub API requires two headers.
    httpClient.DefaultRequestHeaders.Add(
        HeaderNames.Accept, "application/json");
});
builder.Services.AddScoped<ICepService, CepService>();
builder.Services.AddScoped<IViaCepService, ViaCepService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
var app = builder.Build();
app.MapCepEndpoints();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();


app.Run();

