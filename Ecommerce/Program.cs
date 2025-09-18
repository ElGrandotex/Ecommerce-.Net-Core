using Ecommerce.Data;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("sqlstring")));
builder.Services.AddScoped<Ecommerce.Repository.IRepository.ICategoryRepository, Ecommerce.Repository.CategoryRepository>();
builder.Services.AddSingleton(new TypeAdapterConfig());
builder.Services.AddScoped<IMapper, ServiceMapper>();
builder.Services.AddControllers();

// 1. Agrega los servicios de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
