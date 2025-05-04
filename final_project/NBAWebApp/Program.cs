using Microsoft.EntityFrameworkCore; 
using NBAWebApp.Data; 
using Npgsql.EntityFrameworkCore.PostgreSQL; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NBAContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=1234;Database=nba"));

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapGet("/", async context =>
{
    context.Response.Redirect("/Teams/Index");
    await Task.CompletedTask;
});

app.MapRazorPages();

app.Run();
