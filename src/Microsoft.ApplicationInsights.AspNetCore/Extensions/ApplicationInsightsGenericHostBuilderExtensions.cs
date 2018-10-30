#if NETSTANDARD2_0
namespace Microsoft.Extensions.Hosting
{
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Extension methods for <see cref="IHostBuilder"/> that allow adding Application Insights services to application.
    /// </summary>
    public static class ApplicationInsightsGenericHostBuilderExtensions
    {
        /// <summary>
        /// Configures <see cref="IHostBuilder"/> to use Application Insights services.
        /// </summary>
        /// <param name="hostBuilder">The <see cref="IHostBuilder"/> instance.</param>
        /// <returns>The <see cref="IHostBuilder"/>.</returns>
        public static IHostBuilder UseApplicationInsights(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices(collection =>
            {
                collection.AddGenericApplicationInsightsTelemetry();
            });

            return hostBuilder;
        }

        /// <summary>
        /// Configures <see cref="IHostBuilder"/> to use Application Insights services.
        /// </summary>
        /// <param name="hostBuilder">The <see cref="IHostBuilder"/> instance.</param>
        /// <param name="instrumentationKey">Instrumentation key to use for telemetry.</param>
        /// <returns>The <see cref="IHostBuilder"/>.</returns>
        public static IHostBuilder UseApplicationInsights(this IHostBuilder hostBuilder, string instrumentationKey)
        {
            hostBuilder.ConfigureServices(collection =>
            {
                collection.AddGenericApplicationInsightsTelemetry(instrumentationKey);
            });

            return hostBuilder;
        }
    }
}
#endif