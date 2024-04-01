using Newtonsoft.Json;

public class TeamMembers
{

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_1302220013.json");
        dynamic item = JsonConvert.DeserializeObject(json);

        int count = 1;
        foreach (var member in item.members)
        {
            Console.WriteLine("Member ke " + count);
            Console.WriteLine("Nama     : " + member.firstName + member.lastName);
            Console.WriteLine("Gender   : " + member.gender);
            Console.WriteLine("Age      : " + member.age);
            Console.WriteLine("NIM      : " + member.nim);
            count++;
        }
    }
}

class TeamMembers1302220013
{
    static void Main(string[] args)
    {
        TeamMembers dataMember = new TeamMembers();
        dataMember.ReadJSON();
    }
}
