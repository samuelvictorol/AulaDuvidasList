using System;

namespace Aula6Duvida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Locadora locadora = new Locadora();
            Locadora locadora2 = new Locadora();
          
            locadora.adicionarCarro(new Carro("HB20", "Hatch"));
            locadora.adicionarCarro(new Carro("Civic", "Sedan"));
            locadora.adicionarCarro(new Carro("Duster", "SUV"));

            locadora.Info();

            locadora.removerCarro("Civic");

             locadora.Info();

        }
    }

}
