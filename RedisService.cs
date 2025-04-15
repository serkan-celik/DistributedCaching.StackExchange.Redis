using StackExchange.Redis;

namespace StackExchangeRedis
{
    public class RedisService
    {
        //Redis sunucusuna bir bağlantı oluşturulur
        static ConnectionMultiplexer  connectionMultiplexer;
        public static ConnectionMultiplexer Connect() 
        { 
            return connectionMultiplexer = ConnectionMultiplexer.Connect("localhost:1453");
        }
        public IDatabase GetDb(int db) => connectionMultiplexer.GetDatabase(db);

        
    }

    public static class ConfigureEntensions
    {
        public static ConnectionMultiplexer UseRedisConnect(this IApplicationBuilder applicationBuilder)
        {
            return RedisService.Connect();
        }
    }

}
