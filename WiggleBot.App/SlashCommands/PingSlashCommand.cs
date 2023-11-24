using Discord;
using Discord.WebSocket;

namespace WiggleBot.App.SlashCommands;

public record PingSlashCommand(SocketSlashCommand Command) : SlashCommand(Command)
{
    public override ApplicationCommandProperties Build()
    {
        var command = new SlashCommandBuilder();
        command.WithName("ping");
        command.WithDescription("This is a ping command");
        return command.Build();
    }

    public override async Task Handle()
    {
        await Command.RespondAsync("Pong!!!");
    }
}