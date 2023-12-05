using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_carro
{
    internal class Aluno
    {
        //declarando os atributos da classe aluno
        public string nome, nota1, nota2, sexo, curso;
        public DateTime dataNasc;
        double media;

        //aluno
        public Aluno() { 
            this.nome = "";
            this.nota1 = "";
            this.nota2 = "";
            this.sexo = "";
            this.curso = "";
            this.dataNasc = DateTime.Today;
            this.media = 0;
        }

        //Atributo da Classe Aluno: Nome
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getnome()
        {
            return this.nome;
        }

        //Atributo da Classe Aluno: Nota1
        public void setNota1(string nota1)
        {
            this.nota1 = nota1;
        }
        public string getNota1()
        {
            return this.nota1;
        }

        //Atributo da Classe Aluno: Nota2
        public void setNota2(string nota2)
        {
            this.nota2 = nota2;
        }
        public string getNota2()
        {
            return this.nota2;
        }

        //Atributo da Classe Aluno: Sexo
        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public string getSexo()
        {
            return this.sexo;
        }

        //Atributo da Classe Aluno: Curso
        public void setCurso(string curso)
        {
            this.curso = curso;
        }
        public string getCurso()
        {
            return this.curso;
        }

        //Atributo da Classe Carro: Data de nascimento
        public void setdataNasc(DateTime dataNasc)
        {
            this.dataNasc = dataNasc;
        }
        public DateTime getdataNasc()
        {
            return this.dataNasc;
        }

        public void setMedia(double media)
        {
            this.media = media;
        }
        public double getMedia()
        {
            return this.media;
        }
    }
}
