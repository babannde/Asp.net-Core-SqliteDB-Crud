using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CoreSqlLite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

//Pre
//Install-Package Microsoft.EntityFrameworkCore.Sqlite
//Install-Package Microsoft.EntityFrameworkCore.Tools
//Install-Package Microsoft.EntityFrameworkCore.Sqlite.Design

//Scaffold-DbContext "Host=localhost;Database=DiscountShopDB;Username=sa;Password=123456789" Npgsql.EntityFrameworkCore.PostgreSQL -o DB -f -UseDatabaseNames
// Scaffold-DbContext "Filename=./mydb.db" Microsoft.EntityFrameworkCore.Sqlite -OutputDir DB -f -UseDatabaseNames