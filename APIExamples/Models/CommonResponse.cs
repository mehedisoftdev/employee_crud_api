namespace APIExamples.Models
{
    public class CommonResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
