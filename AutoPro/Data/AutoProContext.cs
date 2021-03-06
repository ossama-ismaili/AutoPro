using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AutoPro.Models;

namespace AutoPro.Models
{
    public class AutoProContext : IdentityDbContext<ApplicationUser>
    {
        public AutoProContext (DbContextOptions<AutoProContext> options)
            : base(options)
        {
        }

        public DbSet<Voiture> Voiture { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Proprietaire> proprietaires { get; set; }
        public DbSet<Locataire> locataires { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<Favori> favoris { get; set; }
        public DbSet<Demande> demande { get; set; }

    }
}
