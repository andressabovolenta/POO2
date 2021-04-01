using POO2.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2.General
{
    public class Automovel : Veiculo
    {
        private IConsoleTools _consoleTools = new ConsoleTools();

        public Automovel(string tipo) : base(tipo)
        {

        }

        public override void Mover()
        {
            _consoleTools.Escrever("Acelernado o automóvel.");
        }

        public override void Parar()
        {
            _consoleTools.Escrever("Estacionando o automóvel.");
        }
    }
}
