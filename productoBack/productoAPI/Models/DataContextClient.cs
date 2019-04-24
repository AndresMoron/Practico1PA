using System.Data.Entity;

namespace productoAPI.Models
{
  

    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<productoAPI.Client> Clients { get; set; }
    }
}