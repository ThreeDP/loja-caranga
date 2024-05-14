using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

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
        public int ano_fabricacao;
        public string observacao;
        DateTime data_cadastro;
        DateTime data_alteracao;
        string situacao;
  

        public Carro (int id_loja, string renavan, string placa, string marca, string modelo, int ano_modelo, int ano_fabricacao, string observacao, string situacao)
        {
            this.id_loja = id_loja;
            this.renavan = renavan;
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.ano_modelo = ano_modelo;
            this.ano_fabricacao = ano_fabricacao;
            this.observacao = observacao;
            this.data_cadastro = DateTime.Now;
            this.data_alteracao = DateTime.Now;
            this.situacao = situacao;
        }

        public void CreateCar(MySqlConnection cnn)
        {
            var cmd = cnn.CreateCommand();
            cmd.CommandText = "INSERT INTO carros(id_loja, renavan, placa, marca, modelo, ano_modelo, ano_fabricacao, observacao, situacao) " +
                "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?)";
            cmd.Parameters.AddWithValue("@id_loja", this.id_loja);
            cmd.Parameters.AddWithValue("@renavan", this.renavan);
            cmd.Parameters.AddWithValue("@placa", this.placa);
            cmd.Parameters.AddWithValue("@marca", this.marca);
            cmd.Parameters.AddWithValue("@modelo", this.modelo);
            cmd.Parameters.AddWithValue("@ano_modelo", this.ano_modelo);
            cmd.Parameters.AddWithValue("@ano_fabricacao", this.ano_fabricacao);
            cmd.Parameters.AddWithValue("@observacao", this.observacao);
            cmd.Parameters.AddWithValue("situacao", this.situacao);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }

}
