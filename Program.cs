using MyCoreApp.Data;
using MyCoreApp.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

OfficeDatabaseContext.conStr = builder.Configuration["ConnectionStrings:DefaultConnection"];

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ProfessorDetailService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
