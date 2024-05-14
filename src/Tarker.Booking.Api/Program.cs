using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.DataBase;
using Tarker.Booking.Persistence.DataBase;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseService>(opc => opc.UseSqlServer(builder.Configuration["SQLConnectionStrings"]));

builder.Services.AddScoped<IDataBaseService, DataBaseService>();
var app = builder.Build();

app.Run();

