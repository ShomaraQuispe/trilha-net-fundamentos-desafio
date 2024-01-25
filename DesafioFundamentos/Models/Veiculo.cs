using System.ComponentModel;
using System.Reflection;

namespace DesafioFundamentos.Models
{
    public abstract class Veiculo
    {
        private string placa;
        public Veiculo(string placa)
        {
            this.placa = placa;
        }
        

        public string Placa {get; set;}

    }
}