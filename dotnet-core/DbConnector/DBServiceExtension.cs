using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbConnector
{
    public static class DBServiceExtension
    {
        public static IServiceCollection SetUpDatabase<T>(this IServiceCollection services, IConfiguration configuration) where T : DbContext
        {
            DataBaseOptions dataBaseOptions = new DataBaseOptions();
            configuration.Bind(DataBaseOptions.DataBase, dataBaseOptions);
            services.AddSingleton(dataBaseOptions);

            services.AddDbContext<T>(optionsBuilder => {
                if (!optionsBuilder.IsConfigured && !string.IsNullOrWhiteSpace(dataBaseOptions.ConnectionString))
                {
                    optionsBuilder.UseNpgsql(dataBaseOptions.ConnectionString);
                    //switch (dataBaseOptions.Type)
                    //{
                    //    case "PostgreSQL":
                    //        optionsBuilder.UseNpgsql(dataBaseOptions.DecryptedConnectionString);
                    //        break;
                    //    case "Sqlite":
                    //        optionsBuilder.UseSqlite(dataBaseOptions.DecryptedConnectionString);
                    //        break;
                    //    default:
                    //        optionsBuilder.UseSqlServer(dataBaseOptions.DecryptedConnectionString);
                    //        break;
                    //}
                }
            });

            return services;
        }
    }
}
