namespace DesafioPOO.Models
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 8", imei: "IMEI123", memoria: 64, sistemaOperacional: "Symbian");
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\n");

            Console.WriteLine("iPhone:");
            Smartphone iPhone = new IPhone(numero: "987654321", modelo: "iPhone 12", imei: "IMEI456", memoria: 128, sistemaOperacional: "iOS");
            iPhone.Ligar();
            iPhone.InstalarAplicativo("Whatsapp");
        }
    }
}