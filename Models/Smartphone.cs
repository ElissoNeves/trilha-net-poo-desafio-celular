namespace DesafioPOO.Models
{
    public class Smartphone
    {
        
        // Propriedades faltantes implementadas
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Parametros passados
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            Console.WriteLine("Amor(99456-5694)");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação");
            Console.WriteLine("Elisson Neves(98562-2658)");
        }

        public virtual void InstalarAplicativo(string nomeApp)
        {

        }
    }
}