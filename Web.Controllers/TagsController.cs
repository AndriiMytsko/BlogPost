using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.UseCases.Tag.Commands.Create;
using Web.UseCases.Tag.DTOs;
using Web.UseCases.Tag.Queries.GetById;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ISender _sender;

        public TagsController(ISender sender)
        {
            _sender = sender;
        }


        [HttpGet("{id}")]
        public async Task<TagDto> Get(int id)
        {
            var result = await _sender.Send(new GetTagByIdQuery { Id = id });
            return result;
        }


        [HttpPost]
        public async Task<int> Create([FromBody] CreateTagDto dto)
        {
            var id = await _sender.Send(new CreateTagRequest { CreateTagDto = dto });
            return id;
        }
    }
}
