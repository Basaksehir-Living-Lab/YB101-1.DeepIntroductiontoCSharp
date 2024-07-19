namespace _16_Repository_ManagerMantigi.Entities
{
    public class ExamResult : BaseEntity
    {
        public byte Grade { get; set; }
        public Exam? Exam { get; set; }
        public string? ExamID { get; set; }
        public Student? Student { get; set; }
        public string? StudentID { get; set; }

    }
}
