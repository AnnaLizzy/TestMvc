using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Data.Migration.Models.DbContext
{
    public class CertificateDbContextFactory : IDesignTimeDbContextFactory<CertificateDBContext>
    {
        public CertificateDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            #region appsettings
            //Create bien tao ket noi toi appsettings
            var connectionString = configuration.GetConnectionString("Default");
         
            #endregion
            var optionsBuilder = new DbContextOptionsBuilder<CertificateDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CertificateDBContext(optionsBuilder.Options);
        }
        

    }
    
}
