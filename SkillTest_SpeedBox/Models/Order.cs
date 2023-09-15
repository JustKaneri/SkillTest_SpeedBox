namespace SkillTest_SpeedBox.Models
{
    public class Order
    {
        public string version { get; set; }
        public string dateExecute { get; set; }
        public int senderCityId { get; set; }
	    public int receiverCityId { get; set; }
        public int tariffId { get; set; }
        public Good[] goods { get; set; }
        public Service[] services { get; set; }
    }
}
