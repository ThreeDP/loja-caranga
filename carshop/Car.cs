using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Numerics;

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
            cmd.CommandText = "INSERT INTO carros(renavan, placa, marca_id, tipo_id, ano_fabricacao, descrição, situacao) " +
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

        static public List<string> GetListaModelos(MySqlConnection cnn)
        {
            List<string> lista = new List<string>();
            var cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT modelo, ano_modelo FROM modelos";
            cnn.Open();
            cmd.ExecuteNonQuery();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string? modelo = Convert.ToString(reader["modelo"]);
                    string? ano_modelo = Convert.ToString(reader["ano_modelo"]);
                    if (modelo != null && ano_modelo != null)
                    {
                        lista.Add(modelo + " | " + ano_modelo);
                    }
                }
            }

            cnn.Close();
            return lista;
        }

        static public List<string> GetListaMarcas(MySqlConnection cnn)
        {
            List<string> lista = new List<string>();
            var cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT marca FROM marcas";
            cnn.Open();
            cmd.ExecuteNonQuery();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string? marca = Convert.ToString(reader["marca"]);
                    if (marca != null)
                    {
                        lista.Add(marca);
                    }
                }
            }

            cnn.Close();
            return lista;
        }

        static public List<string> GetListaTipos(MySqlConnection cnn)
        {
            List<string> lista = new List<string>();
            var cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT tipo FROM tipos_de_veiculos";
            cnn.Open();
            cmd.ExecuteNonQuery();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string? tipo = Convert.ToString(reader["tipo"]);
                    if (tipo != null)
                    {
                        lista.Add(tipo);
                    }
                }
            }

            cnn.Close();
            return lista;
        }

    }

}
