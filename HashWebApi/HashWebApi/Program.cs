
using System.Reflection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "0.1.5",
        Title = "HashWebApi",
        Description = "ASP.NET CORE WebApi created by Kacper ¯abiñski",
        TermsOfService = new Uri("https://www.youtube.com/watch?v=PvB0kWs2IPQ"),
        Contact = new OpenApiContact()
        {
            Name = "Contact Me",
            Url = new Uri("https://www.facebook.com/kacper.zab")
        },
        License = new OpenApiLicense()
		{
            Name = "License",
            Url = new Uri("https://www.gnu.org/licenses/gpl-3.0.txt")
		},
	});

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
	    options.SerializeAsV2 = true;
    });
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "SandstormWebApi");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
