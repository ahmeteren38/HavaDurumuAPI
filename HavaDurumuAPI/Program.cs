
using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccesss.Context;
using Microsoft.EntityFrameworkCore;

namespace HavaDurumuAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //generic<HavaDurumuDbContext>
            builder.Services.AddDbContext<HavaDurumuDbContext>(opt => opt.UseSqlServer("Server=AEC;Database=HavaDurumuDB;Integrated Security=True;TrustServerCertificate=True;"));

            builder.Services.AddScoped<IHavaDurumuService, HavaDurumuService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
