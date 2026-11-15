
namespace MVCQuiz.Models
{
    public class QuizQuestion
    {
        public int Number { get; set; }

        public string Question { get; set; } = "";

        public List<string> Options { get; set; } = new();

        public string CorrectAnswer { get; set; } = "";

        public string Explanation { get; set; } = "";
    }
}
