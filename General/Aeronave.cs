using POO2.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2.General
{
    public class Aeronave : Veiculo
    {
        private IConsoleTools _consoleTools = new ConsoleTools();
        
        public Aeronave(string tipo) : base(tipo)
        {

        }

        public override void Mover()
        {
            _consoleTools.Escrever("Decolando a aeronave.");
        }

        public override void Parar()
        {
            _consoleTools.Escrever("Pousando a aeronave.");
        }
    }
}
