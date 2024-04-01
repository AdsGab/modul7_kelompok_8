using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302223153.ReadJSON();
    }
}

public class addressAll
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}
public class course
{
    public string code { get; set; }
    public string name { get; set; }
}
public class DataMahasiswa1302223153
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public addressAll address { get; set; }
    public List<course> courses { get; set; }

    public static void ReadJSON()
    {
        string json = File.ReadAllText(@"C:\Users\RAFLI\Downloads\Percodingan\C#\modul7_kelompok_8\jurnal7_1_1302223153.json");
        DataMahasiswa1302223153 deserialized = JsonSerializer.Deserialize<DataMahasiswa1302223153>(json);
        Console.WriteLine("Name\t\t: " + deserialized.firstName + " " + deserialized.lastName + "\nGender\t\t: " + deserialized.gender + "\nAge\t\t: " + deserialized.age + "\nFull Address\t: " + deserialized.address.streetAddress + ", " + deserialized.address.city + ", " + deserialized.address.state);
        Console.WriteLine("List Courses\t:");
        int i = 1;
        foreach (var MatKul in deserialized.courses)
        {
            Console.WriteLine("MK " + i + " " + MatKul.code + " - " + MatKul.name);
            i++;
        }
    }
    
    
}