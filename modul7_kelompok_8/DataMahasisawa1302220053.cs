using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
public class DataMahasiswa1302220053
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public alamat address { get; set; }
    public List<kelas> courses { get; set; }


    public static void ReadJson()
    {
        string isiJson1 = File.ReadAllText("C:\\Users\\gabri\\OneDrive\\Desktop\\modul7_kelompok_8\\Jurnal7_1_1302220053.json");

        DataMahasiswa1302220053 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302220053>(isiJson1);

        Console.WriteLine("Nama " + mahasiswa.firstName + " " + mahasiswa.lastName + " seorang " + mahasiswa.gender + 
            "berumur " + mahasiswa.age + " dari  " + mahasiswa.address.streetAddress + " "+  mahasiswa.address.city + " " + mahasiswa.address.state);
        Console.WriteLine("Kelas yang diambil: ");
        foreach (kelas j in mahasiswa.courses)
        {
            Console.WriteLine(j.Name + " Dengan kode : " + j.code);
        }
    }
}

public class kelas
{
    public string code { get; set; }
    public string Name { get; set; }
}

public class alamat
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}