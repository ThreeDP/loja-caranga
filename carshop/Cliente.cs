using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carshop
{
    public class Cliente
    {
        string _nome;
        string _tipoDocumento;
        string _numeroDocumento;
        string _telefone;

        public Cliente(string nome, string tipoDocumento, string numeroDocumento, string telefone)
        {
            _nome = nome;
            _tipoDocumento = tipoDocumento;
            _numeroDocumento = numeroDocumento;
            _telefone = telefone;
        }

        public void    CriarCliente(MySqlConnection cnn)
        {
            var cmd = cnn.CreateCommand();
            cmd.CommandText = "INSERT INTO clientes(nome_cliente, tipo_documento, documento_cliente, telefone_cliente)" +
                "VALUES(?, ?, ?, ?)";
            cmd.Parameters.AddWithValue("@nome_cliente", this._nome);
            cmd.Parameters.AddWithValue("@tipo_documento", this._tipoDocumento);
            cmd.Parameters.AddWithValue("@documento_cliente", this._numeroDocumento);
            cmd.Parameters.AddWithValue("@telefone_cliente", this._telefone);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        static public string GetListaDeClientes(MySqlConnection cnn)
        {
            var cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT * FROM clientes";
            cnn.Open();
            cmd.ExecuteNonQuery();
            string lista = "";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista += Convert.ToString(reader["cliente_id"]) + " | ";
                    lista += reader["nome_cliente"] + " | ";
                    lista += Convert.ToString(reader["tipo_documento"]) + " | ";
                    lista += reader["documento_cliente"] + " | ";
                    lista += reader["telefone_cliente"] + "\r\n";
                }
            }

            cnn.Close();
            return lista;
        }
    }
}
