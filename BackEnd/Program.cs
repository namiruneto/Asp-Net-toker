using BackEnd.Application.Interfaces;
using BackEnd.Application.Services;
using BackEnd.Domain.Interfaces;
using BackEnd.Domain.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Agregar los servicios de los controladores
builder.Services.AddControllers();

// Registrar los servicios de la capa de dominio
builder.Services.AddScoped<IUser, UserDomainServices>();

// Registrar los servicios de la capa de aplicación
builder.Services.AddScoped<IUserService, UserApplicationService>();

// Registrar el servicio Lazy para la inyección de dependencias
builder.Services.AddScoped<Lazy<IUser>>(sp => new Lazy<IUser>(() => sp.GetRequiredService<IUser>()));

// Configurar Swagger para documentación de API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

    // Configuración de autenticación con Bearer Token
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Register",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer"
    });  
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); 
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
}

app.UseHttpsRedirection();
app.UseAuthentication(); 
app.UseAuthorization();  

app.MapControllers(); 
app.Run(); 
