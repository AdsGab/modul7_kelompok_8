using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class TeamMembers_1302220001
{
    public List<Tim> members { get; set; }

    public static void ReadJSON()
    {
        string text = File.ReadAllText("C:\\Users\\SWIFT\\Documents\\tpmod7\\modul7_kelompok_8\\modul7_kelompok_8\\jurnal7_2_1302220001.json");
        TeamMembers_1302220001 daftarTim = JsonSerializer.Deserialize<TeamMembers_1302220001>(text);
        Console.WriteLine("Daftar Anggota Kelompok 8 : ");
        int i = 1;
        foreach (Tim j in daftarTim.members)
        {
            Console.WriteLine($"{i}. Nama: {j.firstName} {j.lastName}");
            Console.WriteLine($"Jenis Kelamin: {j.gender}");
            Console.WriteLine($"Jenis Kelamin: {j.age}");
            Console.WriteLine($"Jenis Kelamin: {j.nim}");
            i++;
        }
    }
}

public class Tim
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}
