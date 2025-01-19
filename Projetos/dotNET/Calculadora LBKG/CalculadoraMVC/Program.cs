var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços necessários para o MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurações do pipeline de requisição
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Define a rota padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Conversion}/{action=Index}/{id?}");

app.Run();
