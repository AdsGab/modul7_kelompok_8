using System.Text.Json;

public class GlossaryItem1302223153
{
    public glossary glossary {  get; set; }
    public static void ReadJSON()
    {
        string json = File.ReadAllText(@"C:\Users\RAFLI\Downloads\Percodingan\C#\modul7_kelompok_8\jurnal7_3_1302223153.json");
        GlossaryItem1302223153 deserialized = JsonSerializer.Deserialize<GlossaryItem1302223153>(json);
        Console.WriteLine(deserialized.glossary.glossDiv.glossList.glossEntry.ID);
        Console.WriteLine(deserialized.glossary.glossDiv.glossList.glossEntry.SortAs);
        Console.WriteLine(deserialized.glossary.glossDiv.glossList.glossEntry.GlossTerm);
        Console.WriteLine(deserialized.glossary.glossDiv.glossList.glossEntry.Acronym);
        Console.WriteLine(deserialized.glossary.glossDiv.glossList.glossEntry.Abbrev);
        Console.WriteLine(deserialized.glossary.glossDiv.glossList.glossEntry.glossDef.para);
        foreach (var Also in deserialized.glossary.glossDiv.glossList.glossEntry.glossDef.glossSeeAlso)
        {
            Console.WriteLine(Also);
        }
        Console.WriteLine(deserialized.glossary.glossDiv.glossList.glossEntry.glossSee);
        
    }
}
