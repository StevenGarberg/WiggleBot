using System.Reflection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using WiggleBot.App.SlashCommands;

namespace WiggleBot.App;

public class Program
{
    static void Main(string[] args)
    {
        RunBotAsync().GetAwaiter().GetResult();
        Console.ReadKey();
    }

    private static DiscordSocketClient _client;
    private static CommandService _commands;
    private static IServiceProvider _services;

    public static async Task RunBotAsync()
    {
        _client = new DiscordSocketClient();
        _commands = new CommandService();
        _services = new ServiceCollection()
            .AddSingleton(_client)
            .AddSingleton(_commands)
            .BuildServiceProvider();

        const string token = "";

        _client.Log += Log;
        _client.Ready += OnClientReady;
        _client.SlashCommandExecuted += OnSlashCommandExecuted;

        await RegisterCommandsAsync();

        await _client.LoginAsync(TokenType.Bot, token);

        await _client.StartAsync();

        await Task.Delay(-1);
    }

    private static async Task OnClientReady()
    {
        await _client.CreateGlobalApplicationCommandAsync(new PingSlashCommand(null).Build());
        await _client.CreateGlobalApplicationCommandAsync(new RegisterBattleTagSlashCommand(null).Build());
    }
    
    private static async Task OnSlashCommandExecuted(SocketSlashCommand command)
    {
        ISlashCommand slashCommand = command.CommandName switch
        {
            "ping" => new PingSlashCommand(command),
            "register-battle-tag" => new RegisterBattleTagSlashCommand(command),
            _ => new InvalidSlashCommand(command)
        };
        await slashCommand.Handle();
    }

    private static Task Log(LogMessage arg)
    {
        Console.WriteLine(arg);
        return Task.CompletedTask;
    }

    private static async Task RegisterCommandsAsync()
    {
        _client.MessageReceived += HandleCommandAsync;
        await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
    }

    private static async Task HandleCommandAsync(SocketMessage socketMessage)
    {
        var message = socketMessage as SocketUserMessage;
        var context = new SocketCommandContext(_client, message);
        if (message.Author.IsBot) return;

        int argPos = 0;
        if (message.HasStringPrefix("wigglebot ", ref argPos))
        {
            await Execute();
            return;
        }

        argPos = 0;
        if (message.HasStringPrefix("<@1175687805523984395> ", ref argPos))
        {
            await Execute();
            return;
        }

        async Task Execute()
        {
            var result = await _commands.ExecuteAsync(context, argPos, _services);
            if (!result.IsSuccess)
                Console.WriteLine(result.ErrorReason);
        }
    }
}