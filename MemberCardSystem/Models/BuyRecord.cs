using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberCardSystem.Models
{
    public class BuyRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CardId { get; set; }
        public string Record { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
