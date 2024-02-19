using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TP1
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string cpf;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public Pessoa(string nome, int idade, string cpf) {
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
        }
    }
}
