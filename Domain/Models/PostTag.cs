using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class PostTag
    {
        public int PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public PostEntity Post { get; set; }

        public int TagId { get; set; }
        [ForeignKey(nameof(TagId))]
        public TagEntity Tag { get; set; }
    }
}
