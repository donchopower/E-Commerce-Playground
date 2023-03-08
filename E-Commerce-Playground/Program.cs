using Azure;
using E_Commerce_Playground.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.CookiePolicy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)

//    .AddCookie(options =>
//    {
//        options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
//        options.SlidingExpiration = true;
//        options.AccessDeniedPath = "/Products";
        
//    });



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
app.UseAuthentication();



//var cookieAuthOptions = new CookieAuthenticationOptions(AuthenticationScheme = "CookieAuthentication", LoginPath = new PathString
//var cookieOptions = new CookieOptions();
//cookieOptions.Expires = DateTimeOffset.UtcNow.AddMinutes(5);
//cookieOptions.Path= "/";

//app.UseCookieAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
DbPopulator.Populate(app);
app.Run();
