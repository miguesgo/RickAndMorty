using System.ComponentModel.DataAnnotations;

namespace RickAndMorty.Character
{
    public class Character
    {
        [Key]
        public required string Id { get; set; }

        public int CharacterId { get; set; }

        public string? Name { get; set; }

        [Display(Name = "Image URL")]
        public string? ImageUrl { get; set; }

        public string? Species { get; set; }

        public string? Status { get; set; }

        public string? Note { get; set; }
    }
}
