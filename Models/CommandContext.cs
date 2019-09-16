using Microsoft.EntityFrameworkCore;


namespace CmdApi.Models  {

public class CommandContext: DbContext{

  
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CommandAPI;Trusted_Connection=True;MultipleActiveResultSets=true");

        }

    public DbSet<Command> Commands{get;set;}
}

}