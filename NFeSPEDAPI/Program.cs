using Microsoft.EntityFrameworkCore;
using NFeSPEDAPI.Data;
using NFeSPEDAPI.Services;

namespace NFeSPEDAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
         //Configura o PostgreSQL
        builder.Services.AddDbContext<AppDbContextPg>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

         //Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        

        builder.Services.AddScoped<INFeService, NFeService>();
        builder.Services.AddScoped<ISpedService, SpedService>();


        var app = builder.Build();
        
        // using (var scope = app.Services.CreateScope())
        // {
        //     //var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        //     //db.Database.Migrate();
        // }

    
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}