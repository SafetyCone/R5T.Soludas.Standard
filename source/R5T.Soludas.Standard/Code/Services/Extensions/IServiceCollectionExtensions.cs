using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.Standard;
using R5T.Dacia;
using R5T.Soludas.Bath;
using R5T.Soludas.Default;


namespace R5T.Soludas.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFileValueEqualityComparer"/> and <see cref="R5T.Vandalia.IValueEqualityComparer{T}"/>, T: <see cref="R5T.Cambridge.Types.SolutionFile"/> services.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileValueEqualityComparer(this IServiceCollection services)
        {
            services.AddDefaultVisualStudioSolutionFileValueEqualityComparer(
                services.AddBathVisualStudioSolutionFileValueEqualityComparerAction(
                    services.AddHumanOutputAction()))
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFileValueEqualityComparer"/> and <see cref="R5T.Vandalia.IValueEqualityComparer{T}"/>, T: <see cref="R5T.Cambridge.Types.SolutionFile"/> services.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileValueEqualityComparer> AddVisualStudioSolutionFileValueEqualityComparerAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileValueEqualityComparer>(() => services.AddVisualStudioSolutionFileValueEqualityComparer());
            return serviceAction;
        }
    }
}
