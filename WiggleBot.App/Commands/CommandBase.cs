using Discord.Commands;

namespace WiggleBot.App.Commands;

public class CommandBase : ModuleBase<SocketCommandContext>
{ 
    protected string Mention => Context.Message.Author.Mention;
}