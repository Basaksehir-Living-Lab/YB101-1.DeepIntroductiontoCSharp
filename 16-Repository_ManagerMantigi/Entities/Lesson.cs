namespace _16_Repository_ManagerMantigi.Entities
{
    public class Lesson : BaseEntity
    {
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public byte Duration { get; set; }
        public string? Content { get; set; }
        public Course? Course { get; set; }
        public string? CourseID { get; set; }

    }
}
