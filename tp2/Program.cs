using Microsoft.AspNetCore.Builder;
using tp2.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<CodeEditor>();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseStaticFiles();
}

app.MapRazorPages();
app.Run();