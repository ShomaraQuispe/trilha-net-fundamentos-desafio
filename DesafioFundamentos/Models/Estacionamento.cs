namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private int vagasDisponiveis, totalMotos, tipoVeiculo,totalCarros, totalVagas;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoPorHora, int totalVagas)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.totalVagas = totalVagas;
            this.vagasDisponiveis = totalVagas;
        }
        public int VagasDisponiveis{get;}

        public void AdicionarVeiculo()
        {
            if (this.vagasDisponiveis > 0)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                string placaVeiculo = Console.ReadLine().ToUpper();
                
                if (veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper())){
                    Console.WriteLine("Veículo já registrado anteriormente. Verifique a placa e digite novamente");

                }else{
                    do
                    {
                        Console.WriteLine("Qual é o tipo do veículo? Digite [1] para Carro ou [2] para Moto");
                        tipoVeiculo = Convert.ToInt32(Console.ReadLine());
                    } while (tipoVeiculo != 1 && tipoVeiculo != 2);

                    switch (tipoVeiculo)
                    {
                        case 1:
                        totalCarros++;
                        break;

                        case 2:
                        totalMotos++;
                        break;
                    }
                    veiculos.Add(placaVeiculo);
                    Console.WriteLine("Placa de veículo cadastrado com sucesso!");
                    vagasDisponiveis--;
                    Console.Clear();

                }
            }else{
                Console.WriteLine("Todas as vagas foram ocupadas. Não é possível adicionar o veículo!");
            }
        }

        public void RemoverVeiculo()
        {
            if(vagasDisponiveis < totalVagas)
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = "";
                placa = Console.ReadLine().ToUpper();

                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    int horas = int.Parse(Console.ReadLine());

                    decimal valorTotal = precoInicial + precoPorHora * horas;
                    
                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    vagasDisponiveis++;

                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }else{
                Console.WriteLine("O estacionamento já está vazio!");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in veiculos){
                    Console.WriteLine($"- {veiculo}");
                }

                Console.WriteLine("*******************************************************");
                Console.WriteLine($"[Dados de hoje]\n\nTotal de veículos estacionados até agora: {totalMotos + totalCarros}\n" +
                                $"Total de Carros até agora: {totalCarros}\nTotal de Motos até agora: {totalMotos}");               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
