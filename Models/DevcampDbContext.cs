using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Devcamp.API.Models
{
  public class DevcampDbContext : DbContext
  {

    public DevcampDbContext(DbContextOptions<DevcampDbContext> options) : base(options) { }

    public DbSet<Module> Modules { get; set; }
  }
}