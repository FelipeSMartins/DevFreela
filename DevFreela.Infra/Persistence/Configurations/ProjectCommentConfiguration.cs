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
    public class ProjectCommentConfiguration : IEntityTypeConfiguration<ProjectComment>
    {
        public void Configure(EntityTypeBuilder<ProjectComment> builder)
        {
            builder
            .HasKey(p => p.Id);

            builder
                .HasOne(p => p.project)
                .WithMany(f => f.comments)
                .HasForeignKey(p => p.idProject);

            builder
                .HasOne(p => p.user)
                .WithMany(f => f.comments)
                .HasForeignKey(p => p.idUser);
        }
    }
}
