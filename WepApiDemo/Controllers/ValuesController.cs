using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WepApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> values = new List<string>()
        {
            "values1","values2","values3"
        };
        // GET: api/Values
        public IEnumerable<string> Get()
        {
            return values.ToList();
        }

        // GET: api/Values/5
        public string Get(int id)
        {
            return values[id];
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
             values.Add(value);
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
            values[id] = value;
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
            values[id].Remove(id);
        }
    }
}
