using System;
using System.Threading;
using System.Threading.Tasks;
using Gepa.Server.Application.Teachers.Commands;
using Gepa.Server.Domain.Teachers;
using MediatR;

namespace Gepa.Server.Application.Teachers.Handlers
{
    public class AddTeacherCommandHandler : IRequestHandler<AddTeacherCommand, (Teacher, Exception)>
    {
        private readonly ITeacherRepository _repository;

        public AddTeacherCommandHandler(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public async Task<(Teacher, Exception)> Handle(AddTeacherCommand request, CancellationToken cancellationToken)
        {
            var teacher = new Teacher(Guid.NewGuid(), request.Name, null, null, null);
            return await _repository.AddAsync(teacher);
        }
    }
}