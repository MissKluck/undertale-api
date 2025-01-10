public class Characters
{
    public required int Id { get; set; }
    public required string Stage { get; set; }
    public required string Name { get; set; }
    public required int HP { get; set; }
    public required int AT { get; set; }
    public required int DF { get; set; }
    public string? LV { get; set; }
    public int EXP { get; set; }
    public required string Type { get; set; }
    public required string Info { get; set; }
    public string? AbilityOne { get; set; }
    public string? AbilityTwo { get; set; }
    public string? AbilityThree { get; set; }
    public string? AttackOne { get; set; }
    public string? AttackTwo { get; set; }
    public string? AttackThree { get; set; }
    public int DamageOne { get; set; }
    public int DamageTwo { get; set; }
    public required string Weak { get; set; }
    public required string Resistance { get; set; }
    public required string Retreat { get; set; }
    public required string ExtraInfo { get; set; }
}