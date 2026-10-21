using Day02Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02Task.Data
{
    public class StuCrsResConfigurations : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(EntityTypeBuilder<StuCrsRes> builder)
        {
            builder.ToTable("StudentCourseResults")
                .HasKey(x => x.Id);

            //relations
            builder.HasOne(sc => sc.Student)
                .WithMany(s => s.StuCrsRes)
                .HasForeignKey(sc => sc.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(sc => sc.Course)
                .WithMany(c => c.StuCrsRes)
                .HasForeignKey(sc => sc.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
