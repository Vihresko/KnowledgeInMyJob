using KIJ.Core.Interfaces;
using KIJ.Core.Services;
using KIJ.Data.DBContexts;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var localSqlConnectionString = builder.Configuration.GetConnectionString("LocalSqlServerConnectionString");

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DbContextSQL>(options =>
{
    options.UseSqlServer(localSqlConnectionString);
});

builder.Services.AddScoped<IAlgorithmService, AlgorithmService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
