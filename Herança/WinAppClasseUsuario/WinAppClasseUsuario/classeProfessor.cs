using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinAppClasseUsuario
{
    public class classeProfessor:classeUsuario
    {
        private int cargaHoraria;
        private string tipo;


        public classeProfessor()
        {
            this.cargaHoraria = 0;
            this.tipo = "";
        }

        //método set e get para o atributo cargaHoraria
        public void setCargaHoraria(int paramCargaHoraria)
        {
            this.cargaHoraria = paramCargaHoraria;
        }

        public int getCargaHoraria()
        {
            return this.cargaHoraria;
        }
        //método para atribuir valor ao tipo
        public void setTipo()
        {
            if (this.cargaHoraria >= 50)
            {
                this.tipo = "Dedicação Integral";
            }
            else
            {
                this.tipo = "Convidado";
            }
        }

        public string getTipo()
        {
            return this.tipo;
        }
    }
}
