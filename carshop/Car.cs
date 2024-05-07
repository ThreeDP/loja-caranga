using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace carshop
{
    public class Carro
    {
        public int id_loja;
        public string renavan;
        public string placa;
        public string marca;
        public string modelo;
        public int ano_modelo;
        public int Ano_fabricacao;
        public string observacao;
        DateTime data_cadastro;
        DateTime data_alteracao;
        string situacao;
        SqlConnection sql;

        public Carro (int id_loja, string renavan, string placa, string marca, string modelo, int ano_modelo, int ano_fabricacao, string observacao, string situacao)
        {
            this.id_loja = id_loja;
            this.renavan = renavan;
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.ano_modelo = ano_modelo;
            Ano_fabricacao = ano_fabricacao;
            this.observacao = observacao;
            this.data_cadastro = DateTime.Now;
            this.data_alteracao = DateTime.Now;
            this.situacao = situacao;
            string connectionString = "Server=sqlexpress;Database=loja_caranga;User ID=aluno;Password=aluno";
            SqlConnection s = null;
            SqlConnection connection = new SqlConnection(connectionString);

        }

    }

}
