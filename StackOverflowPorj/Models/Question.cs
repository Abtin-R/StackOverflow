namespace StackOverflowPorj.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public int UserId { get; set; }


    }
}
