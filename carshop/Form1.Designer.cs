namespace carshop
{
    partial class CadastroDeCarro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIDEmpresa = new Label();
            txtIdEmpresa = new TextBox();
            txtRenavan = new TextBox();
            lblRenavan = new Label();
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            txbAnoFabricacao = new TextBox();
            lblAno_fabricacao = new Label();
            txtObservacao = new TextBox();
            lblObservacao = new Label();
            txbSituacao = new TextBox();
            lblSituacao = new Label();
            btnCadastrar = new Button();
            lblCadastroDeCarro = new Label();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            cbListaMarca = new ComboBox();
            cbListaModelo = new ComboBox();
            cbListaTipoVeiculo = new ComboBox();
            lblTipoVeiculo = new Label();
            SuspendLayout();
            // 
            // lblIDEmpresa
            // 
            lblIDEmpresa.AutoSize = true;
            lblIDEmpresa.ForeColor = SystemColors.Info;
            lblIDEmpresa.Location = new Point(14, 113);
            lblIDEmpresa.Name = "lblIDEmpresa";
            lblIDEmpresa.Size = new Size(85, 20);
            lblIDEmpresa.TabIndex = 0;
            lblIDEmpresa.Text = "ID Empresa";
            // 
            // txtIdEmpresa
            // 
            txtIdEmpresa.BackColor = Color.FromArgb(249, 230, 211);
            txtIdEmpresa.Location = new Point(14, 137);
            txtIdEmpresa.Margin = new Padding(3, 4, 3, 4);
            txtIdEmpresa.Name = "txtIdEmpresa";
            txtIdEmpresa.Size = new Size(188, 27);
            txtIdEmpresa.TabIndex = 1;
            // 
            // txtRenavan
            // 
            txtRenavan.BackColor = Color.FromArgb(249, 230, 211);
            txtRenavan.Location = new Point(226, 137);
            txtRenavan.Margin = new Padding(3, 4, 3, 4);
            txtRenavan.Name = "txtRenavan";
            txtRenavan.Size = new Size(119, 27);
            txtRenavan.TabIndex = 3;
            // 
            // lblRenavan
            // 
            lblRenavan.AutoSize = true;
            lblRenavan.ForeColor = SystemColors.Info;
            lblRenavan.Location = new Point(226, 113);
            lblRenavan.Name = "lblRenavan";
            lblRenavan.Size = new Size(65, 20);
            lblRenavan.TabIndex = 2;
            lblRenavan.Text = "Renavan";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.FromArgb(249, 230, 211);
            txtPlaca.Location = new Point(371, 137);
            txtPlaca.Margin = new Padding(3, 4, 3, 4);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(110, 27);
            txtPlaca.TabIndex = 5;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.ForeColor = SystemColors.Info;
            lblPlaca.Location = new Point(371, 113);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(44, 20);
            lblPlaca.TabIndex = 4;
            lblPlaca.Text = "Placa";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.ForeColor = SystemColors.ButtonHighlight;
            lblMarca.Location = new Point(14, 233);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Transparent;
            lblModelo.ForeColor = SystemColors.ButtonHighlight;
            lblModelo.Location = new Point(291, 233);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 20);
            lblModelo.TabIndex = 8;
            lblModelo.Text = "Modelo";
            // 
            // txbAnoFabricacao
            // 
            txbAnoFabricacao.BackColor = Color.FromArgb(249, 230, 211);
            txbAnoFabricacao.Location = new Point(174, 419);
            txbAnoFabricacao.Margin = new Padding(3, 4, 3, 4);
            txbAnoFabricacao.Name = "txbAnoFabricacao";
            txbAnoFabricacao.Size = new Size(125, 27);
            txbAnoFabricacao.TabIndex = 13;
            // 
            // lblAno_fabricacao
            // 
            lblAno_fabricacao.AutoSize = true;
            lblAno_fabricacao.BackColor = Color.Transparent;
            lblAno_fabricacao.ForeColor = SystemColors.ButtonHighlight;
            lblAno_fabricacao.Location = new Point(174, 395);
            lblAno_fabricacao.Name = "lblAno_fabricacao";
            lblAno_fabricacao.Size = new Size(111, 20);
            lblAno_fabricacao.TabIndex = 12;
            lblAno_fabricacao.Text = "Ano Fabricação";
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.FromArgb(249, 230, 211);
            txtObservacao.Location = new Point(14, 466);
            txtObservacao.Margin = new Padding(3, 4, 3, 4);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(468, 110);
            txtObservacao.TabIndex = 15;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.BackColor = Color.Transparent;
            lblObservacao.ForeColor = SystemColors.ButtonHighlight;
            lblObservacao.Location = new Point(14, 432);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(87, 20);
            lblObservacao.TabIndex = 14;
            lblObservacao.Text = "Observação";
            // 
            // txbSituacao
            // 
            txbSituacao.BackColor = Color.FromArgb(249, 230, 211);
            txbSituacao.Location = new Point(326, 419);
            txbSituacao.Margin = new Padding(3, 4, 3, 4);
            txbSituacao.Name = "txbSituacao";
            txbSituacao.Size = new Size(157, 27);
            txbSituacao.TabIndex = 21;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.BackColor = Color.Transparent;
            lblSituacao.ForeColor = SystemColors.ButtonHighlight;
            lblSituacao.Location = new Point(326, 395);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(66, 20);
            lblSituacao.TabIndex = 20;
            lblSituacao.Text = "Situação";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(249, 230, 211);
            btnCadastrar.Location = new Point(14, 603);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(152, 47);
            btnCadastrar.TabIndex = 22;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCadastroDeCarro
            // 
            lblCadastroDeCarro.AutoSize = true;
            lblCadastroDeCarro.BackColor = Color.Transparent;
            lblCadastroDeCarro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastroDeCarro.ForeColor = SystemColors.ButtonHighlight;
            lblCadastroDeCarro.Location = new Point(14, 36);
            lblCadastroDeCarro.Name = "lblCadastroDeCarro";
            lblCadastroDeCarro.Size = new Size(306, 46);
            lblCadastroDeCarro.TabIndex = 23;
            lblCadastroDeCarro.Text = "Cadastro de Carro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 195);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 24;
            label1.Text = "Informações do Carro";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // cbListaMarca
            // 
            cbListaMarca.BackColor = Color.FromArgb(255, 224, 192);
            cbListaMarca.FormattingEnabled = true;
            cbListaMarca.Location = new Point(14, 256);
            cbListaMarca.Name = "cbListaMarca";
            cbListaMarca.Size = new Size(246, 28);
            cbListaMarca.TabIndex = 25;
            cbListaMarca.Text = "Selecione um opção";
            // 
            // cbListaModelo
            // 
            cbListaModelo.BackColor = Color.FromArgb(255, 224, 192);
            cbListaModelo.FormattingEnabled = true;
            cbListaModelo.Location = new Point(291, 256);
            cbListaModelo.Name = "cbListaModelo";
            cbListaModelo.Size = new Size(191, 28);
            cbListaModelo.TabIndex = 26;
            cbListaModelo.Text = "Selecione um opção";
            // 
            // cbListaTipoVeiculo
            // 
            cbListaTipoVeiculo.BackColor = Color.FromArgb(255, 224, 192);
            cbListaTipoVeiculo.FormattingEnabled = true;
            cbListaTipoVeiculo.Location = new Point(14, 322);
            cbListaTipoVeiculo.Name = "cbListaTipoVeiculo";
            cbListaTipoVeiculo.Size = new Size(246, 28);
            cbListaTipoVeiculo.TabIndex = 28;
            cbListaTipoVeiculo.Text = "Selecione um opção";
            // 
            // lblTipoVeiculo
            // 
            lblTipoVeiculo.AutoSize = true;
            lblTipoVeiculo.BackColor = Color.Transparent;
            lblTipoVeiculo.ForeColor = SystemColors.ButtonHighlight;
            lblTipoVeiculo.Location = new Point(14, 299);
            lblTipoVeiculo.Name = "lblTipoVeiculo";
            lblTipoVeiculo.Size = new Size(39, 20);
            lblTipoVeiculo.TabIndex = 27;
            lblTipoVeiculo.Text = "Tipo";
            // 
            // CadastroDeCarro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(505, 683);
            Controls.Add(cbListaTipoVeiculo);
            Controls.Add(lblTipoVeiculo);
            Controls.Add(cbListaModelo);
            Controls.Add(cbListaMarca);
            Controls.Add(label1);
            Controls.Add(lblCadastroDeCarro);
            Controls.Add(btnCadastrar);
            Controls.Add(txbSituacao);
            Controls.Add(lblSituacao);
            Controls.Add(txtObservacao);
            Controls.Add(lblObservacao);
            Controls.Add(txbAnoFabricacao);
            Controls.Add(lblAno_fabricacao);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(txtPlaca);
            Controls.Add(lblPlaca);
            Controls.Add(txtRenavan);
            Controls.Add(lblRenavan);
            Controls.Add(txtIdEmpresa);
            Controls.Add(lblIDEmpresa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroDeCarro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Carro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDEmpresa;
        private TextBox txtIdEmpresa;
        private TextBox txtRenavan;
        private Label lblRenavan;
        private TextBox txtPlaca;
        private Label lblPlaca;
        private Label lblMarca;
        private Label lblModelo;
        private TextBox txbAnoFabricacao;
        private Label lblAno_fabricacao;
        private TextBox txtObservacao;
        private Label lblObservacao;
        private TextBox txbSituacao;
        private Label lblSituacao;
        private Button btnCadastrar;
        private Label lblCadastroDeCarro;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ComboBox cbListaMarca;
        private ComboBox cbListaModelo;
        private ComboBox cbListaTipoVeiculo;
        private Label lblTipoVeiculo;
    }
}
