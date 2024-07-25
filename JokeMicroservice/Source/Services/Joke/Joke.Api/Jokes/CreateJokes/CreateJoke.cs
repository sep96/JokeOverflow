using MediatR;

namespace Joke.Api.Jokes.CreateJokes
{
    public record CreateJokeCommand(string JokeTile , string JokeText , string UserId)
        :IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateJokeCommandHandler : IRequestHandler<CreateJokeCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateJokeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
