using Entity;
using Microsoft.EntityFrameworkCore;
namespace Datos
{
    public class ProductoAlmacenadoContext:DbContext 
    {
        public ProductoAlmacenadoContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Panela> AlmacenamientoProducto{get;set;}
    }
}