using Microsoft.EntityFrameworkCore;
using ExemploORM.Models;

namespace ExemploORM.Data
{
    public class UserDbContext : DbContext{
    public UserDbContext(DbContextOptions<UserDbContext> options){}
    public DbSet<User>Users {get;set;}
    }    
}
