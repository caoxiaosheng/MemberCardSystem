using System.ComponentModel.DataAnnotations.Schema;

namespace MemberCardSystem.Models
{
    public class Gift
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string GiftName { get; set; }
        public int Points { get; set; }
    }
}
