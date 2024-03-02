
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YamlDotNet.Serialization;

namespace IS_Lab2_JSON;

public class ConverJsonToYaml
{
    public static void Convert(string jsonLocation, string yamlLocation)
    {
        string jsonContent = File.ReadAllText(jsonLocation);

        var expConverter = new ExpandoObjectConverter();
        dynamic deserializedObject = JsonConvert.DeserializeObject<List<ExpandoObject>>(jsonContent, expConverter);
        Serializer serializer = new Serializer();
        string yaml = serializer.Serialize(deserializedObject);
        File.WriteAllText(yamlLocation, yaml);
    }
}