using Microsoft.EntityFrameworkCore;
using Simple_Eshop.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//Registering our Services

//builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
//builder.Services.AddScoped<IPieRepository, MockPieRepository>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllersWithViews()
    .AddJsonOptions(
    options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddRazorPages();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<BethanysPieShopDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BethanysPieShopDbContextConnection"]);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.UseSession();

app.MapDefaultControllerRoute(); //"{controller=Home}/{action}/{id?}"
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseAntiforgery();

app.MapRazorPages();

//app.MapRazorComponents<App>()
//    .AddInteractiveServerRenderMode();


DbInitializer.Seed(app);

app.Run();

