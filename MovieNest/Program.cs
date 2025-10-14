using Microsoft.EntityFrameworkCore;
using MovieNest.Data;
using MovieNest.Services;
using MovieNest.Services.Interface;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


// Add services to the container.
builder.Services.AddDbContext<MovieDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MovieNest")));


builder.Services.AddScoped<IMovieService, MovieService>();



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
    pattern: "{controller=Movies}/{action=Index}/{id?}");

app.Run();
