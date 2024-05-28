namespace carshop
{
    partial class MenuCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCadastroDeCliente = new Label();
            txtTelefoneCliente = new TextBox();
            lblTelefoneCliente = new Label();
            txtNumeroCPFCNPJ = new TextBox();
            lblTipoDocumento = new Label();
            txtNomeCliente = new TextBox();
            lblNomeCompleto = new Label();
            btnCadastrarCliente = new Button();
            cbTipoDocumento = new ComboBox();
            lblCPFCNPJCliente = new Label();
            lblListaDeClientes = new Label();
            btnMostraClientes = new Button();
            txtListaDeClientes = new TextBox();
            SuspendLayout();
            // 
            // lblCadastroDeCliente
            // 
            lblCadastroDeCliente.AutoSize = true;
            lblCadastroDeCliente.BackColor = Color.Transparent;
            lblCadastroDeCliente.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastroDeCliente.ForeColor = SystemColors.ButtonHighlight;
            lblCadastroDeCliente.Location = new Point(20, 24);
            lblCadastroDeCliente.Name = "lblCadastroDeCliente";
            lblCadastroDeCliente.Size = new Size(329, 46);
            lblCadastroDeCliente.TabIndex = 0;
            lblCadastroDeCliente.Text = "Cadastro de Cliente";
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.BackColor = Color.FromArgb(249, 230, 211);
            txtTelefoneCliente.Location = new Point(20, 281);
            txtTelefoneCliente.Margin = new Padding(3, 4, 3, 4);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(217, 27);
            txtTelefoneCliente.TabIndex = 8;
            // 
            // lblTelefoneCliente
            // 
            lblTelefoneCliente.AutoSize = true;
            lblTelefoneCliente.BackColor = Color.Transparent;
            lblTelefoneCliente.ForeColor = SystemColors.ButtonHighlight;
            lblTelefoneCliente.Location = new Point(20, 257);
            lblTelefoneCliente.Name = "lblTelefoneCliente";
            lblTelefoneCliente.Size = new Size(66, 20);
            lblTelefoneCliente.TabIndex = 7;
            lblTelefoneCliente.Text = "Telefone";
            // 
            // txtNumeroCPFCNPJ
            // 
            txtNumeroCPFCNPJ.BackColor = Color.FromArgb(249, 230, 211);
            txtNumeroCPFCNPJ.Location = new Point(236, 209);
            txtNumeroCPFCNPJ.Margin = new Padding(3, 4, 3, 4);
            txtNumeroCPFCNPJ.Name = "txtNumeroCPFCNPJ";
            txtNumeroCPFCNPJ.Size = new Size(250, 27);
            txtNumeroCPFCNPJ.TabIndex = 6;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.BackColor = Color.Transparent;
            lblTipoDocumento.ForeColor = SystemColors.ButtonHighlight;
            lblTipoDocumento.Location = new Point(20, 180);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(121, 20);
            lblTipoDocumento.TabIndex = 3;
            lblTipoDocumento.Text = "Tipo Documento";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = Color.FromArgb(249, 230, 211);
            txtNomeCliente.Location = new Point(20, 125);
            txtNomeCliente.Margin = new Padding(3, 4, 3, 4);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(466, 27);
            txtNomeCliente.TabIndex = 2;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.ForeColor = SystemColors.Info;
            lblNomeCompleto.Location = new Point(20, 101);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(120, 20);
            lblNomeCompleto.TabIndex = 1;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.BackColor = Color.FromArgb(249, 230, 211);
            btnCadastrarCliente.Location = new Point(298, 281);
            btnCadastrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(188, 27);
            btnCadastrarCliente.TabIndex = 9;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = false;
            btnCadastrarCliente.Click += btnCadastrar_Click;
            // 
            // cbTipoDocumento
            // 
            cbTipoDocumento.BackColor = Color.FromArgb(255, 224, 192);
            cbTipoDocumento.FormattingEnabled = true;
            cbTipoDocumento.Items.AddRange(new object[] { "CPF", "CNPJ" });
            cbTipoDocumento.Location = new Point(20, 209);
            cbTipoDocumento.Name = "cbTipoDocumento";
            cbTipoDocumento.Size = new Size(179, 28);
            cbTipoDocumento.TabIndex = 4;
            cbTipoDocumento.Text = "Selecione um opção";
            // 
            // lblCPFCNPJCliente
            // 
            lblCPFCNPJCliente.AutoSize = true;
            lblCPFCNPJCliente.BackColor = Color.Transparent;
            lblCPFCNPJCliente.ForeColor = SystemColors.ButtonHighlight;
            lblCPFCNPJCliente.Location = new Point(236, 180);
            lblCPFCNPJCliente.Name = "lblCPFCNPJCliente";
            lblCPFCNPJCliente.Size = new Size(79, 20);
            lblCPFCNPJCliente.TabIndex = 5;
            lblCPFCNPJCliente.Text = "CPF / CNPJ";
            // 
            // lblListaDeClientes
            // 
            lblListaDeClientes.AutoSize = true;
            lblListaDeClientes.BackColor = Color.Transparent;
            lblListaDeClientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaDeClientes.ForeColor = SystemColors.ButtonHighlight;
            lblListaDeClientes.Location = new Point(20, 339);
            lblListaDeClientes.Name = "lblListaDeClientes";
            lblListaDeClientes.Size = new Size(146, 46);
            lblListaDeClientes.TabIndex = 10;
            lblListaDeClientes.Text = "Clientes";
            // 
            // btnMostraClientes
            // 
            btnMostraClientes.BackColor = Color.FromArgb(255, 224, 192);
            btnMostraClientes.ForeColor = SystemColors.InfoText;
            btnMostraClientes.Location = new Point(20, 396);
            btnMostraClientes.Name = "btnMostraClientes";
            btnMostraClientes.Size = new Size(165, 29);
            btnMostraClientes.TabIndex = 11;
            btnMostraClientes.Text = "Mostrar Clientes";
            btnMostraClientes.UseVisualStyleBackColor = false;
            btnMostraClientes.Click += btnMostraClientes_Click;
            // 
            // txtListaDeClientes
            // 
            txtListaDeClientes.BackColor = SystemColors.Info;
            txtListaDeClientes.Enabled = false;
            txtListaDeClientes.Location = new Point(20, 445);
            txtListaDeClientes.Multiline = true;
            txtListaDeClientes.Name = "txtListaDeClientes";
            txtListaDeClientes.Size = new Size(466, 226);
            txtListaDeClientes.TabIndex = 12;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(505, 683);
            Controls.Add(txtListaDeClientes);
            Controls.Add(btnMostraClientes);
            Controls.Add(lblListaDeClientes);
            Controls.Add(lblCPFCNPJCliente);
            Controls.Add(cbTipoDocumento);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(lblCadastroDeCliente);
            Controls.Add(txtTelefoneCliente);
            Controls.Add(lblTelefoneCliente);
            Controls.Add(txtNumeroCPFCNPJ);
            Controls.Add(lblTipoDocumento);
            Controls.Add(txtNomeCliente);
            Controls.Add(lblNomeCompleto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuCliente";
            Text = "MenuCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCadastroDeCliente;
        private TextBox txtTelefoneCliente;
        private Label lblTelefoneCliente;
        private TextBox txtNumeroCPFCNPJ;
        private Label lblTipoDocumento;
        private TextBox txtNomeCliente;
        private Label lblNomeCompleto;
        private Button btnCadastrarCliente;
        private ComboBox cbTipoDocumento;
        private Label lblCPFCNPJCliente;
        private Label lblListaDeClientes;
        private Button btnMostraClientes;
        private TextBox txtListaDeClientes;
    }
}