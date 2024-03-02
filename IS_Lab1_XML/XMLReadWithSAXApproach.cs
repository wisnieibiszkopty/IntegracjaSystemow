using System;
using System.Xml;

namespace IS_Lab1_XML;

public class XMLReadWithSAXApproach
{
    public static void Read(string filepath)
    {
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.IgnoreComments = true;
        settings.IgnoreProcessingInstructions = true;
        settings.IgnoreWhitespace = true;

        int count = 0;
        string postac = "";
        string sc = "";

        XmlReader reader = XmlReader.Create(filepath, settings);
        reader.MoveToContent();

        while (reader.Read())
        {
            if (reader.NodeType == XmlNodeType.Element && reader.Name == "produktLeczniczy")
            {
                postac = reader.GetAttribute("nazwaPostaciFarmaceutycznej");
                sc = reader.GetAttribute("nazwaPowszechnieStosowana");

                if (postac == "Krem" && sc == "Mometasoni furoas")
                {
                    count++;
                }
            }    
        }
        
        Console.WriteLine("Liczba produktów leczniczych w postaci kremu, których jedyną substancją czynną jest Mometasoni furoas: {0}", count);
    }
}