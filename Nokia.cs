namespace DesafioPOO.Models
{
public class Nokia : Smartphone
    {
        public string SistemaOperacional { get; set; }

        public Nokia(string numero, string modelo, string imei, int memoria, string sistemaOperacional)
            : base(numero, modelo, imei, memoria)
        {
            SistemaOperacional = sistemaOperacional;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
        }
          }
}