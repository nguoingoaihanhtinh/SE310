using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Product.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container
builder.Services.AddControllersWithViews();

// Register DatabaseHelper with connection string
builder.Services.AddScoped<DatabaseHelper>(provider =>
{
    // Replace with your actual connection string
    var connectionString = "server=localhost;port=3306;database=food_db;user=root;password=123456;";
    return new DatabaseHelper(connectionString);
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Set the default route to the Food controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Food}/{action=Index}/{id?}"); // Change 'Home' to 'Food'

app.MapControllerRoute(
    name: "admin",
    pattern: "Admin/{action=Index}/{id?}",
    defaults: new { controller = "Admin", action = "Index" });

app.Run();
