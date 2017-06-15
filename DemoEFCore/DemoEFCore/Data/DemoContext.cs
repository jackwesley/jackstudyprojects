using DemoEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFCore.Data
{
    public class DemoContext : DbContext
    {


        public DemoContext(DbContextOptions options)
            : base(options)
        {

        }

        public DemoContext()
               : base()
        {

        }

 
        public DbSet<Evento> Eventos { get; set; }
    }
}
