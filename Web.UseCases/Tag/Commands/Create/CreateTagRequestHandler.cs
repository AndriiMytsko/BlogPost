using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Interfaces;
using Email.Interfaces;
using Entities.Models;
using MediatR;
using WebApp.Interfaces;

namespace Web.UseCases.Tag.Commands.Create
{
    public class CreateTagRequestHandler : IRequestHandler<CreateTagRequest, int>
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ICurrentUserService _currentUserService;

        public CreateTagRequestHandler(
            IDbContext dbContext,
            IMapper mapper,
            IEmailService emailService,
            ICurrentUserService currentUserService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _emailService = emailService;
            _currentUserService = currentUserService;
        }

        public async Task<int> Handle(CreateTagRequest request, CancellationToken cancellationToken)
        {
            var tag = _mapper.Map<TagEntity>(request.CreateTagDto);
            tag.Name = request.CreateTagDto.Name;

            _dbContext.Tags.Add(tag);

            await _dbContext.SaveChangesAsync(cancellationToken);
            await _emailService.SendEmailAsync(_currentUserService.Email, "Tag created", $"Your tag {tag.Id} created successfully");
            
            return tag.Id;
        }
    }

}
