namespace ShopifyWebAPI.Models
{
    public class OrderPaymentCustomer
    {
        public string id { get; set; }
        public string email { get; set; }
        public string accepts_marketing { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string orders_count { get; set; }
        public string state { get; set; }
        public string total_spent { get; set; }
        public string last_order_id { get; set; }
        public string note { get; set; }
        public string verified_email { get; set; }
        public string multipass_identifier { get; set; }
        public string tax_exempt { get; set; }
        public string phone { get; set; }
        public string tags { get; set; }
        public string last_order_name { get; set; }
        public OrderPaymentCustomerDefaultAddress default_address { get; set; }
    }
}