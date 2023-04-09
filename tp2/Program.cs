using tp2.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<BaseDeDonnees>();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();
    app.UseStaticFiles(new StaticFileOptions
    {
        OnPrepareResponse = context => context.Context.Response.Headers.Add("Cache-Control", "no-cache")
    });
}
else
{
    app.UseStaticFiles();
}

app.UseRouting();
app.MapRazorPages();

app.UseStatusCodePages(context =>
    {
        if (context.HttpContext.Response.StatusCode != 404) return Task.CompletedTask;
        context.HttpContext.Response.Redirect("/NotFound");

        return Task.CompletedTask;
    }
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Editors", action = "Index" },
    constraints: new { id = "[0-9]+" }
);
app.Run();