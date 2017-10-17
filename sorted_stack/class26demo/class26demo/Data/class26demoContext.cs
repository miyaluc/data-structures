using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace class26demo.Models
{
    public class class26demoContext : DbContext
    {
        public class26demoContext (DbContextOptions<class26demoContext> options)
            : base(options)
        {
        }

        public DbSet<class26demo.Models.CMS> CMS { get; set; }
    }
}
