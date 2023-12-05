using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Receita
{
    internal class Receita
    {
        public string nome { get; set; }
        public DateTime dtcadastro { get; set; }
        public int calorias { get; set; }
        public bool saudavel { get; set; }
        public List<string> Ingredientes { get; set; }
        
        public Receita()
        {
            this.nome = string.Empty;
            this.calorias = 0;
            this.saudavel = false;
            Ingredientes = new List<string>(); //inicializando a lista

           
        }

        // Método para Add um ingrediente na lista
        //será alterado 

        //public void adicionarItem(string item)
        //{
         //   Ingredientes.Add(item);
        //}

    }
    }





