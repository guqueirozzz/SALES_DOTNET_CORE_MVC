using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_DOTNET_SALES.Models;

namespace MVC_DOTNET_SALES.Data
{
    public class MVC_DOTNET_SALESContext : DbContext
    {
        public MVC_DOTNET_SALESContext (DbContextOptions<MVC_DOTNET_SALESContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_DOTNET_SALES.Models.Departamento> Departamento { get; set; }
    }
}
