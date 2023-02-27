namespace StackOverflowPorj.Models
{
    public class QuestionComment
    {
        public int Id { get; set; } 
        public int QuestionId { get; set; }
        public string Comment { get; set; }
    }
}
