using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Invoicing.Models;

namespace Invoicing.Data
{
    public class InvoicingContext : DbContext
    {
        public InvoicingContext (DbContextOptions<InvoicingContext> options)
            : base(options)
        {
        }

        public DbSet<Invoicing.Models.Invoice> Invoice { get; set; } = default!;
    }
}
