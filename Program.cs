using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Testando Nokia:");
        Smartphone nokia = new Nokia("1199999999", "Nokia 2000", "123456789", 32);
        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine("\nTestando iPhone:");
        Smartphone iphone = new Iphone("1198888888", "iPhone 13", "987654321", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
