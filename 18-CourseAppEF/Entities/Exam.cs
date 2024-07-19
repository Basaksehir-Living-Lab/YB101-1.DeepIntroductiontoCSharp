namespace _18_CourseAppEF.Entities
{
    public class Exam : BaseEntity
    {
        public string? Name { get; set; }
        public DateOnly ExamDate { get; set; }
        public ICollection<ExamResult>? ExamResults { get; set; }
    }
}
