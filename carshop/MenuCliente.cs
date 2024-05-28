using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carshop
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNomeCliente.Text.Normalize().ToUpper();
            string tipoDocumento = cbTipoDocumento.Text;
            string numeroDoc = txtNumeroCPFCNPJ.Text;
            string telefone = txtTelefoneCliente.Text;
            if (nomeCliente != "" && tipoDocumento != "" && tipoDocumento != "Selecione um opção" && numeroDoc != "" && telefone != "")
            {
                try
                {
                    if (tipoDocumento == "CPF")
                    {
                        numeroDoc = Format.FormatarCPF(numeroDoc);
                    }
                    else if (tipoDocumento == "CNPJ")
                    {
                        numeroDoc = Format.FormatarCNPJ(numeroDoc);
                    }

                    telefone = Format.FormatarTelefone(telefone);

                    Cliente cliente = new Cliente(nomeCliente, tipoDocumento, numeroDoc, telefone);
                    MySqlConnection? cnn = Mysql.GetMySqlConnection();
                    if (cnn != null)
                    {
                        cliente.CriarCliente(cnn);
                        MessageBox.Show("Cliente Cadastrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnMostraClientes_Click(object sender, EventArgs e)
        {
            MySqlConnection? cnn = Mysql.GetMySqlConnection();
            string listaCliente = "";
            if (cnn != null)
            {
                listaCliente = Cliente.GetListaDeClientes (cnn);

            }
            txtListaDeClientes.Text = listaCliente; 
        }
    }
}
