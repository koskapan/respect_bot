using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using RespectBot.Services;
using RespectBot.Services.Interfaces;
using RespectBot.Models;

namespace RespectBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TgController : Controller
    {
        private readonly IBotService _botService;
        private readonly UserContext _context;

        public TgController(IBotService botService, UserContext context)
        {
            _botService = botService;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update update)
        {
            await _botService.Client.SendTextMessageAsync(update.Message.Chat.Id, "Test");
            return Ok();
        }
    }
}
