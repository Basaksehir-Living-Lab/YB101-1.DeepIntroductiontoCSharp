namespace _16_Repository_ManagerMantigi.Entities
{
    public class Exam : BaseEntity
    {
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ExamResult>? ExamResults { get; set; }

    }
}
