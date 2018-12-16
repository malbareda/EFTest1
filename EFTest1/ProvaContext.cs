using System.Data.Entity;

namespace EFTest1
{
    public class ProvaContext : DbContext
    {
        public ProvaContext() : base("Test")
        {

        }

        public DbSet<Professor> Professor { get; set; }
        public DbSet<Modul> Modul { get; set; }
        public DbSet<Curs> Curs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists); //update, pero crea la DB!
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProvaContext>());  //aquest seria un metode update pero si canvies el model (els POCOS) reinicia la DB
            Database.SetInitializer(new DropCreateDatabaseAlways<ProvaContext>());  //equivaldria a un create
            

            base.OnModelCreating(modelBuilder);
        }

    }
}
