using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

public class Glossary
{
    public string title;
    public glossDiv GlossDiv;
}

public class glossDiv
{
    public string title;
    public glosslist GlossList;
}

public class glosslist
{
    public glossEntry GlossEntry;
}
public class glossEntry
{
    public string ID;
    public string SortAs;
    public string GlossTerm;
    public string Acronym;
    public string Abbrev;
    public glossDef GlossDef;
    public string GlossSee;
}
public class glossDef
{
    public string para;
    public List<glossSeeAlso> GlossSeeAlso;
}
public class glossSeeAlso { public string para; }

public class GlossaryItem1302220053
{

    public Glossary glossary;


    public static void ReadJson()
    {
        string isiJson1 = File.ReadAllText("C:\\Users\\gabri\\OneDrive\\Desktop\\modul7_kelompok_8\\jurnal7_3_1302220053.json");

        GlossaryItem1302220053 panjang = JsonSerializer.Deserialize<GlossaryItem1302220053>(isiJson1);

        Console.WriteLine("Glossary Entry : ");
        Console.WriteLine("ID " +  panjang.glossary.GlossDiv.GlossList.GlossEntry.ID);
        
    }
}
