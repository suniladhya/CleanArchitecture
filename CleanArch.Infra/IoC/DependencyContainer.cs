using cleanArch.Infra.Bus;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.EntityCommands;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            //Domain InMemoryBus
            serviceCollection.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            serviceCollection.AddScoped<IRequestHandler<CreateCourseCommand,bool>, CourseCommandHandler>();
            
            //Application Layer
            serviceCollection.AddScoped<ICourseService, CourseService>();

            // Infra.Data Layer
            serviceCollection.AddScoped<ICourseRepository, CourseRepository>();

            serviceCollection.AddScoped<ICourseRepository, CourseRepository>();
            serviceCollection.AddScoped<UniversityDBContext>();
        }
    }
}
