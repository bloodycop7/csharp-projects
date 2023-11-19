using Newtonsoft.Json;

StreamReader file = new StreamReader("D:\\csharp-projects\\settings.json");
JsonTextReader rs = new JsonTextReader(new StringReader(file.ReadToEnd()));

while (rs.Read())
{
    Console.Write($"{rs.TokenType.ToString()} - ");

    if ( rs.Value != null )
    {
        Console.Write(rs.Value);
    }
    Console.WriteLine("");
}

file.Close();