using BusinessLogic.Math;
using BusinessLogic.Math.Factory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Infrastructure
{
    public static class MathServiceCollection
    {
        public static IServiceCollection RegisterMathServices(this IServiceCollection services)
        {
            services.AddScoped<AddOperator>();
            services.AddScoped<SubtractOperator>();
            services.AddScoped<MultiplyOperator>();
            services.AddScoped<DivideOperator>();

            services.AddScoped<ICalculateStrategyFactory, CalculateStrategyFactory>();
            services.AddScoped<ICalculatorStrategy, CalculatorStrategy>();
            services.AddScoped<ICalculator, AddOperator>();
            services.AddScoped<ICalculator, SubtractOperator>();
            services.AddScoped<ICalculator, MultiplyOperator>();
            services.AddScoped<ICalculator, DivideOperator>();

            services.AddScoped(provider =>
            {
                var factory = (ICalculateStrategyFactory)provider.GetService(typeof(ICalculateStrategyFactory));
                return factory.Create();
            });
            return services;
        }
    }
}
