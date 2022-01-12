using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using PolymorphicDataBindingExample.JSONConverter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options =>
{
    options.FormatterMappings.SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
})
    .AddNewtonsoftJson(opt =>
    {
        opt.SerializerSettings.Converters.Add(new PersonConverter());
    });

    ;
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
