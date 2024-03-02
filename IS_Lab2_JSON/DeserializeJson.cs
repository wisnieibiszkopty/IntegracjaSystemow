using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IS_Lab2_JSON;

public class DeserializeJson
{
    public JArray Data { get; }
    
    public DeserializeJson(string filename)
    {
        try
        {
            string jsonContent = File.ReadAllText(filename);
            Data = JArray.Parse(jsonContent);
        }
        catch (Exception e)
        {
            Console.WriteLine("Wystąpił błąd przy deserializacji: " + e);
        }
    }

    public void Stats()
    {
        Console.WriteLine("Showing stats: ");

        Dictionary<string, Dictionary<string, int>> wojewodztwa = new Dictionary<string, Dictionary<string, int>>();
        
        foreach (var dep in Data)
        {
            if (wojewodztwa.ContainsKey(dep["Województwo"].ToString()))
            {
                if (wojewodztwa[dep["Województwo"].ToString()].ContainsKey(dep["typ_JST"].ToString()))
                {
                    wojewodztwa[dep["Województwo"].ToString()][dep["typ_JST"].ToString()] += 1;
                }
                else
                {
                    wojewodztwa[dep["Województwo"].ToString()][dep["typ_JST"].ToString()] = 1;
                    foreach (var key in wojewodztwa[dep["Województwo"].ToString()].Keys) ;
                }
            }
            else
            {
                wojewodztwa[dep["Województwo"].ToString()] = new Dictionary<string, int>();
            }
        }

        foreach (KeyValuePair<string, Dictionary<string, int>> wojewodztwo in wojewodztwa)
        {
            Console.WriteLine(wojewodztwo.Key);
            foreach (KeyValuePair<string, int> jst in wojewodztwo.Value)
            {
                Console.Write($"{jst.Key}: {jst.Value} ");
            }
            Console.WriteLine();
        }
    }
}