namespace DesafioPOO.Models
{
    public class IPhone : Smartphone
    {
        public string SistemaOperacional { get; set; }

        public IPhone(string numero, string modelo, string imei, int memoria, string sistemaOperacional)
            : base(numero, modelo, imei, memoria)
        {
            SistemaOperacional = sistemaOperacional;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
        
        }
    }
}
