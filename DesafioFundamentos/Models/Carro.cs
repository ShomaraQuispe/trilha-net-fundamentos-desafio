
namespace DesafioFundamentos.Models
{
    public class Carro : Veiculo
    {
        private int tamanhoVeiculo;

        public Carro(string placa, int tamanhoVeiculo) : base(placa)
        {
            this.tamanhoVeiculo = tamanhoVeiculo;
        }

        public int TamanhoVeiculo{get; set;}

    }
}