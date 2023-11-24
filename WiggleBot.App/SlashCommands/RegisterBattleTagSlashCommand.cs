using Discord;
using Discord.Interactions;
using Discord.WebSocket;
using WiggleBot.Models;

namespace WiggleBot.App.SlashCommands;

public record RegisterBattleTagSlashCommand(SocketSlashCommand Command) : SlashCommand(Command)
{
    public override ApplicationCommandProperties Build()
    {
        var command = new SlashCommandBuilder();
        command.WithName("register-battle-tag");
        command.WithDescription("Registers or updates your BattleTag");
        command.AddOption("battle-tag", ApplicationCommandOptionType.String, "Your BattleTag", true);
        return command.Build();
    }
    
    public override async Task Handle()
    {
        var battleTagRegistration = new BattleTagRegistration
        {
            GuildId = Command.GuildId.ToString(),
            UserId = Command.User.Id.ToString(),
            BattleTag = (string)Command.Data.Options.First(x => x.Name == "battle-tag").Value,
            LastModifiedOn = DateTime.UtcNow
        };
        await Command.RespondAsync("BattleTag registered!");
    }
}