using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_imóvel
{
    internal class Imovel
    {
        public string nome, localizacao, dono;
        private double metragem, preco;
        private DateTime dt_construcao;

        public Imovel() 
        {
            this.nome = "";
            this.localizacao = "";
            this.dono = "";
            this.metragem = 0;
            this.preco = 0;
            this.dt_construcao = DateTime.Today;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setLocalizacao (string localizacao)
        {
            this.localizacao = (localizacao);
        }
        public string getLocalizacao()
        {
            return this.localizacao;
        }

        public void setDono(string dono)
        {
            this.dono = dono;
        }
        public string getDono() { return this.dono; }

        public void setMetragem (double metragem)
        {
            this.metragem = metragem;
        }
        public double getMetragem () { return this.metragem; }

        public void setPreco (double preco)
        {
            this.preco = preco;
        }
        public double getPreco () { return this.preco; }

        public void setDt_Construcao (DateTime dt_construcao)
        {
            this.dt_construcao = dt_construcao;
        }
        public DateTime getDt_Construcao () {  return this.dt_construcao; }

        // Diminuir o preço

        public void diminuir_preco()
        {
            this.preco -= 1000;
        }
        public void diminuir_preco2()
        {
            this.preco -= 10000;
        }

        // Aumentar preço

        public void aumentar_preco()
        {
            this.preco += 1000;
        }

        public void aumentar_preco2()
        {
            this.preco += 10000;
        }
    }
}
