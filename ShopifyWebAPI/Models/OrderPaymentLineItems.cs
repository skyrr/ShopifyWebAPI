namespace ShopifyWebAPI.Models
{
    public class OrderPaymentLineItems
    {
        public string id { get; set; }
        public string variant_id { get; set; }
        public string title { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        public string sku { get; set; }
        public string variant_title { get; set; }
        public string vendor { get; set; }
        public string fulfillment_service { get; set; }
        public string product_id { get; set; }
        public string requires_shipping { get; set; }
        public string taxable { get; set; }
        public string gift_card { get; set; }
        public string name { get; set; }
        public string variant_inventory_management { get; set; }
        public OrderPaymentLineItemsProperties properties { get; set; }
        public string product_exists { get; set; }
        public string fulfillable_quantity { get; set; }
        public string grams { get; set; }
        public string total_discount { get; set; }
        public string fulfillment_status { get; set; }
        public OrderPaymentLineItemsDiscountAllocations discount_allocations { get; set; }
        public OrderPaymentLineItemsTaxLines tax_lines { get; set; }
    }
}