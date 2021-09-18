using System;

namespace DIO.CLIENTES
{
    public class Clientes : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private int Numero { get; set; }
        private string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }
        public string Nacionalidade { get; set; }
        public string Telefone { get; set; }
        public DateTime Aniversario { get; set; }
        public string Email { get; set; } 
        public bool Excluido { get; set; }


        public Clientes(int id, Genero genero, string nome, string endereco, int numero, string bairro, string cidade, string estado, string cep, string pais, string nacionalidade, string telefone, DateTime aniversario, string email)
        {
                this.Id = id;
                this.Genero = genero;
                this.Nome = nome;
                this.Endereco = endereco;
                this.Numero = numero;
                this.Bairro = bairro;
                this.Cidade = cidade;
                this.Estado = estado;
                this.Cep = cep;
                this.Pais = pais;
                this.Nacionalidade = nacionalidade;
                this.Telefone = telefone;
                this.Aniversario = aniversario;
                this.Email = email;
                this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Cliente: " + this.Nome + Environment.NewLine;
            retorno += "Endereco: " + this.Endereco + Environment.NewLine;
            retorno += "Numero: " + this.Numero + Environment.NewLine;
            retorno += "Bairro: " + this.Bairro + Environment.NewLine;
            retorno += "Cidade: " + this.Cidade + Environment.NewLine;
            retorno += "Estado: " + this.Estado + Environment.NewLine;
            retorno += "Cep: " + this.Cep + Environment.NewLine;
            retorno += "Pais: " + this.Pais + Environment.NewLine;
            retorno += "Nacionalidade: " + this.Nacionalidade + Environment.NewLine;
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Telefone: " + this.Telefone + Environment.NewLine;
            retorno += "Aniversario: " + this.Aniversario + Environment.NewLine;
            retorno += "Email: " + this.Email + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;

        }

        public string retornaNome()
        {
            return this.Nome;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public string retornaAniversario() 
        {
            return "Aniversário: " + this.Aniversario.ToString();
        }

        public void Excluir() {
            this.Excluido = true;
        }
    

    }
}