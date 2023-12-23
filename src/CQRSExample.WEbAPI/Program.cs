
using CQRSExample.Application.Commands;
using CQRSExample.Application.Commands.CommandHandlers;
using CQRSExample.Application.Queies;
using CQRSExample.Application.Queies.QueryHandlers;
using CQRSExample.Domain.Entities;
using CQRSExample.Domain.IRepositories;
using CQRSExample.Infrastructure.Common;
using CQRSExample.Infrastructure.Reposities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSExample.WEbAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<ApplicationDbContext>(
            x => x.UseSqlServer(
                 builder.Configuration.GetConnectionString("DefualtConnection")));



            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IRequestHandler<CreateUserCommand, bool>, CreateUserCommandHandler>();
            builder.Services.AddScoped<IRequestHandler<GetAllUserQuery,IEnumerable<User>>,GetAllUserQueryHandler>();




            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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