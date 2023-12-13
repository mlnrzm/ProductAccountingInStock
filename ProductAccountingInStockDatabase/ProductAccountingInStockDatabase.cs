using Microsoft.EntityFrameworkCore;
using ProductAccountingInStockDatabase.DatabaseModels;

namespace ProductAccountingInStockDatabase
{
    public class ProductAccountingInStockDatabase : DbContext
    {
        public ProductAccountingInStockDatabase()
        {
            //Database.EnsureDeleted(); // удаляем бд со старой схемой
            //Database.EnsureCreated(); // создаем бд с новой схемой
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-Q2JQENQ\SQLEXPRESS;
                Initial Catalog=ProductAccountingInStockDatabase;
                Integrated Security=True;
                MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Post> Posts { set; get; }
        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Provider> Providers { set; get; }
        public virtual DbSet<Product> Products { set; get; }
        public virtual DbSet<Shipment> Shipments { set; get; }
        public virtual DbSet<ShipmentProduct> ShipmentProducts { set; get; }
        public virtual DbSet<DirectionShipment> DirectionShipments { set; get; }
    }
}
