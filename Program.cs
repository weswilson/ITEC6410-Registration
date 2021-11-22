using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Registration.Data;
using System.Security.Claims;

namespace Registration { 
    internal static class Program
    {
        private static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<RegistrationContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("RegistrationContext")));

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("Staff", policy => policy.RequireClaim(ClaimTypes.Role, "Staff"));
                options.AddPolicy("Student", policy => policy.RequireClaim(ClaimTypes.Role, "Student"));
            });

            var app = builder.Build();


            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                using (var context = services.GetRequiredService<RegistrationContext>())
                {
                    context.Database.EnsureCreated();
                }
            }

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
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Course}/{action=Index}/{id?}");

            app.Run();

        }
    }
}