using FCIT.BITF24A.Web.DB_Models;
using FCIT.BITF24A.Web.DiPractice_01;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Bitf24aDbContext>(o => 
    o.UseSqlServer(connectionString)
    );


builder.Services.AddKeyedScoped<IPaymentMethod, JazzCash>("jazz");
builder.Services.AddKeyedScoped<IPaymentMethod, EasyPaisa>("epaisa");
builder.Services.AddKeyedScoped<IPaymentMethod, ApplePay>("apple");

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
   
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Students}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
