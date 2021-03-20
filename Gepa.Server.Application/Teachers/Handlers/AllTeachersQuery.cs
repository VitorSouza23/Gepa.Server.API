using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Gepa.Server.Application.Teachers.Queries;
using Gepa.Server.Domain.Teachers;
using MediatR;

namespace Gepa.Server.Application.Teachers.Handlers
{
    public class AllTeachersQueryHandler : IRequestHandler<AllTeachersQuery, (IEnumerable<Teacher>, Exception)>
    {
        private readonly ITeacherRepository _repository;

        public AllTeachersQueryHandler(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public async Task<(IEnumerable<Teacher>, Exception)> Handle(AllTeachersQuery request, CancellationToken cancellationToken)
        {
            return await _repository.FindAllAsync();
        }
    }
}