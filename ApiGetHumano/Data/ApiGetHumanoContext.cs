using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiGetHumano.Modelo;

namespace ApiGetHumano.Data
{
    public class ApiGetHumanoContext : DbContext
    {
        public ApiGetHumanoContext (DbContextOptions<ApiGetHumanoContext> options)
            : base(options)
        {
        }

        public DbSet<ApiGetHumano.Modelo.Humano> Humano { get; set; }
    }
}
