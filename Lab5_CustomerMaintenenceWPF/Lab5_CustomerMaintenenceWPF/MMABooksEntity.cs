using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace Lab5_CustomerMaintenenceWPF
{
    public partial class MMABooksEntity : DbContext
    {

        public MMABooksEntity()
            : base("name=BooksEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }



        public DbSet<Customer> Customers { get; set; }
        public DbSet<State> States { get; set; }

    }
}
