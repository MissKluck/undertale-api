public class Characters
{
    public required int Id { get; set; }
    public required string Stage { get; set; }
    public required string Name { get; set; }
    public string? HP { get; set; }
    public string? LV { get; set; }
    public string? AT { get; set; }
    public string? DF { get; set; }
    public string? EXP { get; set; }
    public required string Type { get; set; }
    public required string Info { get; set; }
    public List<string> Abilities { get; set; }
    public List<string> Attacks { get; set; }
    public required string Affinity { get; set; }
    public string? Resistance { get; set; }
    public string? Retreat { get; set; }
    public required string ExtraInfo { get; set; }
}