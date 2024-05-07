using System;
using System.Data.SqlClient;

namespace carshop
{
    public partial class Form1 : Form
    {
        List<Carro> carros;

        public Form1()
        {
            InitializeComponent();
            this.carros = new List<Carro>();
        }

        public void printNovoCarro(Carro c)
        {
            txtOutputTest.Text += $"Loja: {c.id_loja}\r\n";
            txtOutputTest.Text += $"Loja: {c.renavan}\r\n";
            txtOutputTest.Text += $"Loja: {c.placa}\r\n\r\n";
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
                printNovoCarro(carro);
                carros.Add(carro);
            } catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
                return;
            }
        }
    }
}
