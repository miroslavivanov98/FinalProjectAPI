using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BodyCalculatorREST.Controllers
{
    public class BodyCalculatorController : ApiController
    {

        [HttpGet]
        [Route("api/calculator")]
        public HttpResponseMessage CalcGet([FromUri] string weight, [FromUri] string height, [FromUri] string gender)
        {
            var result = DLL.Results.Calculate(weight, height ,gender);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }



        [HttpPost]
        [Route("api/calculator/")]
        public HttpResponseMessage CalcPost([FromBody] DataObject obj)
        {
            var result = DLL.Results.Calculate(obj.weight, obj.height, obj.gender);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("api/calculator/{gender}/{weight}/{height}")] //api/calculator/male/100/180
        public HttpResponseMessage CalcPost(string weight , string height, string gender)
        {
            var result = DLL.Results.Calculate(weight, height, gender);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }

    public class DataObject
    {
        public string weight { get; set; }
        public string height { get; set; }
        public string gender { get; set; }
    }

    //public class ResultObject
    //{
    //    public int result { get; set; }
    //    public int result2 { get; set; }
    //    public string obshtRezultat { get; set; }
    //    public string weight { get; set; }

    //}
}