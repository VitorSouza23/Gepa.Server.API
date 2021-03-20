using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gepa.Server.Application.Teachers.Commands;
using Gepa.Server.Application.Teachers.Queries;
using Gepa.Server.Domain.Teachers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gepa.Server.Apresentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ILogger<TeacherController> _logger;
        private readonly IMediator _mediator;

        public TeacherController(ILogger<TeacherController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            (IEnumerable<Teacher> teachers, Exception ex) = await _mediator.Send(new AllTeachersQuery());
            if (ex is not null)
                return BadRequest(ex);
            return Ok(teachers);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTeacherCommand addTeacherCommand)
        {
            (Teacher teacher, Exception ex) = await _mediator.Send(addTeacherCommand);
            if (ex is not null)
                return BadRequest(ex);
            return Ok(teacher);
        }
    }
}
