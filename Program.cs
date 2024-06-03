using System.IO.Abstractions;
using System.Reflection;
using GESTAO360.Convenios.Infraestrutura.Repositorios;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using NET.Controllers.Comportamentos;
using NET.Controllers.Middlewares;
using NET.Data;
using NET.Identidade;
using Vinculo_Net.Dominio;
using Vinculo_Net.Infraestrutura;
using Vinculo_Net.Infraestrutura.Contexto;
using Vinculo_Net.Infraestrutura.Repositorios;

var builder = WebApplication.CreateBuilder(args);

var currentAssembly = Assembly.GetAssembly(typeof(Program))!;

var configuracao = new Configuracao
{
    Assemblies = currentAssembly
        .GetReferencedAssemblies()
        .Where(e => e.FullName.StartsWith("VINCULO"))
        .Select(Assembly.Load)
        .Union([currentAssembly])
        .ToList(),
    ComportamentosAbertos = new List<Type> { typeof(ValidacaoComportamento<,>) }
};
builder.Services.AddSingleton<IConfiguracao>(configuracao);

builder.Services.AddCors(options =>
{
    options.AddPolicy("VINCULO",
        builder => builder
            .WithOrigins("http://localhost:8080")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLibs(configuracao);
builder.Services.AddHttpContextAccessor();
builder.Services.AdicionarPostgresDb<DominioContexto>();
builder.Services.AdicionarIdentidade();
builder.Services.AdicionarRepositorios<IAppUnitOfWork, AppUnitOfWork>(configuracao.Assemblies);
builder.Services.AddScoped<IFileSystem, FileSystem>();
builder.Services.AddJwtConfiguration();

builder.Services.AddAuthorization(options =>
{
    options.DefaultPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
        .Build();
});

builder.Services.AddMemoryCache();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("VINCULO");

app.UseAuthConfiguration();

app.UseMiddleware<ManipuladorDeErrosMiddleware>();

app.MapControllers();

app.Run();
