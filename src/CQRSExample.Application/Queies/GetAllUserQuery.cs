using CQRSExample.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Application.Queies
{
    public class GetAllUserQuery:IRequest<IEnumerable<User>>
    {
    }
}
