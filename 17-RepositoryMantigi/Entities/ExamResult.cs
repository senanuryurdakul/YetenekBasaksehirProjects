namespace _17_RepositoryMantigi.Entities
{
    public class ExamResult
    {
        public byte Grade { get; set; }
        public string? ExamID { get; set; }
        public string? StudentID { get; set; }
        public Student? Student { get; set; }
        public Exam? Exam { get; set; }
    }
}
