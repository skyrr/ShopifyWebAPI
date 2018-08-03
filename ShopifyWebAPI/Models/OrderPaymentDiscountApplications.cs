using System.Collections;

namespace ShopifyWebAPI.Models
{
    public class OrderPaymentDiscountApplications
    {
        public string type { get; set; }
        public string value { get; set; }
        public string value_type { get; set; }
        public string allocation_method { get; set; }
        public string target_selection { get; set; }
        public string target_type { get; set; }
        public string description { get; set; }
        public string title { get; set; }
    }
}