namespace ShopifyWebAPI.Models
{
    public class OrderPaymentShippingLines
    {
        public string id { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string code { get; set; }
        public string source { get; set; }
        public string phone { get; set; }
        public string requested_fulfillment_service_id { get; set; }
        public string delivery_category { get; set; }
        public string carrier_identifier { get; set; }
        public string discounted_price { get; set; }
        public OrderPaymentLineItemsDiscountAllocations discount_allocations { get; set; }
        public OrderPaymentLineItemsTaxLines tax_lines { get; set; }

    }
}