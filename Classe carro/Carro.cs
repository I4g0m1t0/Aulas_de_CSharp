using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_carro
{
    internal class Carro
    {

        //declarando os atributos da classe carro
        public string marca, placa, modelo, cor, combstivel;
        private double preco;
        private DateTime dataCompra;
        public int tempoUso;
        public int numBatidas;

        

        // Método construtor da classe
        public Carro()
        {
            //carro
            this.marca = "";
            this.placa = "";
            this.modelo = "";
            this.cor = "";
            this.combstivel = "";
            this.preco = 0;
            this.dataCompra = DateTime.Today;
            this.tempoUso = 0;
            this.numBatidas = 0;

            
        }

        //Métodos get's e set's

        //Atributo da Classe Carro: Marca
        public void setMarca(string paraMarca)
        {
            this.marca = paraMarca;
        }
        public string getMarca()
        {
            return this.marca;
        }

        //Atributo da classe carro: Modelo
        public void setModelo(string paraModelo)
        {
            this.modelo = paraModelo;
        }
        public string getModelo()
        {
            return this.modelo;
        }

        //Atributo da Classe Carro: Placa
        public void setPlaca(string paraPlaca)
        {
            this.placa = paraPlaca;
        }
        public string getPlaca()
        {
            return this.placa;
        }

        //Atributo da Classe Carro: Cor
        public void setCor(string paraCor)
        {
            this.cor = paraCor;
        }
        public string getCor()
        {
            return this.cor;
        }

        //Atributo da Classe Carro: Combustivel
        public void setCombustivel(string paraCombustivel)
        {
            this.combstivel= paraCombustivel;
        }
        public string getCombustivel()
        {
            return this.combstivel;
        }

        //Atributo da Classe Carro: Preço
        public void setPreco(double paraPreco)
        {
            this.preco = paraPreco;
        }
        public double getPreco()
        {
            return this.preco;
        }

        //Atributo da Classe Carro: Data de compra
        public void setdataCompra(DateTime paradataCompra)
        {
            this.dataCompra = paradataCompra;
        }
        public DateTime getdataCompra()
        {
            return this.dataCompra;
        }

        //Atributo da Classe Carro: Tempo de uso
        public void settempoUso(int paratempoUso)
        {
            this.tempoUso = paratempoUso;
        }
        public int gettempoUso()
        {
            return this.tempoUso;
        }

        //Atributo da Classe Carro: Número de batidas
        public void setnumBatidas(int paranumBatidas)
        {
            this.numBatidas = paranumBatidas;
        }
        public int getnumBatidas()
        {
            return this.numBatidas;
        }

        
    }
}
