using api_teste_fiscalio.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

// Adicionar os serviços necessários para a aplicação
builder.Services.AddControllers(); // Isso registra o serviço dos controladores

// Registrar o serviço que converte números para texto
builder.Services.AddSingleton<NumberToTextService>();

var app = builder.Build();

// Configurar o pipeline de requisições HTTP
app.UseHttpsRedirection();

app.MapControllers();  // Mapeia os controladores para os endpoints

app.Run();
