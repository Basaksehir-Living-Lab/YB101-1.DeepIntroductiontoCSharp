namespace _16_Repository_ManagerMantigi.Entities
{
    public class Student : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FullName => $"{Name} {Surname}";
        public DateOnly BirthDate { get; set; }
        public string? TC { get; set; }
        public ICollection<Registration>? Registrations { get; set; }
        public ICollection<ExamResult>? ExamResults { get; set; }

        public override string ToString()
        {
            return $"{TC} / {FullName}";
        }
    }
}
