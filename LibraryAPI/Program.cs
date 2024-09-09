
using FluentValidation;
using LibraryAPI.Data;
using LibraryAPI.Endpoints;
using LibraryAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LibraryAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>( options => 
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnection"));
            });
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddAutoMapper(typeof(MappingDTOConfigurations));
            builder.Services.AddValidatorsFromAssemblyContaining<Program>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.ConfigurationBookEndpoints();
            app.Run();
        }
    }
}
