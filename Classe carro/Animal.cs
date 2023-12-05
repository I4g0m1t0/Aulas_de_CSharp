using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_carro
{
    internal class Animal
    {
        public string nome, racao, cor;
        private float peso, preco;
        private DateTime dataNasc, dataObito;
        public Boolean castrado;

        public Animal()
        {
            this.nome = "";
            this.racao = "";
            this.cor = "";
            this.peso = 0;
            this.preco = 0;
            this.dataNasc = DateTime.Today;
            this.dataObito = DateTime.Today;
            this.castrado = false;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }


        public void setRacao(string racao)
        {
            this.racao = racao;
        }
        public string getRacao()
        {
            return this.racao;
        }


        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public string getCor()
        {
            return this.cor;
        }


        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        public float getPeso()
        {
            return this.peso;
        }


        public void setPreco(float preco)
        {
            this.preco = preco;
        }
        public float getPreco()
        {
            return this.preco;
        }


        public void setdataNasc(DateTime dataNasc)
        {
            this.dataNasc = dataNasc;
        }
        public DateTime getdataNasc()
        {
            return this.dataNasc;
        }


        public void setdataObito(DateTime dataObito)
        {
            this.dataObito = dataObito;
        }
        public DateTime getdataObito()
        {
            return this.dataObito;
        }


        public void setCastrado(Boolean castrado)
        {
            this.castrado = castrado;
        }
        public Boolean getCastrado() 
        { 
            return this.castrado; 
        }
    }
}
