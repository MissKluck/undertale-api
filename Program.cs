using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;

namespace undertale_api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDistributedMemoryCache();
        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(30);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Undertale API", Version = "v1" });
        });
        builder.Services.AddSession();

        //Add cors so that the frontend and backend servers communicate with each other despite being on different localhosts
        builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .WithExposedHeaders("Content-Disposition");
                });
            });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        // makes sure we use swagger
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();

        }

        app.UseHttpsRedirection();
        app.UseCors("AllowAll");
        app.UseSession();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
