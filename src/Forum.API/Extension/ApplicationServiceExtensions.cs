using Forum.Application.Mapper;
using Forum.Application.Queries.Activities;
using Forum.Domain;
using Forum.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.API.Extension
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config) {
            services.AddDbContext<ForumDbContext>(option => option.UseSqlServer(config.GetConnectionString("Forum_Db")));
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
                });
            });
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Forum.API", Version = "v1" });
            });
            services.AddMediatR(typeof(getListActivitiesHandler).Assembly);
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            return services;
        }
    }
}
