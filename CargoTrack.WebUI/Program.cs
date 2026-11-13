using CargoTrack.Business.Extensions;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("DefaultConnection bulunamadı.");

builder.Services.AddBusinessLayer(connectionString);

// Login cookie ayarları: yollar WebUI'ın bilgisi olduğu için burada
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";              // 401 → buraya
    options.AccessDeniedPath = "/Account/AccessDenied"; // 403 → buraya
    options.LogoutPath = "/Account/Logout";

    options.Cookie.Name = "CargoTrack.Auth";
    options.Cookie.HttpOnly = true;                          // JavaScript okuyamaz
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // sadece HTTPS
    options.Cookie.SameSite = SameSiteMode.Lax;

    options.ExpireTimeSpan = TimeSpan.FromHours(8);
    options.SlidingExpiration = true;
});

var app = builder.Build();

await app.Services.InitializeBusinessLayerAsync(
    includeDemoData: app.Environment.IsDevelopment());

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
