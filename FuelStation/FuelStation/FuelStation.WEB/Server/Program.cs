using FuelStation.EF.Context;
using FuelStation.Models;
using FuelStation.Services;
using FuelStation.Services.Calculation;
using FuelStation.Services.Repository;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<FuelStationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("FuelStationConnection")));
builder.Services.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
builder.Services.AddScoped<IEntityRepo<Item>, ItemRepo>();
builder.Services.AddScoped<IEntityRepo<Employee>, EmployeeRepo>();
builder.Services.AddScoped<IEmployee, EmployeeRepo>();
builder.Services.AddScoped<IEntityRepo<Transaction>, TransactionRepo>();
builder.Services.AddScoped<IMonthlyLedgerCalc, MonthlyLedgerCalc>();
builder.Services.AddScoped<IFindCustomerWithCardNumber, FindCustomerWithCardNumber>();





var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
