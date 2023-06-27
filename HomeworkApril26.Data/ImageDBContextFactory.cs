using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkApril26.Data
{
    public class ImageDBContextFactory: IDesignTimeDbContextFactory<ImageDBContext>
    {
            public ImageDBContext CreateDbContext(string[] args)
            {
                var config = new ConfigurationBuilder()
                   .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), $"..{Path.DirectorySeparatorChar}HomeworkApril26.Web"))
                   .AddJsonFile("appsettings.json")
                   .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true).Build();

                return new ImageDBContext(config.GetConnectionString("ConStr"));
            }
        }
}
