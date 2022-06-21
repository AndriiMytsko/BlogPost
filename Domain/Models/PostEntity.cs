using System.Collections.Generic;

namespace Entities.Models
{
    public class PostEntity : Entity
    {
        public string Title { get; set; }

        public string Text { get; set; }

        public ICollection<CommentEntity> Comments { get; set; }
        
        public ICollection<PostTag> PostTags { get; set; }
    }
}
