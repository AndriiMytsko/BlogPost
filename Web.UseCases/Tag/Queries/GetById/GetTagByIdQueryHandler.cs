using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Web.UseCases.Tag.DTOs;

namespace Web.UseCases.Tag.Queries.GetById
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, TagDto>
    {
        private readonly IDbContext _context;
        private readonly IMapper _mapper;

        public GetTagByIdQueryHandler(IDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<TagDto> Handle(GetTagByIdQuery query, CancellationToken cancellationToken)
        {
            var tag = await _context.Tags
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == query.Id, cancellationToken: cancellationToken);

            if (tag == null) throw new EntityNotFoundException();

            var dto = _mapper.Map<TagDto>(tag);

            return dto;
        }
    }
}
