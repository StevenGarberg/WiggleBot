using Discord;
using Discord.WebSocket;

namespace WiggleBot.App.SlashCommands;

public record InvalidSlashCommand(SocketSlashCommand Command) : SlashCommand(Command)
{
    public override ApplicationCommandProperties Build()
    {
        throw new NotImplementedException();
    }

    public override async Task Handle()
    {
        await Command.RespondAsync("You attempted to use an invalid command.");
    }
}