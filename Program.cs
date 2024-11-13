var builder = WebApplication.CreateBuilder(args);

// Add services to the container.  //Dependency injection container
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPizzaRepository, PizzaRepository>();
builder.Services.AddScoped<IPizzaService, PizzaService>();
builder.Services.AddScoped<IBreadRepository, BreadRepository>();
builder.Services.AddScoped<IBreadService, BreadService>();
builder.Services.AddScoped<IBiscuitRepository, BiscuitRepository>();
builder.Services.AddScoped<IBiscuitService, BiscuitService>();

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
