using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças
{
    internal class Aluno:Usuario
    {
        public string turma { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double media {get; set; }

        public Aluno()
        {
            this.turma = string.Empty;
            this.nota1 = 0;
            this.nota2 = 0;
        }

        public void Media()
        {
            this.media = (this.nota1 + this.nota2) / 2;
        }

        public double retornaMedia()
        {
            return this.media;
        }

        public string aprovado()
        {
            if (this.media >= 6)
                return "Aprovado";
            else return "Reprovado";
        }
    }
}
