using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.ML;
using Microsoft.IdentityModel.Tokens;
using SmartExpenseTracker.API.Data;
using SmartExpenseTracker.API.Models;
using SmartExpenseTracker.API.Repositories;
using SmartExpenseTracker.API.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IExpenseRepository, ExpenseRepository>();

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 4;
})
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();



builder.Services.AddPredictionEnginePool<Expense, CategoryPrediction>() // Register PredictionEnginePool
    .FromFile(filePath: "MLModel/PredictionModel_20250327_175919.zip", watchForChanges: true);
builder.Services.AddScoped<ExpenseCategorizationService>();
builder.Services.AddScoped<ReceiptAnalysisService>();
builder.Services.AddScoped<AIService>();


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "https://localhost:7011",
        ValidAudience = "http://localhost:4200/",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecretKey"))
    };
});



//builder.Services.AddPredictionEnginePool<Expense, CategoryPrediction>()
//    .FromFile(filePath: "model.zip", watchForChanges: true);


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    await AppDbInitializer.SeedRolesAndAdminAsync(scope.ServiceProvider);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();
app.UseCors("AllowAll");
app.MapControllers();

app.Run();
