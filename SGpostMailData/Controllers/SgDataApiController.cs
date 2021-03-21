using Newtonsoft.Json;
using SGpostMailData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGpostMailData.Controllers
{
    public class SgDataApiController : ApiController
    {

        DatabaseContext _context = new DatabaseContext();

        
        [Route("api/v1/getSheet/{mobile}")]
        public IHttpActionResult GetSheet(string mobile)
        {
            var getSGData = _context.sgDatas.Where(s => s.mobile == mobile).ToList();
            return Json(getSGData);
  
        }

        [HttpPost]
        [Route("api/v1/sgData/{endPointId}")]
        public async System.Threading.Tasks.Task<HttpResponseMessage> PostAsync(string endPointId, HttpRequestMessage request)
        {
            var GetUserDetails = _context.users.Where(u => u.EndpointId == endPointId).SingleOrDefault();

            var jsonString = await request.Content.ReadAsStringAsync();

            var item = JsonConvert.DeserializeObject<List<SgData>>(jsonString);

            foreach(var val in item)
            {
                val.end_point_id = GetUserDetails.EndpointId;
                val.mobile = GetUserDetails.Mobile;

                _context.sgDatas.Add(val);
                _context.SaveChanges();
            }

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Success Dude!")
            };

        }

    }
}
