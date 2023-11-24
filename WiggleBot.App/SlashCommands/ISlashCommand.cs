using Discord;

namespace WiggleBot.App.SlashCommands;

public interface ISlashCommand
{
    Task Handle();
    ApplicationCommandProperties Build();
}