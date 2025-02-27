public class CardModel
{
    public string? Name { get; set; }
    public string? Stage { get; set; }
    public int HP { get; set; }
    public int LV { get; set; }
    public int AT { get; set; }
    public int DF { get; set; }
    public int EXP { get; set; }
    public string? Type { get; set; }
    public string? ImageUrl { get; set; }
    public List<string>? Abilities { get; set; }
    public List<string>? Affinities { get; set; }
    public List<string>? Attack { get; set; }
    public string? Info { get; set; }
    public string? ExtraInfo { get; set; }
}