using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Duvida
{
    public class Locadora
    {
       
        private List<Carro> carros = new List<Carro>();

        public void adicionarCarro(Carro carro)
        {
            this.carros.Add(carro);
        }
        public void removerCarro(string modelo)
        {
            foreach (Carro carro in this.carros)
            {
                if (modelo.Equals(carro.getModelo()))
                {
                    Console.WriteLine("Carro Encontrado!");
                    Console.ReadKey();
                    carro.info();
                    carros.Remove(carro);
                    Console.WriteLine("Carro Removido!");
                    return;
                }
            }
            Console.WriteLine("Carro Nao Encontrado!");
            
        }
        public void Info()
        {
            foreach (Carro carro in carros)
            {
                carro.info();
            }
        }

    }
}
