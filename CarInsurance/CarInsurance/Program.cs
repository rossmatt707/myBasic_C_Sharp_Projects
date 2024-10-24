using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<InsureeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarInsuranceDb")));

var app = builder.Build();

// Enable static files (if you have CSS, JS, or images in wwwroot)
app.UseStaticFiles();

// Enable routing
app.UseRouting();

// Enable authorization (if you have authentication/authorization)
app.UseAuthorization();

// Set up default route mapping
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Run the application
app.Run();