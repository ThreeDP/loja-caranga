using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace carshop
{
    public partial class CadastroDeCarro : Form
    {
        MySqlConnection cnxSql;
        public CadastroDeCarro()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Port=3306;Database=loja_de_carros;Uid=root;";
            this.cnxSql = new MySqlConnection(connectionString);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string id_loja = txtIdEmpresa.Text;
            string renavan = txtRenavan.Text;
            string placa = txtPlaca.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string ano_modelo = txtAnoModelo.Text;
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
                carro.CreateCar(this.cnxSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
