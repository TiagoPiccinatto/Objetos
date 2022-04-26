using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Conta
    {

        // TODOS EM BAIXO SAO ATRIBUTOS 
        public int Id { get; set; }

        public double Saldo { get; set; }

        public double limite { get; set; }

        public int numero { get; set; }

        // TODOS EM BAIXO SAO METODOS "METHODS" ENGLISH

        public void Deposita(double valor)
        {
            // this. recebe todos os dados dentro da class, nesse caso da Class Conta
            this.Saldo += valor;
            // Sinal de += e um sinal de acresentar 
        }
        public double ConsultaSaldo()
        {
            // retorna os valores de saldo e limite setados
            return this.Saldo + this.limite;
        }
        
        public void Retirada(double valor)
        {
            if (ConsultaSaldo() >= valor)
            {
                this.Saldo -= valor;
            }
            else Console.WriteLine("Erro");
            
       }
    }
}
