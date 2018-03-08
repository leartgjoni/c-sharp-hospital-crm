using System.Data.Entity;

namespace EPatient.Models
{
    public class EPatientContext : DbContext
    {
        public EPatientContext() : base("name=EPatientDatabaseConnectionString") { }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Pavilion> Pavilions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<EmergencyDoctor> EmergencyDoctors { get; set; }
        
    }
}
