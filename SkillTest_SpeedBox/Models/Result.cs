namespace SkillTest_SpeedBox.Models
{
    public class Result
    {
        public string price { get; set; }
        public int deliveryPeriodMin { get; set; }
        public int deliveryPeriodMax { get; set; }
        public int tariffId { get; set; }
        public string currency { get; set; }
        public float priceByCurrency { get; set; }
        public int percentVAT { get; set; }
        public Service[] services { get; set; }

        public class Service
        {
            public int id { get; set; }
            public string title { get; set; }
            public float price { get; set; }
        }
    }
}
