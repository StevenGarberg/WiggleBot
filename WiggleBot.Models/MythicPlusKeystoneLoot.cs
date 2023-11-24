namespace WiggleBot.Models;

public record MythicPlusKeystoneLoot(
    byte KeystoneLevel,
    ushort EndOfDungeonItemLevel,
    ushort GreatVaultItemLevel)
{
}