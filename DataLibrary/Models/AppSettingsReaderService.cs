using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{

    public static class AppSettingsReaderExtension
    {
        public static IServiceCollection RegisterAppSettingsReader(this IServiceCollection services, IConfiguration Configuration)
        {
            services.Configure<ConnectionStringSection>(Configuration.GetSection("ConnectionStrings"));

            services.AddSingleton<IAppSettingsReaderService, AppSettingsReaderService>();
            return services;
        }
    }
    class AppSettingsReaderService : IAppSettingsReaderService
    {
        private readonly ConnectionStringSection _connectionStringSection;

        public AppSettingsReaderService(IOptions<ConnectionStringSection> optionConnectionString)
        {
            _connectionStringSection = optionConnectionString.Value;
        }

        public ConnectionStringSection connectionStringSection { get { return _connectionStringSection; } }
    }

    public interface IAppSettingsReaderService
    {
        public ConnectionStringSection connectionStringSection { get; }
    }

    public class ConnectionStringSection
    {
        public string SqlConn { get; set; }
    }
}
