using Discord;
using Discord.WebSocket;

namespace WiggleBot.App.SlashCommands;

public abstract record SlashCommand(SocketSlashCommand Command) : ISlashCommand
{
    public abstract ApplicationCommandProperties Build();
    public abstract Task Handle();
}