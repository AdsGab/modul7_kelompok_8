using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa_1302220001
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public Courses[] courses { get; set; }

    public static void ReadJSON()
    {
        string text = File.ReadAllText("C:\\Users\\SWIFT\\Documents\\tpmod7\\modul7_kelompok_8\\modul7_kelompok_8\\jurnal7_1_1302220001.json");
        DataMahasiswa_1302220001 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302220001>(text);

        Console.WriteLine($"Nama Depan: {mahasiswa.firstName} {mahasiswa.lastName}");
        Console.WriteLine($"Umur: {mahasiswa.age}");
        Console.WriteLine($"Jenis Kelamin: {mahasiswa.gender}");
        Console.WriteLine($"Jalan: {mahasiswa.address.streetAddress}");
        Console.WriteLine($"Kota: {mahasiswa.address.city}");
        Console.WriteLine($"Provinsi: {mahasiswa.address.state}");

        int i = 1;
        foreach (Courses j in mahasiswa.courses)
        {
            Console.WriteLine($"Mata Kuliah - {i} {j.code} {j.name}");
            i++;
        }
    }
}

public class Address
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}

public class Courses
{
    public string code { get; set; }
    public string name { get; set; }
}

public class Program
{
    public static void Main()
    {
        DataMahasiswa_1302220001.ReadJSON();
    }
}