using Telegram.Bot;

namespace RespectBot.Services.Interfaces
{
    public interface IBotService
    {
        TelegramBotClient Client { get; }
    }
}
