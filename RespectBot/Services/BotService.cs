using Microsoft.Extensions.Options;
using Telegram.Bot;
using RespectBot.Services.Interfaces;

namespace RespectBot.Services
{
    public class BotService : IBotService
    {
        private readonly BotConfiguration _config;
        
        public TelegramBotClient Client { get; }


        public BotService(IOptions<BotConfiguration> config)
        {
            _config = config.Value;
            Client = new TelegramBotClient(_config.BotToken);
        }
    }
}
