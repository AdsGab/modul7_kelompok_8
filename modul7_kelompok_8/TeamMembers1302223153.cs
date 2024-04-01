using System.Text.Json;

public class TeamMembers1302223153
{
    public List<member> members { get; set; }
    public static void ReadJSON()
    {
        string json = File.ReadAllText(@"C:\Users\RAFLI\Downloads\Percodingan\C#\modul7_kelompok_8\jurnal7_2_1302223153.json");
        TeamMembers1302223153 deserialized = JsonSerializer.Deserialize<TeamMembers1302223153>(json);
        Console.WriteLine("Team member list:");
        foreach (var member in deserialized.members)
        {
            Console.WriteLine(member.nim+ " " + member.firstName + " " + member.lastName + " (" + member.age + " " + member.gender + ")");
        }
    }
}