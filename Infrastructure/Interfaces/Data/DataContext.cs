using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Interfaces.Data;

public class DataContext(DbContextOptions<DataContext> options) :DbContext(options)
{
    public DbSet<Book> Books {get; set;}
}