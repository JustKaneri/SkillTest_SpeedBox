using SkillTest_SpeedBox.Models;
using System.ComponentModel.DataAnnotations;

namespace SkillTest_SpeedBox.Dto
{
    public class OrderDTO
    {
        [MinLength(1)]
        public string senderFias { get; set; }
        [MinLength(1)]
        public string receiverFias { get; set; }
        public Good[] goods { get; set; }
    }
}
