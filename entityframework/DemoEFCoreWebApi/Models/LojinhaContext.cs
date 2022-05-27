using Microsoft.EntityFrameworkCore;
namespace DemoEFCoreWebApi.Models;

public class LojinhaContext: DbContext
{
    public LojinhaContext()
    {
    }

    public LojinhaContext(DbContextOptions<LojinhaContext> options)
    : base(options)
    {
    }
}