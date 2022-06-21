using System.Collections.Generic;

namespace Entities.Models
{
    public class TagEntity : Entity
    {
        public string Name { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }
}
