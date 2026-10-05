using System;

namespace HealthCareSystem.Models
{
    // Join entity for the Patient <-> Doctor many-to-many relationship
    public class Appointment
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; } = null!;

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;

        public DateTime AppointmentDate { get; set; }
    }
}
