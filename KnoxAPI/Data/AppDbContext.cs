using System;
using KnoxAPI.Models;
using KnoxLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace KnoxAPI.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<User> Userss { get; set; }

        public DbSet<Note> Notess { get; set; }
    }
}

