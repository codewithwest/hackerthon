using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using net_hack;
//Using System.Net.Http directive which will enable HttpClient.
using System.Net.Http;
//use newtonsoft to convert json to c# objects.


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllers();
builder.Services.AddTransient<JsonFileProductService>();
builder.Services.AddTransient<ProjectUrlService>();
builder.Services.AddTransient<UserUrlService>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
// app.MapGet();
// var options = app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>();
// app.UseRequestLocalization(options.Value);
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapControllers();
    endpoints.MapBlazorHub();
    //     //     endpoints.MapGet("/products", (context) =>
    //     // {
    //     //     var products = app.Services.GetService<JsonFileProductService>().GetProducts();
    //     //     var json = JsonSerializer.Serialize<IEnumerable<Product>>(products);
    //     //     return context.Response.WriteAsync(json);
    //     // });
});




app.Run();
