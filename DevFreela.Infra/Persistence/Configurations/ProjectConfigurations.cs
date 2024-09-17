using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infra.Persistence.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder
                .HasKey(p => p.Id);

            builder
                .HasOne(p => p.freelancer)
                .WithMany(f => f.freeLanceProjects)
                .HasForeignKey(p => p.idFreeLancer)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.client)
                .WithMany(f => f.ownedProjects)
                .HasForeignKey(p => p.idClient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
