using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class CommentEntity : Entity
    {
        public string Text { get; set; }

        public int PostId { get; set; }

        [ForeignKey(nameof(PostId))]
        public PostEntity Post { get; set; }
    }
}