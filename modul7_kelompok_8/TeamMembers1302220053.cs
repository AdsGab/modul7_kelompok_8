using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

public class member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}

public class TeamMembers1302220053
{

    public List<member> members { get; set; }

    public static void ReadJson()
    {
        string isiJson1 = File.ReadAllText("C:\\Users\\gabri\\OneDrive\\Desktop\\modul7_kelompok_8\\jurnal7_2_1302220053.json");

        TeamMembers1302220053 kelompok = JsonSerializer.Deserialize<TeamMembers1302220053>(isiJson1);

        Console.WriteLine("Team member list: ");
        foreach (member m in kelompok.members)
        {
            Console.WriteLine(m.nim + " " + m.firstName + " " + m.lastName + "( " + m.age + " " + m.gender + " )");
        }
    }
}

