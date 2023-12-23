using CQRSExample.Domain.Entities;
using CQRSExample.Domain.IRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Application.Queies.QueryHandlers
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, IEnumerable<User>>
    {
        private readonly IUserRepository _user;
        public GetAllUserQueryHandler(IUserRepository user)
        {
            _user = user;
        }
        public async Task<IEnumerable<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return await _user.GetAllUsers();

        }
    }
}
