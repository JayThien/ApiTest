using EntityModelsMigrationService.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityModelsMigrationService.Models
{
    public class ApiTestContext : DbContext
    {
        public ApiTestContext(DbContextOptions<ApiTestContext> options) : base(options)
        {

        }

        DbSet<Employee> Employee { get; set; }
        DbSet<Company> Company { get; set; }
    }
}
