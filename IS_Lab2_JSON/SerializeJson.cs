using Newtonsoft.Json;

namespace IS_Lab2_JSON;

public class SerializeJson
{
    public static void SerializeFromObject(DeserializeJson deserializer, string fileLocation)
    {
        Console.WriteLine("Serializing data...");

        var data = deserializer.Data;
        var dataList = new List<object>();

        foreach (var dep in data)
        {
            object dataObject = new
            {
                kod_TERYT = dep["Kod_TERYT"],
                Województwo = dep["Województwo"],
                Powiat = dep["Powiat"],
                typ_JST = dep["typ_JST"],
                nazwa_urzędu_JST = dep["nazwa_urzędu_JST"],
                miejscowość = dep["miejscowość"],
                telefon_z_numerem_kierunkowym = dep["telefon kierunkowy"].ToString() + dep["telefon"]
            };
            
            dataList.Add(dataObject);
        }

        string jsonString = JsonConvert.SerializeObject(dataList);
        File.WriteAllText(fileLocation, jsonString);

    }
    
    public static void SerializeFromFile(string fileLocation, string fileDestination)
    {
        DeserializeJson deserializer = new DeserializeJson(fileLocation);
        SerializeFromObject(deserializer, fileDestination);
    }
}