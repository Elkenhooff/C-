using Mysqlx.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class ClienteInformation
    {
        //Encapsulamento: é a proteção das variáveis, com a criação de um método intermediador da var com o sistema.
        //Esse metódo disponibiliza os dados armazenados nas variáveis ou vai possibilitar a criação ou alteração dos dados na varíavel.
        //Atralaho -> propfull + tab

        private int codigo;

        public int Codigo
        {
            get { return codigo; } //Obter/Retornar do Banco
            set { codigo = value; } //Alterar no Banco
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string rua;

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        private DateTime datanascimento;

        public DateTime Datanascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }
        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }

        }

    }
}
