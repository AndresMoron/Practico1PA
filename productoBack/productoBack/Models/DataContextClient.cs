
namespace productoBack.Models
{
    using System.Data.Entity;

    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<productoBack.Client> Clients { get; set; }
    }
}