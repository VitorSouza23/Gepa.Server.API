using System;
using Gepa.Server.Domain.Teachers;
using MediatR;

namespace Gepa.Server.Application.Teachers.Commands
{
    public class AddTeacherCommand : IRequest<(Teacher, Exception)>
    {
        public string Name { get; set; }
    }
}