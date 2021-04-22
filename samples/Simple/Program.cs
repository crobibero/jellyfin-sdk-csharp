﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Jellyfin.Sdk;
using Microsoft.Extensions.DependencyInjection;

namespace Simple
{
    internal static class Program
    {
        private static async Task Main()
        {
            var serviceProvider = ConfigureServices();

            // Initialize the sdk client settings. This only needs to happen once on startup.
            var sdkClientSettings = serviceProvider.GetRequiredService<SdkClientSettings>();
            sdkClientSettings.InitializeClientSettings(
                "My-Jellyfin-Client",
                "0.0.1",
                "Sample Device",
                $"this-is-my-device-id-{Guid.NewGuid():N}");

            var sampleService = serviceProvider.GetRequiredService<SampleService>();
            await sampleService.RunAsync()
                .ConfigureAwait(false);

            Console.WriteLine("Sample complete");
        }

        private static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            // Add Http Client
            serviceCollection.AddHttpClient("Default", c =>
                {
                    c.DefaultRequestHeaders.UserAgent.Add(
                        new ProductInfoHeaderValue(
                            "My-Jellyfin-Client",
                            "0.0.1"));

                    c.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json, 1.0));
                    c.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("*/*", 0.8));
                })
                .ConfigurePrimaryHttpMessageHandler(() => new SocketsHttpHandler
                {
                    AutomaticDecompression = DecompressionMethods.All,
                    RequestHeaderEncodingSelector = (_, _) => Encoding.UTF8
                });

            // Add Jellyfin SDK services.
            serviceCollection
                .AddSingleton<SdkClientSettings>()
                .AddScoped<ISystemClient, SystemClient>()
                .AddScoped<IUserClient, UserClient>()
                .AddScoped<IUserViewsClient, UserViewsClient>()
                .AddScoped<IUserLibraryClient, UserLibraryClient>();

            // Add sample service
            serviceCollection.AddSingleton<SampleService>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}