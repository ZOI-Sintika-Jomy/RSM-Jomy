//using eKYC.UI.Filters;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Caching.Distributed;
//using Microsoft.Extensions.Configuration;
//using Nancy;
//using RSM.BAL.Services.Interface;
//using RSM.BAL.Utilities;
//using System;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Zoi.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AccountController : ControllerBase
//    {
//        private IDemo _demo;
//        private readonly IDistributedCache _memoryCache;
//        private readonly IConfiguration _configuration;
//        public AccountController(IDemo demo, IConfiguration configuration, IDistributedCache memoryCache)
//        {
//            _demo = demo;
//            _memoryCache = memoryCache;
//            _configuration = configuration;
//        }

//        // GET: api/<AccountController>
//        [HttpGet]
//        [UserAuthenticationFilter]
//        public Response Get()
//        {
//            var result = (Response)Constants.GetAsync<Response>(_memoryCache, "Country");
//            //result = null;
//            if (result != null)
//            {
//                return result;
//            }
//            else
//            {
//                var response = _demo.Demo();
//                var cacheOptions = new DistributedCacheEntryOptions
//                {
//                    AbsoluteExpiration = DateTime.Now.AddMinutes(Convert.ToInt16(_configuration.GetSection("ExpiryTime").Value))
//                };
//                Constants.SetAsync<Response>(_memoryCache, "Country", response, cacheOptions);
//                return response;
//            }
//        }

//        // GET api/<AccountController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/<AccountController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/<AccountController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<AccountController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
