
namespace productoAPI.Models
{
    using System.Data.Entity;

    public class DataContextSale:DbContext
    {
        public DataContextSale():base("DefaultConnection")
        {

        }
        
    }
}