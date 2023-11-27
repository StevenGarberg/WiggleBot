namespace WiggleBot.Models;

public record MythicPlusWeeklyAffixes(
    byte WeekNumber,
    AffixType Affix1,
    AffixType Affix2,
    AffixType Affix3)
{
}