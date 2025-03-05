using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
////////////////////////////


// Replace placeholders in connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConn");
/// ////////////////////////

// Add services to the container.
builder.Services.AddControllersWithViews();


//
builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
// Add DbContext with MySQL connection string

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();