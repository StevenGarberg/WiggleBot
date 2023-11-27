namespace WiggleBot.Models;

public record MythicPlusAffix(
    AffixType Name,
    string WowheadLink)
{
}

public enum AffixType
{
    Fortified,
    Tyrannical,
    Incorporeal,
    Entangling,
    Volcanic,
    Storming,
    Afflicted,
    Sanguine,
    Bursting,
    Spiteful,
    Raging,
    Bolstering
}