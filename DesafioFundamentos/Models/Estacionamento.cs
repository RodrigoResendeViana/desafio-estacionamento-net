namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {       
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                veiculos.Remove(placa);

                int horasEstacionado = 0;
                decimal valorTotal = 0;

                Console.WriteLine("Quantas horas o veículo permaneceu estacionado?");
                horasEstacionado = Convert.ToInt32(Console.ReadLine());
                
                valorTotal = precoInicial + precoPorHora * horasEstacionado;

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:\n");
    
                for(int contador = 0; contador < veiculos.Count; contador++){
                    Console.WriteLine($"{contador + 1} - Placa do veículo: {veiculos[contador]}");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}