using Day02Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02Task.Data
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses")
                .HasKey(C => C.Id);

            builder.Property(c => c.Name)
                .HasMaxLength(50);
            builder.Property(c=> c.MinDegree)
                .HasDefaultValue(50);

            //Relation between Department,Course

            builder.HasOne(C => C.Department)
                .WithMany(D => D.Courses)
                .HasForeignKey(C=>C.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
