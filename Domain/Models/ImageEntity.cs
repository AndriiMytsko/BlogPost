namespace Entities.Models
{
    public class ImageEntity : Entity
    {
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public string Type { get; set; }
    }
}
