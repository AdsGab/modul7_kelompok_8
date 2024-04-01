using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.IO;
public class DataMahasiswa
{


    public void ReadJSON()
    {
        string jsonContent = File.ReadAllText("jurnal7_1_1302220013.json");
        dynamic jsonObject = JsonConvert.DeserializeObject(jsonContent);


        Console.WriteLine("Namaku " + jsonObject.firstName + jsonObject.lasName + " dengan jenis kelamin " + jsonObject.gender + " dan berumur " + jsonObject.age);
        Console.WriteLine("Aku tinggal di " + "jln. " + jsonObject.address.streetAddress + " kota " + jsonObject.address.city + " provinsi " + jsonObject.address.state);
        Console.WriteLine("Matakuliah yang ku ambil: ");
        foreach (var item in jsonObject.courses)
        {
            Console.WriteLine(item.code + " " + item.name);
        }

    }

}

class DataMahasiswa1302220013
{
    static void Main(string[] args)
    {
        DataMahasiswa mh1 = new DataMahasiswa();
        mh1.ReadJSON();
    }
}
