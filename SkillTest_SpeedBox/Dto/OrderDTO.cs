using SkillTest_SpeedBox.Models;
using System.ComponentModel.DataAnnotations;

namespace SkillTest_SpeedBox.Dto
{
    public class OrderDTO
    {
        [Range(0, int.MaxValue)]
        public int senderCityPostCode { get; set; }
        [Range(0, int.MaxValue)]
        public int receiverCityPostCode { get; set; }
        public Good[] goods { get; set; }
    }
}
