using MVC_IRM2_2.Models.Repositories;
using MVC_IRM2_2.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IRepository<Famille>, FamilleRepository>();
builder.Services.AddSingleton<IRepository<Produit>, ProduitRepository>();
//builder.Services.AddSingleton<IRepository<ProduitFamilleViewModel>, ProduitRepository>();


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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
