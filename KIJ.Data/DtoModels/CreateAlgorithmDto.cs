using System.ComponentModel.DataAnnotations;

namespace KIJ.Data.DtoModels
{
    public class CreateAlgorithmDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        [Required]
        public string Implementation { get; set; }

        public string? Notes { get; set; }
    }
}
