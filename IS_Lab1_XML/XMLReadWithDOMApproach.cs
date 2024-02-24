using System.Xml;

namespace IS_Lab1_XML;

public class XMLReadWithDOMApproach
{
    public static void Read(string filepath)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(filepath);
        
        string postac;
        string sc;
        int count = 0;
        XmlNodeList drugs = doc.GetElementsByTagName("produktLeczniczy");

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        
        foreach (XmlNode drug in drugs)
        {
            postac = drug.Attributes.GetNamedItem("nazwaPostaciFarmaceutycznej").Value;
            sc = drug.Attributes.GetNamedItem("nazwaPowszechnieStosowana").Value;
        
            if (postac == "Krem" && sc == "Mometasoni furoas")
            {
                count++;
            }

            // Zad 1.2.4
            if (dict.ContainsKey(sc))
            {
                if (!dict[sc].Contains(postac))
                {
                    dict[sc].Add(postac);
                }
            }
            else
            {
                dict[sc] = new List<string>();
                dict[sc].Add(postac);
            }
        }
        
        Console.WriteLine("Liczba produktów leczniczych w postaci kremu, których jedyną substancją czynną jest Mometasoni furoas: {0}", count);
        
        // Zad 1.2.4
        Console.WriteLine("Zad 1.2.4: ");
        foreach (KeyValuePair<string, List<string>> drug in dict)
        {
            Console.WriteLine("Nazwa produktu: {0}, liczba postaci: {1}", drug.Key, drug.Value.Count);
        }
    }
}