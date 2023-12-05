using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinAppClasseUsuario
{    public class classeUsuario
    {
        //declaração dos atributos
        private string nome;
        private string matricula;
        private DateTime dataNasc;
        private string endereco;
        private int idade;
        //método construtor para a classe
        public classeUsuario()
        {
            this.nome = "";
            this.matricula = "";
            this.dataNasc = DateTime.Today;
            this.endereco = "";
            this.idade = 0;
        }


        //métodos set e get
        //para os atributos: nome, matricula, endereço, dataNasc
        public void setNome(string paramNome)
        {
            this.nome = paramNome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setMatricula(string paramMatricula)
        {
            this.matricula = paramMatricula;
        }
        public string getMatricula()
        {
            return this.matricula;
        }
        public void setEndereco(string paramEndereco)
        {
            this.endereco = paramEndereco;
        }
        public string getEndereco()
        {
            return this.endereco;
        }
        public void setDataNasc(DateTime paramDataNasc)
        {
            this.dataNasc = paramDataNasc;
        }
        public DateTime getDataNasc()
        {
            return dataNasc;
        }

        //método de funcionalidade
        public void calculaIdade()
        {
            this.idade = DateTime.Today.Year - dataNasc.Year;
        }

        //método getIdade
        public int getIdade()
        {
            return this.idade;
        }

    }
}
