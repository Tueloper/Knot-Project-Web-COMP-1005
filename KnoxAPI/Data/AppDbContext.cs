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

		public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }
    }
}

