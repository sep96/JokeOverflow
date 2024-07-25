namespace Joke.Api.Models
{
    public class Jokes
    {
        public Guid JokeId { get; set; }
        public int JokeTile { get; set; } 
        public string JokeText { get; set; } = default!;
        public DateTime JokeCreateionDate { get; set; } = DateTime.Now;
        public string UserId { get; set; } = default!;

    }
}
