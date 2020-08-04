using AutoMapper;
using DemoDomain.Alunos.Interfaces;
using DemoDomain.Factories;
using DemoDomain.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDomain
{
    public static class DomainDependencyInjection
    {
        public static IServiceCollection AddDomainDependenciesInjection(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(typeof(MapperProfile));
            serviceCollection.AddTransient<IAlunoFactory, AlunoFactory>();
            return serviceCollection;
        }
    }
}
