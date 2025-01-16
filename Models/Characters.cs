public class Characters
{
    public required int Id { get; set; }
    public required string Stage { get; set; }
    public required string Name { get; set; }
    public int HP { get; set; }
    public int AT { get; set; }
    public int DF { get; set; }
    public string? LV { get; set; }
    public int EXP { get; set; }
    public required string Type { get; set; }
    public required string Info { get; set; }
    public List<string> Abilities { get; set; }
    public List<string> Attacks { get; set; }
    public required string Affinity { get; set; }
    public string? Resistance { get; set; }
    public string? Retreat { get; set; }
    public required string ExtraInfo { get; set; }
}