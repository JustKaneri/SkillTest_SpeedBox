using System.ComponentModel.DataAnnotations;

namespace SkillTest_SpeedBox.Models
{
    public class Good
    {
        [Range(0, int.MaxValue)]
        public float weight { get; set; }
        [Range(0, int.MaxValue)]
        public int length { get; set; }
        [Range(0, int.MaxValue)]
        public int width { get; set; }
        [Range(0, int.MaxValue)]
        public int height { get; set; }
    }
}
