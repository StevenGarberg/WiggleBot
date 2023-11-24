namespace WiggleBot.Models;

public class BattleTagRegistration
{
    public string Id => $"{GuildId}:{UserId}";
    public string UserId { get; set; }
    public string GuildId { get; set; }
    public string BattleTag { get; set; }
    public DateTime LastModifiedOn { get; set; }
}