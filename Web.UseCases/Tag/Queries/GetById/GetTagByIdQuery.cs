using MediatR;
using Web.UseCases.Tag.DTOs;

namespace Web.UseCases.Tag.Queries.GetById
{
    public class GetTagByIdQuery : IRequest<TagDto>
    {
        public int Id { get; set; }
    }
}
