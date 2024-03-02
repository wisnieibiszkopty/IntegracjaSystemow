using YamlDotNet.Serialization;

namespace IS_Lab2_JSON;

// Przy próbie wczytania tablicy operacji z pliku yaml
// występuje błąd który nie wiem jak obejść
public class Config
{
    [YamlMember(Alias="source_folder")]
    public string SourceFolder { get; set; }
    
    [YamlMember(Alias="json_source_file")]
    public string JsonSourceFile { get; set; }
    
    [YamlMember(Alias="json_destination_file")]
    public string JsonDestinationFile { get; set; }
    
    [YamlMember(Alias="yaml_destination_file")]
    public string YamlDestinationFile { get; set; }
    
    [YamlMember(Alias="source")]
    public string Source { get; set; }
    
    [YamlMember(Alias="xml_destination_file")]
    public string XmlDestinationFile { get; set; }
    
    [YamlMember(Alias="json_from_xml_destination_file")]
    public string JsonFromXmlDestinationFile { get; set; }
}
