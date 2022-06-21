using System.Threading;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Interfaces
{
    public interface IDbContext
    {
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<ImageEntity> Images { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
