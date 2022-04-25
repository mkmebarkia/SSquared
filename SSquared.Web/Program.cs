using Microsoft.EntityFrameworkCore;
using SSquared.Core;
using SSquared.Core.Services;
using SSquared.Core.Services.Interfaces;
using SSquared.Infrastructure.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SSquaredDbContext>(options => options.UseSqlite("Data Source = SSquaredDB.db"));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddServerSideBlazor();

builder.Services.AddAutoMapper(typeof(Program));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapBlazorHub();

app.Run();
