﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using oginshop_doan4.Models;
using System.Reflection;

namespace oginshop_doan4.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}
		public virtual DbSet<News> GetNews { get; set; }
		public virtual DbSet<Product> GetProducts { get; set; }
		public virtual DbSet<Oder> GetOders { get; set; }
		public virtual DbSet<OderDetail> GetOderDetails { get; set; }
		public virtual DbSet<slide> GetBanners { get; set; }
		public virtual DbSet<User> GetUsers { get; set; }
		public virtual DbSet<config> GetConfigs { get; set; }
		public virtual DbSet<Role> GetRoles { get; set; }

		public virtual DbSet<CustomUser> CustomUsers { get; set; }
		
	}
}