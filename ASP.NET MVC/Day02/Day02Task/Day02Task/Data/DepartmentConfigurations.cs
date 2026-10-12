using Day02Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02Task.Data
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments")
            .HasKey(d => d.Id);

            builder.Property(d => d.Name)
                .HasMaxLength(50);
            builder.Property(d=> d.MgrName)
                .HasMaxLength(50);


            ////Relation between department, student
            //builder.HasMany(d => d.Students)
            //    .WithOne(s => s.Department);


        }
    }
}
