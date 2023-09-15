namespace SkillTest_SpeedBox.Models
{
    public class Order
    {
        public string version { get; set; }
        public string dateExecute { get; set; }
        public int senderCityPostCode { get; set; }
        public int receiverCityPostCode { get; set; }
        public int tariffId { get; set; }
        public Good[] goods { get; set; }
        public Service[] services { get; set; }
    }
}
