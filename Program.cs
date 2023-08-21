using AWAIT.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Await_DotNet_PrototypeVersion_2.Areas.Identity;
using Identity;

// Initialize Web-Application Builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Database Context: AWAIT Test Suit & Test Cases.
builder.Services.AddDbContext<AwaitDbContext>(options => options
    .UseSqlServer(builder.Configuration.GetConnectionString("AwaitDbContext") ?? throw new InvalidOperationException("Connection string 'AwaitDbContext' not found.")));

// Database Context: ASP.NET Identity Framework.
builder.Services.AddDbContext<SpecialIdentityDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SpecialIdentityDbContext")));

//// Database Context: ASP.NET Identity Framework.
//builder.Services.AddDbContext<IdentityDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("SpecialIdentityDbContext")));

builder.Services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityDbContext>();

// Razor Engine/Page Service.
builder.Services.AddRazorPages();

// Build Web-App.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Landing/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Landing}/{action=Welcome}/{id?}");

app.Run();
