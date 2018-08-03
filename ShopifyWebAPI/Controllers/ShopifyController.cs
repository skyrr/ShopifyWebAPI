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
    public class ShopifyController : ApiController
    {
        [HttpPost]
        public IHttpActionResult TransactionCreation([FromBody] TransactionCreationRequest request)
        {
            string requestModel = JsonConvert.SerializeObject(request);
            fileWriter("TransactionCreationFromRequest", requestModel);
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