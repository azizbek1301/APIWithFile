using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FileAPI.Entities
{
    public class ProfileTeacher
    {
        // jsonga chiqarmedi
        [JsonIgnore]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = default!;

        // Bu jsonga ko'rsatilmedi ko'rinmedi
        [JsonIgnore]
        public string ImageUrl {  get; set; }

        // Bu bazaga qo'shilmedi
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
