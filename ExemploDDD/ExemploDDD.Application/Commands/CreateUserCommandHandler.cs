using ExemploDDD.Domain.Entity;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExemploDDD.Application.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, User>
    {
        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            //TODO: Verifica se o usuário está no banco e retorna exception caso esteja (ou faz qualquer outra coisa)...

            var user = new User(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password
            );

            //TODO: Grava o usuário no banco e popula campo ID

            //TODO: Envia e-mail

            return user;
        }
    }
}
