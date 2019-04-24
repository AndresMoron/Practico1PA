
using System.Data.Entity;
namespace productoAPI.Models
{
 

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<productoAPI.Models.Product> Products { get; set; }
    }
}