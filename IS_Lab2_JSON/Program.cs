using YamlDotNet.Serialization;

namespace IS_Lab2_JSON;

class Program
{
    static void Main(string[] args)
    {
        // Pobieranie konfiguracji z pliku basic_config.yaml
        Config config = Deserialize();

        // Deserializacja i statystki
        DeserializeJson deserializer = new DeserializeJson(config.SourceFolder + config.JsonSourceFile);
        deserializer.Stats();
        
        // Serialiacja do pliku json części danych
        if (config.Source == "object")
        {
            SerializeJson.SerializeFromObject(deserializer, config.SourceFolder + config.JsonDestinationFile);   
        }
        else if (config.Source == "file")
        {
            SerializeJson.SerializeFromFile(config.SourceFolder + config.JsonSourceFile, config.SourceFolder + config.JsonDestinationFile);
        }
        
        // Json to yaml
        ConverJsonToYaml.Convert(config.SourceFolder + config.JsonSourceFile, config.SourceFolder + config.YamlDestinationFile);
    }

    static Config Deserialize()
    {
        try
        {
            string yamlPath = Path.Combine(Environment.CurrentDirectory, "basic_config.yaml");
            string yamlFile = File.ReadAllText(yamlPath);
            IDeserializer deserializer = new DeserializerBuilder().Build();
            Config config = deserializer.Deserialize<Config>(yamlFile);
            return config;
        }
        catch (Exception e)
        {
            Console.WriteLine("Wystąpił błąd: " + e);
        }

        // 💀💀💀
        return null;
    }
}