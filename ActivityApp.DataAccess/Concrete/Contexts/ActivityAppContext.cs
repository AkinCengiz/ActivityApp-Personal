using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ActivityApp.DataAccess.Concrete.Contexts;
public class ActivityAppContext : DbContext
{
	public ActivityAppContext(DbContextOptions<ActivityAppContext> options) : base(options)
	{
	}

	public DbSet<Event> Events { get; set; }
	public DbSet<Location> Locations { get; set; }
	public DbSet<Category> Categories { get; set; }
}
