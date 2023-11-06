using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieMiftahul.Models;

namespace MvcMovieMiftahul.Data
{
    public class MvcMovieMiftahulContext : DbContext
    {
        public MvcMovieMiftahulContext (DbContextOptions<MvcMovieMiftahulContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieMiftahul.Models.Movie> Movie { get; set; }
    }
}
