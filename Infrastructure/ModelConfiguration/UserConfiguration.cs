using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ModelConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("users");
            builder.HasKey(x=>x.id);
            builder.Property(x=>x.id).ValueGeneratedOnAdd().IsRequired();

            builder.Property(x=>x.userName).IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.password).IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(x => x.name).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.email).IsRequired().HasColumnType("nvarchar(100)");
        }
    }
}
