using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyWebAPI.Models
{
    public class OrderPaymentRequest
    {
        public string id { get; set; }
        public string email { get; set; }
        public string closed_at { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string number { get; set; }
        public string note { get; set; }
        public string token { get; set; }
        public string gateway { get; set; }
        public string test { get; set; }
        public string total_price { get; set; }
        public string subtotal_price { get; set; }
        public string total_weight { get; set; }
        public string total_tax { get; set; }
        public string taxes_included { get; set; }
        public string currency { get; set; }
        public string financial_status { get; set; }
        public string confirmed { get; set; }
        public string total_discounts { get; set; }
        public string total_line_items_price { get; set; }
        public string cart_token { get; set; }
        public string buyer_accepts_marketing { get; set; }
        public string name { get; set; }
        public string referring_site { get; set; }
        public string landing_site { get; set; }
        public string cancelled_at { get; set; }
        public string cancel_reason { get; set; }
        public string total_price_usd { get; set; }
        public string checkout_token { get; set; }
        public string reference { get; set; }
        public string user_id { get; set; }
        public string location_id { get; set; }
        public string source_identifier { get; set; }
        public string source_url { get; set; }
        public string processed_at { get; set; }
        public string device_id { get; set; }
        public string phone { get; set; }
        public string customer_locale { get; set; }
        public string app_id { get; set; }
        public string browser_ip { get; set; }
        public string landing_site_ref { get; set; }
        public string order_number { get; set; }
        public OrderPaymentDiscountApplications discount_applications { get; set; }
        public OrderPaymentDiscountCodes discount_codes { get; set; }
        public OrderPaymentNoteAttributes note_attributes { get; set; }
        public OrderPaymentPaymentGatewayNames payment_gateway_names { get; set; }
        public string processing_method { get; set; }
        public string checkout_id { get; set; }
        public string source_name { get; set; }
        public string fulfillment_status { get; set; }
        public OrderPaymentTaxLines tax_lines { get; set; }
        public string tags { get; set; }
        public string contact_email { get; set; }
        public string order_status_url { get; set; }
        public OrderPaymentLineItems line_items { get; set; }
        public OrderPaymentShippingLines shipping_lines { get; set; }
        public OrderPaymentBillingAddress billing_address { get; set; }
        public OrderPaymentShippingAddress shipping_address { get; set; }
        public OrderPaymentFulfillments fulfillments { get; set; }
        public OrderPaymentRefunds refunds { get; set; }
        public OrderPaymentCustomer customer { get; set; }

    }
}