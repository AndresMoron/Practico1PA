
namespace productoAPI.Models
{
    using System.Data.Entity;

    public class DataContextSale:DbContext
    {
        public DataContextSale():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<productoAPI.Models.Sale> Sales { get; set; }
    }
}