using ServiceReference1;

class Client
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("My First SOAP Client!");
        MyFirstSOAPInterfaceClient client = new MyFirstSOAPInterfaceClient();

        string text = await client.getHelloWorldAsStringAsync("Kamil");
        Console.WriteLine(text);

        long days = await client.getDaysBetweenDatesAsync("22 03 2024", "26 03 2024");
        Console.WriteLine(days);
    }
}

