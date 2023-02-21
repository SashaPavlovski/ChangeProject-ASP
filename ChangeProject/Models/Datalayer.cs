using static System.Net.Mime.MediaTypeNames;
using System.Data.Entity;

namespace ChangeProject.Models
{
    public class Datalayer: DbContext
    {
        private static Datalayer data;

        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ChangeProject;Data Source=localhost\\SQLEXPRESS";
        public Datalayer() : base(connectionString)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Datalayer>());
            if (Users.Count() == 0) Seed();
        }


        private void Seed()
        {
            TBUsers User = new TBUsers
            {
                UserFirstName = "UserFirstName",
                UserLastName = "UserLastName",
                Date = DateTime.Now,
                UserEmail = "UserEmail@gmail.com",
                UserName = "UserName",
                UserPassword = "12345",
                UserPhone = "0587508510",                
            };
            Users.Add(User);
            SaveChanges();
        }




        public static Datalayer Data
        {
            get
            {
                if (data == null) data = new Datalayer();

                return data;
            }
        }

        public DbSet<TBUsers> Users { get; set; }

        public DbSet<TBBranches> Branches { get; set; }
        public DbSet<TBOpeningCashRegister> OpeningCashRegister { get; set; }

        public DbSet<TBCashRegisterOperations> CashRegisterOperations { get; set; }
        public DbSet<TBCashRegisterTracking> CashRegisterTracking { get; set; }
        public DbSet<TBClosingCashRegister> ClosingCashRegister { get; set; }
        public DbSet<TBCoinsTypes> CoinsTypes { get; set; }
        public DbSet<TBCustomers> Customers { get; set; }
        public DbSet<TBEmployees> Employees { get; set; }
        public DbSet<TBMainCashRegister> MainCashRegister { get; set; }
        public DbSet<TBSafeMoneyTracking> SafeMoneyTracking { get; set; }
        public DbSet<TBSafeTracking> SafeTracking { get; set; }
        public DbSet<TBTransactions> Transactions { get; set; }

    }
}
