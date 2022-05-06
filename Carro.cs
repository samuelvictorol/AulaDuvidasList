using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Duvida
{
    public class Carro
    {
        private string Modelo;
        private string Tipo;

        public Carro(string modelo, string tipo) {
            this.Modelo = modelo;
            this.Tipo = tipo;
        }
        public string getModelo()
        {
            return this.Modelo;
        }
        public void info()
        {
            Console.WriteLine("\nModelo: " + this.Modelo + "\nTipo: " + this.Tipo);
        }

    }
}
