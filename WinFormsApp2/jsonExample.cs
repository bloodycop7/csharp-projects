using System.Text.Json;

Dictionary<string, string> dic = new Dictionary<string, string>();
dic.Add("lang", "eng");
dic.Add("darkTheme", Convert.ToString(1));

string json = JsonSerializer.Serialize(dic);

StreamWriter file = new StreamWriter("D:\\eontest.txt");
file.Write(json);
file.Close();

// Read Data (idfk)

string jsonToText = File.ReadAllText("D:\\eonText\\eontest.txt");

var data = JsonSerializer.Deserialize<JSOnLol>(jsonToText);

Console.WriteLine(jsonToText);
Console.WriteLine(data.lang + " " + data.darkTheme);

public class JSOnLol
{
    public string lang { get; set; }
    public string darkTheme { get; set; }
}
