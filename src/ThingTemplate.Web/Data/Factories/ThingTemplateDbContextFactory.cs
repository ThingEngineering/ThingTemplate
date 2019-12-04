using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThingTemplate.Web.Data
{
    public class ThingTemplateDbContextFactory : IDesignTimeDbContextFactory<ThingTemplateDbContext>
    {
        public ThingTemplateDbContext CreateDbContext(string[] args) => new ThingTemplateDbContext("Host=localhost;Port=26875;Username=framething;Password=topsecret");
    }
}
