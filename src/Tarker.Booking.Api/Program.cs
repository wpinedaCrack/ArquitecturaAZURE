#region OldConf
//builder.Services.AddDbContext<DataBaseService>(opc => opc.UseSqlServer(builder.Configuration["SQLConnectionStrings"]));

//builder.Services.AddScoped<IDataBaseService, DataBaseService>();
//var app = builder.Build();

//app.MapPost("/createTest", async (IDataBaseService _dataService) =>
//{
//    var entity = new Tarker.Booking.Domain.Entities.User.UserEntity
//    {
//        FirstName = "Camilo",
//        LastName = "Pineda",
//        UserName = "CPineda",
//        Password = "12345"
//    };
//    await _dataService.User.AddAsync(entity);
//    await _dataService.SaveAsync();

//    return "OK PAPITO";
//});

//app.MapPost("/testGet", async (IDataBaseService _dataService) =>
//{
//    var result = await _dataService.User.ToListAsync(); 

//    return result;
//});
#endregion
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Components.Forms;
using Tarker.Booking.Api;
using Tarker.Booking.Application;
using Tarker.Booking.Common;
using Tarker.Booking.External;
using Tarker.Booking.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var keyVaultUrl = builder.Configuration["keyVaultUrl"] ?? string.Empty;

if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "local")
{
    string tenantId = Environment.GetEnvironmentVariable("tenantId") ?? string.Empty;
    string clientId = Environment.GetEnvironmentVariable("clientId") ?? string.Empty;
    string clientSecret = Environment.GetEnvironmentVariable("clientSecret") ?? string.Empty;

    //var tokenCredentials = new ClientSecretCredential(tenantId, clientId, clientSecret);  habilitar cuando tenga azure
    //builder.Configuration.AddAzureKeyVault(new Uri(keyVaultUrl), tokenCredentials);
}
else
{
    //builder.Configuration.AddAzureKeyVault(new Uri(keyVaultUrl), new DefaultAzureCredential());
}

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)         //  ====>   configuration contiene todos los secretos de keyVault
    .AddPersistence(builder.Configuration);
//var SQL = builder.Configuration["SQLConnectionStrings"];  //trae valor del secreto de azure
//var sendGrid = builder.Configuration["SendGridEmailKey"];

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();