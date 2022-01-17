using System.ComponentModel.DataAnnotations;

namespace Command_Keeper.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(350)]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }

        public Command(int id, string howTo, string line, string platform)
        {
            Id = id;
            HowTo = howTo;
            Line = line;
            Platform = platform;
        }
    }
}