using MediatR;

namespace CQRSExample.Application.Commands
{
    public class CreateUserCommand :IRequest<bool>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
