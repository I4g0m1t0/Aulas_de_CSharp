using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinAppClasseUsuario
{
    public class classeAluno: classeUsuario
    {
        private string turma;
        private double nota1;
        private double nota2;
        private double media;

        public classeAluno()
        {
            this.turma = "";
            this.nota1 = 0;
            this.nota2 = 0;
            this.media = 0;
        }

        //método set e get para turma,nota1 e nota2
        public void setTurma(string paramTurma)
        {
            this.turma = paramTurma;
        }
        public string getTurma()
        {
            return this.turma;
        }
        public void setNota1(double paramNota1)
        {
            this.nota1 = paramNota1;
        }
        public double getNota1()
        {
            return this.nota1;
        }
        public void setNota2(double paramNota2)
        {
            this.nota2 = paramNota2;
        }
        public double getNota2()
        {
            return this.nota2;
        }

        //método para calcular a media
        public void calculaMedia()
        {
            this.media = (this.nota1 + this.nota2) / 2;
        }
        //método para retornar a média
        public double retornaMedia()
        {
            return this.media;
        }
        //método para verificar a aprovação
        public string verificaAprovacao()
        {
            if (this.media >= 7)
                return "Aprovado";
            else
                return "Reprovado";
        }

    }
}
