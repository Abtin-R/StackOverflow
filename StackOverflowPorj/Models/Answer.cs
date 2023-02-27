namespace StackOverflowPorj.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        
    }
}
