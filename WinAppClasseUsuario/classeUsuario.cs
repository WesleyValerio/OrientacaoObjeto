using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinAppClasseUsuario
{    public class classeUsuario
    {
        //declaração dos atributos
        public string nome { get; set; }
        public string matricula { get; set; }
        public string endereco { get; set; }
        public DateTime dataNasc { get; set; }

        public int idade;


        //método construtor para a classe
        public classeUsuario()
        {
            this.nome = "";
            this.matricula = "";
            this.dataNasc = DateTime.Today;
            this.endereco = "";
            this.idade = 0;
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
