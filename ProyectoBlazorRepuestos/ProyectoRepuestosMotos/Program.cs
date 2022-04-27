using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ProyectoRepuestosMotos.Data;
using ProyectoRepuestosMotos.Interfaces;
using ProyectoRepuestosMotos.Servicios;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

ConfiguracionMySQL cadenaConexion = new ConfiguracionMySQL(builder.Configuration.GetConnectionString("MySQL"));
builder.Services.AddSingleton(cadenaConexion); //bd

builder.Services.AddScoped<IUsuarioServicio, UsuarioServicio>(); //inyectamos el servicio
builder.Services.AddScoped<IFacturaServicio, FacturaServicio>(); //inyectamos el servicio
builder.Services.AddSweetAlert2();

builder.Services.AddScoped<IProductoServicio, ProductoServicio>(); //inyectamos el servicio

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
builder.Services.AddHttpContextAccessor();



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

app.UseAuthentication();
app.UseAuthorization();


app.MapBlazorHub();
app.MapControllers();

app.MapFallbackToPage("/_Host");

app.Run();
