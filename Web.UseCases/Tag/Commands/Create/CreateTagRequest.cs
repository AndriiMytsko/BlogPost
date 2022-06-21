using MediatR;
using Web.UseCases.Tag.DTOs;

namespace Web.UseCases.Tag.Commands.Create
{
    public class CreateTagRequest : IRequest<int>
    {
        public CreateTagDto CreateTagDto { get; set; }
    }
}
