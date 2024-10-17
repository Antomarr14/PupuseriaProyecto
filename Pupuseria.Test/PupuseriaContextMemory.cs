using Microsoft.EntityFrameworkCore;

public static class PupuseriaContextMemory<TContext> where TContext : DbContext
{
    public static TContext CreateDbContext(string dbName)
    {
        var options = new DbContextOptionsBuilder<TContext>()
            .UseInMemoryDatabase(databaseName: dbName)
            .Options;

        return (TContext)Activator.CreateInstance(typeof(TContext), options);
    }
}