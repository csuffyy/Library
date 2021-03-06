using Library.Service.Rental.Domain.DataAccessors;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Library.Service.Rental
{
    public class AppsettingRentalReadDBConnectionStringProvider : IRentalReadDBConnectionStringProvider
    {
        private IConfigurationRoot _configuration = null;

        public AppsettingRentalReadDBConnectionStringProvider()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            _configuration = builder.Build();
        }

        public string ConnectionString
        {
            get
            {
                return _configuration["rentalReadDBConnectionString"];
            }
        }
    }

    public class AppsettingRentalWriteDBConnectionStringProvider : IRentalWriteDBConnectionStringProvider
    {
        private IConfigurationRoot _configuration = null;

        public AppsettingRentalWriteDBConnectionStringProvider()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            _configuration = builder.Build();
        }

        public string ConnectionString
        {
            get
            {
                return _configuration["rentalWriteDBConnectionString"];
            }
        }
    }
}