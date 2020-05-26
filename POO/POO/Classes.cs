using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Funcionario
    {
        public string Nome, Cargo;
        public float Salario, Desconto, Adicional, Liquido;
        public Funcionario(string nome, float salario, float desconto, float adicional, string cargo) {
            Nome = nome;
            Salario = salario;
            Desconto = desconto;
            Adicional = adicional;
            Cargo = cargo;
        }
        public float calculaLiquido(float salario, float desconto, float adicional)
        {
            this.Liquido = (salario + adicional) - desconto;
            return Liquido;
            
        }
        public float CalcularBonus(float liquido)
        {
            Liquido = liquido;
            double Bonus = Convert.ToDouble(Liquido) * 0.01;
            Liquido = (float)Bonus + Liquido;
            return Liquido;
        }
    }
    public class Gerente : Funcionario {
        public Gerente(string nome, float salario, float desconto, float adicional, string cargo) : base(nome, salario,desconto,adicional, cargo) 
        {
        }
        public float CalcularBonus(float liquido)
        {
            Liquido = liquido;
            double Bonus = Convert.ToDouble(Liquido) * 0.02;
            Liquido = (float)Bonus + Liquido;
            return Liquido;
        }
    }
    // --------------------------------------------------------AQUI COMEÇA O CÓDIGO DAS CLASSES DA AGENDA----------------------------------------------------------------
    public class Pessoa {
        public string Nome, Endereco, Email;
        public int Telefone;
        public Pessoa(string nome, string endereço, int telefone, string email) 
        {
            Nome = nome;
            Endereco = endereço;
            Telefone = telefone;
            Email = email;
        }
        public Pessoa() { }
    }
    public class Agenda : Pessoa
    {
        public Agenda() { }
        public void Adicionar(string nome, string endereco, int telefone, string email) {
            
        }
        public void Editar(string nome, string endereco, int telefone, string email) { }
        public void Salvar(string nome, string endereco, int telefone, string email) { }
        public void Excluir(string nome, string endereco, int telefone, string email) { }        
    }
}
