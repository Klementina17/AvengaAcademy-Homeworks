using Microsoft.EntityFrameworkCore;
using VideoRentalOnlineShopApp.DataAccess;
using VideoRentalOnlineShopApp.DataAccess.Implementations;
using VideoRentalOnlineShopApp.DataAccess.Interfaces;
using VideoRentalOnlineShopApp.Domain;
using VideoRentalOnlineShopApp.Services.Implementation;
using VideoRentalOnlineShopApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
});

// Add services to the container.
builder.Services.AddControllersWithViews();

//Register database
string connectionString = builder.Configuration.GetConnectionString("VideoRentalOnlineShopAppConnectionString");
builder.Services.AddDbContext<VideoRentalOnlineShopAppDbContext>(options =>
            options.UseSqlServer(connectionString)
      );

//Dependency Injection for repositories
builder.Services.AddScoped<IRepository<Movie>, MovieRepository>();
builder.Services.AddScoped<IRepository<Rental>, RentalRepository>();
builder.Services.AddScoped<IRepository<User>, UserRepository>();

//Dependency Injection for services
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IRentalService, RentalService>();
builder.Services.AddScoped<IUserService, UserService>();


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

app.UseSession();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => Results.Redirect("/account/login"));

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
