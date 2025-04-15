using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;

namespace StackExchangeRedis.Controllers
{
    public class RedisController : Controller
    {
        RedisService _redisService;
        public RedisController(RedisService redisService)
        {
            _redisService = redisService;
        }

        public string getData()
        {

            IDatabase database = _redisService.GetDb(0);
            string value_get = database.StringGet("isim");
            return value_get;
        }
    }
}
