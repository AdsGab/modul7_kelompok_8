public class glossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public glossDef glossDef { get; set; }
    public string glossSee { get; set; }
}
