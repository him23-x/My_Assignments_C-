using Day02Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02Task.Data
{
    public class TeacherConfigurations : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teachers")
                .HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .HasMaxLength(50);

            builder.Property(t => t.Address)
                .HasMaxLength(50);

            builder.Property(t => t.Salary)
                .HasColumnType("decimal");


            //relations

            builder.HasOne(t => t.Course)
                .WithMany(c => c.Teachers)
                .HasForeignKey(t => t.CourseId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(t => t.Department)
                .WithMany(d => d.Teachers)
                .HasForeignKey(t => t.DepartmentId);

        }
    }
}
