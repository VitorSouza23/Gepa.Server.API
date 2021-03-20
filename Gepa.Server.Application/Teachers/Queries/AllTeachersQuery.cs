using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Teachers;
using MediatR;

namespace Gepa.Server.Application.Teachers.Queries
{
    public class AllTeachersQuery : IRequest<(IEnumerable<Teacher>, Exception)>
    {

    }
}