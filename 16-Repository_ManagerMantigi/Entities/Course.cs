namespace _16_Repository_ManagerMantigi.Entities
{
    public class Course : BaseEntity
    {
        public string? CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? InstructorID { get; set; }

        //Navigation Property
        public Instructor? Instructor { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }
        public ICollection<Registration>? Registrations { get; set; }

        public override string ToString()
        {
            return $"{CourseName} - {StartDate}";
        }

    }
}
