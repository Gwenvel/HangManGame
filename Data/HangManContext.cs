using System;
using HangMan.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HangMan.Data {
    public partial class HangManContext : DbContext {
       public virtual DbSet<Words> Words {get; set;}
       public virtual DbSet<Hang> Hang {get; set;}
       public virtual DbSet<Letters> Letters {get; set;}
       public virtual DbSet<Line> Line {get; set;}

        public HangManContext(DbContextOptions<HangManContext> options) 
            : base(options){
        }

        protected override void OnModelCreating(ModelBuilder build) {
            base.OnModelCreating(build);

            build.Entity<Words>().ToTable("Words");
        }
    }
}