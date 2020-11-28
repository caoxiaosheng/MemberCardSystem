using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberCardSystem.Models
{
    public class Card
    {
        public string CardId { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public CardType CardType { get; set; }
        public int Points { get; set; }
        public int Money { get; set; }
        public bool IsActive { get; set; }
    }

    public enum CardType
    {
        积分卡,
        储值卡
    }
}
