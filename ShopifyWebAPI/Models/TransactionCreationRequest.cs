using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyWebAPI.Models
{
    public class TransactionCreationRequest
    {
        public string id { get; set; }
        public string order_id { get; set; }
        public string amount { get; set; }
        public string kind { get; set; }
        public string gateway { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public string created_at { get; set; }
        public string test { get; set; }
        public string authorization { get; set; }
        public string currency { get; set; }
        public string location_id { get; set; }
        public string user_id { get; set; }
        public string parent_id { get; set; }
        public string device_id { get; set; }
        public string error_code { get; set; }
        public string source_name { get; set; }
        public TransactionCreationReciept Reciept { get; set; }
        public TransactionCreationPaymentDetails payment_details { get; set; }

        
    }
}