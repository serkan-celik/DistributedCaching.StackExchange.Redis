using StackExchangeRedis;

var builder = WebApplication.CreateBuilder(args);


//Add RedisService
builder.Services.AddSingleton<RedisService, RedisService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRedisConnect();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}



app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
