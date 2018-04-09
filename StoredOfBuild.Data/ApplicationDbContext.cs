using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StoredOfBuild.Domain.Products;

namespace StoredOfBuild.Data {
    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {

        }

        DbSet<Category> Categories { get; set; }
    }
}