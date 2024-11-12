using api_teste_fiscalio.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

// Adicionar os servi�os necess�rios para a aplica��o
builder.Services.AddControllers(); // Isso registra o servi�o dos controladores

// Registrar o servi�o que converte n�meros para texto
builder.Services.AddSingleton<NumberToTextService>();

var app = builder.Build();

// Configurar o pipeline de requisi��es HTTP
app.UseHttpsRedirection();

app.MapControllers();  // Mapeia os controladores para os endpoints

app.Run();
