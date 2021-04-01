﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2.General
{
    public class Veiculo : Humano
    {
        public string Tipo { get; set; }
        public string Cor { get; set; }
        public string Chassi { get; set; }

        public Veiculo(string tipo)
        {
            Tipo = tipo;
        }
        
        public virtual void Mover()
        {

        }

        public virtual void Parar()
        {

        }
    }
}
