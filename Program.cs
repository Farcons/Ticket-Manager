using System.Diagnostics;
using TicketManager.DbContexts;

var mutex = new Mutex(true, "TicketManagerApp", out bool isNew);

if (!isNew)
{
    return;
}

var builder = WebApplication.CreateBuilder(args);
builder.Environment.EnvironmentName = Environments.Development;

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// registra o serviço
builder.Services.AddMemoryCache();
new DBBuilderBase().ModelCreating(builder);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

var url = "http://localhost:7061";

Task.Run(async () =>
{
    await Task.Delay(1500); // aguarda o servidor subir
    Process.Start(new ProcessStartInfo
    {
        FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe",
        Arguments = url,
        UseShellExecute = true
    });
});

app.Run();