using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace carshop
{
    public partial class CadastroDeCarro : Form
    {
        private void preencherModelos()
        {
            MySqlConnection? cnn = Mysql.GetMySqlConnection();
            if (cnn != null)
            {
                List<string> modelos = Carro.GetListaModelos(cnn);
                foreach(var modelo in modelos)
                {
                    cbListaModelo.Items.Add(modelo.ToString());
                }
            }
        }

        private void preencherMarcas()
        {
            MySqlConnection? cnn = Mysql.GetMySqlConnection();
            if (cnn != null)
            {
                List<string> marcas = Carro.GetListaMarcas(cnn);
                foreach (var marca in marcas)
                {
                    cbListaMarca.Items.Add(marca.ToString());
                }
            }
        }

        private void preencherTipos()
        {
            MySqlConnection? conn = Mysql.GetMySqlConnection();
            if (conn != null)
            {
                List<string> tipos = Carro.GetListaTipos(conn);
                foreach (var tipo in tipos)
                {
                    cbListaTipoVeiculo.Items.Add(tipo.ToString());
                }
            }
        }

        public CadastroDeCarro()
        {
            InitializeComponent();
            this.preencherMarcas();
            this.preencherModelos();
            this.preencherTipos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string id_loja = txtIdEmpresa.Text;
            string renavan = txtRenavan.Text;
            string placa = txtPlaca.Text;
            string marca = cbListaMarca.Text;
            string modelo = cbListaModelo.Text;
            string ano_modelo = cbListaTipoVeiculo.Text;
            string ano_fabricacao = txbAnoFabricacao.Text;
            string observacao = txtObservacao.Text;
            string situacao = txbSituacao.Text;
            try
            {
                Carro carro = new Carro(
                    Convert.ToInt32(id_loja),
                    renavan,
                    placa,
                    marca,
                    modelo,
                    Convert.ToInt32(ano_modelo),
                    Convert.ToInt32(ano_fabricacao),
                    observacao,
                    situacao
                    );
                MySqlConnection? cnn = Mysql.GetMySqlConnection();
                if (cnn != null)
                {
                    carro.CreateCar(cnn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

    }
}
