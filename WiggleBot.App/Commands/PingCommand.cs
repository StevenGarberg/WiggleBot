using Discord.Commands;

namespace WiggleBot.App.Commands;

public class PingCommand : CommandBase
{
    [Command("ping")]
    public async Task Execute()
    {
        await ReplyAsync("Pong");
    }
}