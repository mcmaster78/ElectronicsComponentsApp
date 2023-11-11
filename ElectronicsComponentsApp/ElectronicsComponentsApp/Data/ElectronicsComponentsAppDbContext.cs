using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsComponentsApp.Data;
using ElectronicsComponentsApp.Entities;
using Microsoft.EntityFrameworkCore;
public class ElectronicsComponentsAppDbContext : DbContext
    {
        public DbSet<ElectronicComponent> ElectronicComponent => Set<ElectronicComponent>();
 //       public DbSet<ElectronicComponentDisassembly> ElectronicComponentDisassembly => Set<ElectronicComponentDisassembly>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }

    }

