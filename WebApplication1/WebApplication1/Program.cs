using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexto;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

builder.Services.AddDbContext<Contexto> 
    (options => options.UseMySql(
            "server=localhost;initial catalog=CRUD_MC_MYSQL_TESTE;uid=root;pwd=Mysql1199",
            Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql")))//string de conexao com o banco

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
