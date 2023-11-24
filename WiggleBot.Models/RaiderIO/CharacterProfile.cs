using System.Text.Json.Serialization;

namespace WiggleBot.Models.RaiderIO;

public class CharacterProfile
{
    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("race")] public string Race { get; set; }

    [JsonPropertyName("class")] public string Class { get; set; }

    [JsonPropertyName("active_spec_name")] public string ActiveSpecName { get; set; }

    [JsonPropertyName("active_spec_role")] public string ActiveSpecRole { get; set; }

    [JsonPropertyName("gender")] public string Gender { get; set; }

    [JsonPropertyName("faction")] public string Faction { get; set; }
    
    [JsonPropertyName("achievement_points")] public int AchievementPoints { get; set; }
    
    [JsonPropertyName("honorable_kills")] public int HonorableKills { get; set; }
    
    [JsonPropertyName("thumbnail_url")] public string ThumbnailUrl { get; set; }

    [JsonPropertyName("region")] public string Region { get; set; }

    [JsonPropertyName("realm")] public string Realm { get; set; }

    [JsonPropertyName("profile_url")] public string ProfileUrl { get; set; }

    [JsonPropertyName("gear")] public Gear Gear { get; set; }

    [JsonPropertyName("raid_progression")] public RaidProgression RaidProgression { get; set; }

    [JsonPropertyName("mythic_plus_ranks")]
    public MythicPlusRanks MythicPlusRanks { get; set; }

    [JsonPropertyName("previous_mythic_plus_ranks")]
    public PreviousMythicPlusRanks PreviousMythicPlusRanks { get; set; }

    [JsonPropertyName("mythic_plus_recent_runs")]
    public List<MythicPlusRecentRun> MythicPlusRecentRuns { get; set; }

    [JsonPropertyName("mythic_plus_best_runs")]
    public List<MythicPlusBestRun> MythicPlusBestRuns { get; set; }

    [JsonPropertyName("mythic_plus_alternate_runs")]
    public List<MythicPlusAlternateRun> MythicPlusAlternateRuns { get; set; }
    
    [JsonPropertyName("guild")]
    public Guild Guild { get; set; }
    
    [JsonPropertyName("talentLoadout")]
    public TalentLoadout TalentLoadout { get; set; }
}

public class TalentLoadout
{
    [JsonPropertyName("loadout_text")]
    public string LoadoutText { get; set; }
}

public class AberrusTheShadowedCrucible
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class Guild
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("realm")]
    public string Realm { get; set; }
}

public class AmirdrassilTheDreamsHope
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class AntorusTheBurningThrone
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class BattleOfDazaralor
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class CastleNathria
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class Class
{
    [JsonPropertyName("world")] public int World { get; set; }

    [JsonPropertyName("region")] public int Region { get; set; }

    [JsonPropertyName("realm")] public int Realm { get; set; }
}

public class ClassDps
{
    [JsonPropertyName("world")] public int World { get; set; }

    [JsonPropertyName("region")] public int Region { get; set; }

    [JsonPropertyName("realm")] public int Realm { get; set; }
}

public class ClassHealer
{
    [JsonPropertyName("world")] public int World { get; set; }

    [JsonPropertyName("region")] public int Region { get; set; }

    [JsonPropertyName("realm")] public int Realm { get; set; }
}

public class ClassTank
{
    [JsonPropertyName("world")] public int World { get; set; }

    [JsonPropertyName("region")] public int Region { get; set; }

    [JsonPropertyName("realm")] public int Realm { get; set; }
}

public class CrucibleOfStorms
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class Dps
{
    [JsonPropertyName("world")] public int World { get; set; }

    [JsonPropertyName("region")] public int Region { get; set; }

    [JsonPropertyName("realm")] public int Realm { get; set; }
}

public class FatedCastleNathria
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class FatedSanctumOfDomination
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class FatedSepulcherOfTheFirstOnes
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class Gear
{
    [JsonPropertyName("item_level_equipped")]
    public int ItemLevelEquipped { get; set; }

    [JsonPropertyName("item_level_total")] public int ItemLevelTotal { get; set; }

    [JsonPropertyName("artifact_traits")] public int ArtifactTraits { get; set; }
}

public class Healer
{
    [JsonPropertyName("world")] public int World { get; set; }

    [JsonPropertyName("region")] public int Region { get; set; }

    [JsonPropertyName("realm")] public int Realm { get; set; }
}

public class MythicPlusAlternateRun
{
    [JsonPropertyName("dungeon")] public string Dungeon { get; set; }

    [JsonPropertyName("short_name")] public string ShortName { get; set; }

    [JsonPropertyName("mythic_level")] public int MythicLevel { get; set; }

    [JsonPropertyName("completed_at")] public DateTime CompletedAt { get; set; }

    [JsonPropertyName("clear_time_ms")] public int ClearTimeMs { get; set; }

    [JsonPropertyName("num_keystone_upgrades")]
    public int NumKeystoneUpgrades { get; set; }

    [JsonPropertyName("score")] public double Score { get; set; }

    [JsonPropertyName("url")] public string Url { get; set; }
}

public class MythicPlusBestRun
{
    [JsonPropertyName("dungeon")] public string Dungeon { get; set; }

    [JsonPropertyName("short_name")] public string ShortName { get; set; }

    [JsonPropertyName("mythic_level")] public int MythicLevel { get; set; }

    [JsonPropertyName("completed_at")] public DateTime CompletedAt { get; set; }

    [JsonPropertyName("clear_time_ms")] public int ClearTimeMs { get; set; }

    [JsonPropertyName("num_keystone_upgrades")]
    public int NumKeystoneUpgrades { get; set; }

    [JsonPropertyName("score")] public double Score { get; set; }

    [JsonPropertyName("url")] public string Url { get; set; }
}

public class MythicPlusRanks
{
    [JsonPropertyName("overall")] public Overall Overall { get; set; }

    [JsonPropertyName("tank")] public Tank Tank { get; set; }

    [JsonPropertyName("healer")] public Healer Healer { get; set; }

    [JsonPropertyName("dps")] public Dps Dps { get; set; }

    [JsonPropertyName("class")] public Class Class { get; set; }

    [JsonPropertyName("class_tank")] public ClassTank ClassTank { get; set; }

    [JsonPropertyName("class_healer")] public ClassHealer ClassHealer { get; set; }

    [JsonPropertyName("class_dps")] public ClassDps ClassDps { get; set; }
}

public class MythicPlusRecentRun
{
    [JsonPropertyName("dungeon")] public string Dungeon { get; set; }

    [JsonPropertyName("short_name")] public string ShortName { get; set; }

    [JsonPropertyName("mythic_level")] public int MythicLevel { get; set; }

    [JsonPropertyName("completed_at")] public DateTime CompletedAt { get; set; }

    [JsonPropertyName("clear_time_ms")] public int ClearTimeMs { get; set; }

    [JsonPropertyName("num_keystone_upgrades")]
    public int NumKeystoneUpgrades { get; set; }

    [JsonPropertyName("score")] public double Score { get; set; }

    [JsonPropertyName("url")] public string Url { get; set; }
}

public class NyalothaTheWakingCity
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class Overall
{
    [JsonPropertyName("world")] public int World { get; set; }

    [JsonPropertyName("region")] public int Region { get; set; }

    [JsonPropertyName("realm")] public int Realm { get; set; }
}

public class PreviousMythicPlusRanks
{
    [JsonPropertyName("overall")] public Overall Overall { get; set; }

    [JsonPropertyName("tank")] public Tank Tank { get; set; }

    [JsonPropertyName("healer")] public Healer Healer { get; set; }

    [JsonPropertyName("dps")] public Dps Dps { get; set; }

    [JsonPropertyName("class")] public Class Class { get; set; }

    [JsonPropertyName("class_tank")] public ClassTank ClassTank { get; set; }

    [JsonPropertyName("class_healer")] public ClassHealer ClassHealer { get; set; }

    [JsonPropertyName("class_dps")] public ClassDps ClassDps { get; set; }
}

public class RaidProgression
{
    [JsonPropertyName("amirdrassil-the-dreams-hope")]
    public AmirdrassilTheDreamsHope AmirdrassilTheDreamsHope { get; set; }

    [JsonPropertyName("aberrus-the-shadowed-crucible")]
    public AberrusTheShadowedCrucible AberrusTheShadowedCrucible { get; set; }

    [JsonPropertyName("vault-of-the-incarnates")]
    public VaultOfTheIncarnates VaultOfTheIncarnates { get; set; }

    [JsonPropertyName("fated-sepulcher-of-the-first-ones")]
    public FatedSepulcherOfTheFirstOnes FatedSepulcherOfTheFirstOnes { get; set; }

    [JsonPropertyName("fated-sanctum-of-domination")]
    public FatedSanctumOfDomination FatedSanctumOfDomination { get; set; }

    [JsonPropertyName("fated-castle-nathria")]
    public FatedCastleNathria FatedCastleNathria { get; set; }

    [JsonPropertyName("sepulcher-of-the-first-ones")]
    public SepulcherOfTheFirstOnes SepulcherOfTheFirstOnes { get; set; }

    [JsonPropertyName("sanctum-of-domination")]
    public SanctumOfDomination SanctumOfDomination { get; set; }

    [JsonPropertyName("castle-nathria")] public CastleNathria CastleNathria { get; set; }

    [JsonPropertyName("nyalotha-the-waking-city")]
    public NyalothaTheWakingCity NyalothaTheWakingCity { get; set; }

    [JsonPropertyName("the-eternal-palace")]
    public TheEternalPalace TheEternalPalace { get; set; }

    [JsonPropertyName("crucible-of-storms")]
    public CrucibleOfStorms CrucibleOfStorms { get; set; }

    [JsonPropertyName("battle-of-dazaralor")]
    public BattleOfDazaralor BattleOfDazaralor { get; set; }

    [JsonPropertyName("uldir")] public Uldir Uldir { get; set; }

    [JsonPropertyName("antorus-the-burning-throne")]
    public AntorusTheBurningThrone AntorusTheBurningThrone { get; set; }

    [JsonPropertyName("tomb-of-sargeras")] public TombOfSargeras TombOfSargeras { get; set; }

    [JsonPropertyName("the-nighthold")] public TheNighthold TheNighthold { get; set; }

    [JsonPropertyName("trial-of-valor")] public TrialOfValor TrialOfValor { get; set; }

    [JsonPropertyName("the-emerald-nightmare")]
    public TheEmeraldNightmare TheEmeraldNightmare { get; set; }
}

public class SanctumOfDomination
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class SepulcherOfTheFirstOnes
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class Tank
{
    [JsonPropertyName("world")] public int World { get; set; }

    [JsonPropertyName("region")] public int Region { get; set; }

    [JsonPropertyName("realm")] public int Realm { get; set; }
}

public class TheEmeraldNightmare
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class TheEternalPalace
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class TheNighthold
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class TombOfSargeras
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class TrialOfValor
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class Uldir
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}

public class VaultOfTheIncarnates
{
    [JsonPropertyName("summary")] public string Summary { get; set; }

    [JsonPropertyName("total_bosses")] public int TotalBosses { get; set; }

    [JsonPropertyName("normal_bosses_killed")]
    public int NormalBossesKilled { get; set; }

    [JsonPropertyName("heroic_bosses_killed")]
    public int HeroicBossesKilled { get; set; }

    [JsonPropertyName("mythic_bosses_killed")]
    public int MythicBossesKilled { get; set; }
}