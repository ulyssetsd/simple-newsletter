using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace simple_newsletter.Models
{
    public class simple_newsletterContext : DbContext
    {
        public simple_newsletterContext (DbContextOptions<simple_newsletterContext> options)
            : base(options)
        {
        }

        public DbSet<simple_newsletter.Models.Subscriber> Subscriber { get; set; }
    }
}
