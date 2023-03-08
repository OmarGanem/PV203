using System.Data.Entity;

namespace PV203.Data
{
    public class DataContext :DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Provider> Provider { get; set; }
        DbSet<Product> Product { get; set; }
        public DataContext():base("name=con")
        { 
          
        }
    }
}
