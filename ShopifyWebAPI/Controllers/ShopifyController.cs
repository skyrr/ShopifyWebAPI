using Newtonsoft.Json;
using ShopifyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;

namespace ShopifyWebAPI.Controllers
{
    [RoutePrefix("shopify")]
    public class ShopifyController : ApiController
    {
        [HttpPost]
        [Route("сartcreation")]
        public IHttpActionResult CartСreation([FromBody] CartCreationRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("CartСreation", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        [HttpPost]
        [Route("cartupdate")]
        public IHttpActionResult CartUpdate([FromBody] CartUpdateRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("CartUpdate", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        [HttpPost]
        [Route("checkoutcreation")]
        public IHttpActionResult CheckoutCreation([FromBody] CheckoutCreationRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("CheckoutCreation", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        [HttpPost]
        [Route("CheckoutDeletion")]
        public IHttpActionResult CheckoutDeletion([FromBody] CheckoutDeletionRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("CheckoutDeletion", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        [HttpPost]
        [Route("CustomerCreation")]
        public IHttpActionResult CustomerCreation([FromBody] CustomerCreationRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("CustomerCreation", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        [HttpPost]
        [Route("OrderCreation")]
        public IHttpActionResult OrderCreation([FromBody] OrderCreationRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("OrderCreation", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        [HttpPost]
        [Route("orderpayment")]
        public IHttpActionResult OrderPayment([FromBody] OrderPaymentRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("OrderPayment", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        [HttpPost]
        [Route("OrderUpdate")]
        public IHttpActionResult OrderUpdate([FromBody] OrderUpdateRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("OrderUpdate", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        [HttpPost]
        [Route("transaction")]
        public IHttpActionResult TransactionCreation([FromBody] TransactionCreationRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("TransactionCreation", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        [HttpPost]
        [Route("ProductCreation")]
        public IHttpActionResult ProductCreation([FromBody] ProductCreationRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("ProductCreation", requestModel);
            //string documentContents = getDocumentContents(Request.InputStream);
            //fileWriter("TransactionCreationFromStream", documentContents);
            return Ok();
        }

        public void fileWriter(string fileName, string param1)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\files\" + fileName + ".json"))
            {
                // If the line doesn't contain the word 'Second', write the line to the file.
                file.WriteLine(param1);
            }
        }

        public string getDocumentContents(Stream stream)
        {
            string documentContents;
            using (Stream receiveStream = stream)
            {
                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                {
                    documentContents = readStream.ReadToEnd();
                }
            }
            return documentContents;
        }
    }
}