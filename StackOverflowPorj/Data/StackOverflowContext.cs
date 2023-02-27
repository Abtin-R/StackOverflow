using Microsoft.EntityFrameworkCore;
using StackOverflowPorj.Models;

namespace StackOverflowPorj.Data
{
    public class StackOverflowContext : DbContext
    {
        public DbSet<Answer> Answer { get; set; }
        public DbSet<AnswerComment> AnswerComment { get; set; }
        public DbSet<Question> Question { get; set; }  
        public DbSet<QuestionComment> QuestionComment { get; set; }
        public DbSet<QuestionTag> QuestionTag { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<User> User { get; set; }

        public StackOverflowContext() { }

        public StackOverflowContext(DbContextOptions<StackOverflowContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Database=StackOverflowDb;Integrated Security=false;User ID=sa;Password=1234;TrustServerCertificate=true");
        }
    }
}
