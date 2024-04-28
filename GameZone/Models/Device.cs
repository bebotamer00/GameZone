using System.ComponentModel.DataAnnotations;

namespace GameZone.Models
{
    public class Device : BaseModel
    {
        [MaxLength(50)]
        public string Icon { get; set; } = string.Empty;
    }
}
