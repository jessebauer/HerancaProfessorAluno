using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProfessorAluno
{
    internal class Professor:Pessoa
    {
        private float salario;

        public float Salario { get => salario; set => salario = value; }
    }
}
