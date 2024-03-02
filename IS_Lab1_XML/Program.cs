using System;
using System.IO;

namespace IS_Lab1_XML;

class Program
{
    static void Main(string[] args)
    {
        string xmlpath = Path.Combine(Environment.CurrentDirectory, "Assets", "data.xml");
        
        Console.WriteLine("XML loaded by DOM Approach");
        XMLReadWithDOMApproach.Read(xmlpath);
        Console.WriteLine("XML loaded by SAX Approach");
        XMLReadWithSAXApproach.Read(xmlpath);
        Console.WriteLine("XML loaded with XPath");
        XMLReadWithXLSTDOM.Read(xmlpath);
        Console.ReadLine();
    }
}
