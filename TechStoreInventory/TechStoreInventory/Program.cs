using Microsoft.EntityFrameworkCore;
using TechStoreInventory.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure Entity Framework and SQL Server
builder.Services.AddDbContext<InventoryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("InventoryManager")));

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
