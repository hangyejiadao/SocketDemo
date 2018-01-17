using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace webapi.Controllers
{

    public class ValuesController : ApiController
    {
        private static int num = 0;
        // GET api/values
        public string Get()
        {
            string url = "http://localhost:2241/api/Values/Get";
            Dictionary<string, dynamic> args = new Dictionary<string, dynamic>();
            args.Add("value", "daf");
            num++;
            Debug.Write(num);
            HttpHelper.Request(url, null, Encoding.UTF8, null, HttpMethod.GET);
            return num.ToString();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return value;
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return "Id=" + id + " values=" + value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
