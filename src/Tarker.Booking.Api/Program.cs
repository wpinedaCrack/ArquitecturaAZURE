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
using Microsoft.EntityFrameworkCore;
using System.Net.Security;
using System.Net;
using Tarker.Booking.Api;
using Tarker.Booking.Application;
using Tarker.Booking.Application.DataBase;
using Tarker.Booking.Common;
using Tarker.Booking.External;
using Tarker.Booking.Persistence;
using Tarker.Booking.Persistence.DataBase;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();