using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using oginshop_doan4.Data;
<<<<<<< HEAD
using oginshop_doan4.Models;
=======
using oginshop_doan4.Repository;
>>>>>>> 42ebf3b561f70bfc346f3d9ef33ed0291e66411c

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseSqlServer(connectionString));

<<<<<<< HEAD
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<CustomUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
=======




builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IProduct, ProductRepository>();
builder.Services.AddScoped<INew, NewRepository>();
builder.Services.AddScoped<Islide, SlideRepository>();
builder.Services.AddScoped<IConfig, ConfigRepository>();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IProduct, ProductRepository>();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
>>>>>>> 42ebf3b561f70bfc346f3d9ef33ed0291e66411c
	.AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}
else
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
