using Shared.Repositories;
using DAL = DAL_Epreuve;
using BLL = BLL_Epreuve;

var builder = WebApplication.CreateBuilder(args);

// Localisation
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    string[] supportedCultures = new string[]
    {
        "en-US",
        "fr_BE"
    };
    string defaultCulture = supportedCultures[1];
    options.SetDefaultCulture(defaultCulture);
    options.AddSupportedCultures(supportedCultures);
    options.AddSupportedUICultures(supportedCultures); 
});

string connectionString = builder.Configuration.GetConnectionString("DB-Epreuve");

// Add services to the container.
builder.Services.AddControllersWithViews();

// Ajout services par injection de dépendance BLL:
builder.Services.AddScoped<ICategorieRepository<BLL.Entities.Categorie>, BLL.Services.CategorieService>();
builder.Services.AddScoped<IProduitRepository<BLL.Entities.Produit>, BLL.Services.ProduitService>();

// Ajout services par injection de dépendance DAL:
builder.Services.AddScoped<ICategorieRepository<DAL.Entities.Categorie>, DAL.Services.CategorieService>();
builder.Services.AddScoped<IProduitRepository<DAL.Entities.Produit>, DAL.Services.ProduitService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// Localisation
app.UseRequestLocalization();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
