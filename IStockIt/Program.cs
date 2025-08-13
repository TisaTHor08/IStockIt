var builder = WebApplication.CreateBuilder(args);

// Permet les fichiers statiques depuis wwwroot/
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

// Pour les fichiers statiques
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

// Exemple route simple
app.MapGet("/hello", () => "Hello depuis ASP.NET Core !");

app.Run();
