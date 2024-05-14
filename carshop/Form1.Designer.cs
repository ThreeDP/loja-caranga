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
            txtMarca = new TextBox();
            lblMarca = new Label();
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtAnoModelo = new TextBox();
            lblAnoModelo = new Label();
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
            SuspendLayout();
            // 
            // lblIDEmpresa
            // 
            lblIDEmpresa.AutoSize = true;
            lblIDEmpresa.Location = new Point(12, 85);
            lblIDEmpresa.Name = "lblIDEmpresa";
            lblIDEmpresa.Size = new Size(66, 15);
            lblIDEmpresa.TabIndex = 0;
            lblIDEmpresa.Text = "ID Empresa";
            // 
            // txtIdEmpresa
            // 
            txtIdEmpresa.BackColor = Color.FromArgb(249, 230, 211);
            txtIdEmpresa.Location = new Point(12, 103);
            txtIdEmpresa.Name = "txtIdEmpresa";
            txtIdEmpresa.Size = new Size(165, 23);
            txtIdEmpresa.TabIndex = 1;
            // 
            // txtRenavan
            // 
            txtRenavan.BackColor = Color.FromArgb(249, 230, 211);
            txtRenavan.Location = new Point(198, 103);
            txtRenavan.Name = "txtRenavan";
            txtRenavan.Size = new Size(105, 23);
            txtRenavan.TabIndex = 3;
            // 
            // lblRenavan
            // 
            lblRenavan.AutoSize = true;
            lblRenavan.Location = new Point(198, 85);
            lblRenavan.Name = "lblRenavan";
            lblRenavan.Size = new Size(52, 15);
            lblRenavan.TabIndex = 2;
            lblRenavan.Text = "Renavan";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.FromArgb(249, 230, 211);
            txtPlaca.Location = new Point(325, 103);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(97, 23);
            txtPlaca.TabIndex = 5;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(325, 85);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 4;
            lblPlaca.Text = "Placa";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(249, 230, 211);
            txtMarca.Location = new Point(12, 193);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(228, 23);
            txtMarca.TabIndex = 7;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.Transparent;
            lblMarca.ForeColor = SystemColors.ButtonHighlight;
            lblMarca.Location = new Point(12, 175);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(249, 230, 211);
            txtModelo.Location = new Point(255, 193);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(165, 23);
            txtModelo.TabIndex = 9;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Transparent;
            lblModelo.ForeColor = SystemColors.ButtonHighlight;
            lblModelo.Location = new Point(255, 175);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 8;
            lblModelo.Text = "Modelo";
            // 
            // txtAnoModelo
            // 
            txtAnoModelo.BackColor = Color.FromArgb(249, 230, 211);
            txtAnoModelo.Location = new Point(12, 242);
            txtAnoModelo.Name = "txtAnoModelo";
            txtAnoModelo.Size = new Size(122, 23);
            txtAnoModelo.TabIndex = 11;
            // 
            // lblAnoModelo
            // 
            lblAnoModelo.AutoSize = true;
            lblAnoModelo.BackColor = Color.Transparent;
            lblAnoModelo.ForeColor = SystemColors.ButtonHighlight;
            lblAnoModelo.Location = new Point(12, 224);
            lblAnoModelo.Name = "lblAnoModelo";
            lblAnoModelo.Size = new Size(90, 15);
            lblAnoModelo.TabIndex = 10;
            lblAnoModelo.Text = "Ano do Modelo";
            // 
            // txbAnoFabricacao
            // 
            txbAnoFabricacao.BackColor = Color.FromArgb(249, 230, 211);
            txbAnoFabricacao.Location = new Point(151, 242);
            txbAnoFabricacao.Name = "txbAnoFabricacao";
            txbAnoFabricacao.Size = new Size(110, 23);
            txbAnoFabricacao.TabIndex = 13;
            // 
            // lblAno_fabricacao
            // 
            lblAno_fabricacao.AutoSize = true;
            lblAno_fabricacao.BackColor = Color.Transparent;
            lblAno_fabricacao.ForeColor = SystemColors.ButtonHighlight;
            lblAno_fabricacao.Location = new Point(151, 224);
            lblAno_fabricacao.Name = "lblAno_fabricacao";
            lblAno_fabricacao.Size = new Size(89, 15);
            lblAno_fabricacao.TabIndex = 12;
            lblAno_fabricacao.Text = "Ano Fabricação";
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.FromArgb(249, 230, 211);
            txtObservacao.Location = new Point(12, 298);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(410, 135);
            txtObservacao.TabIndex = 15;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.BackColor = Color.Transparent;
            lblObservacao.ForeColor = SystemColors.ButtonHighlight;
            lblObservacao.Location = new Point(12, 280);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 14;
            lblObservacao.Text = "Observação";
            // 
            // txbSituacao
            // 
            txbSituacao.BackColor = Color.FromArgb(249, 230, 211);
            txbSituacao.Location = new Point(284, 242);
            txbSituacao.Name = "txbSituacao";
            txbSituacao.Size = new Size(138, 23);
            txbSituacao.TabIndex = 21;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.BackColor = Color.Transparent;
            lblSituacao.ForeColor = SystemColors.ButtonHighlight;
            lblSituacao.Location = new Point(284, 224);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 20;
            lblSituacao.Text = "Situação";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(249, 230, 211);
            btnCadastrar.Location = new Point(12, 452);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(133, 35);
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
            lblCadastroDeCarro.Location = new Point(12, 27);
            lblCadastroDeCarro.Name = "lblCadastroDeCarro";
            lblCadastroDeCarro.Size = new Size(249, 37);
            lblCadastroDeCarro.TabIndex = 23;
            lblCadastroDeCarro.Text = "Cadastro de Carro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 146);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
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
            // CadastroDeCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(442, 512);
            Controls.Add(label1);
            Controls.Add(lblCadastroDeCarro);
            Controls.Add(btnCadastrar);
            Controls.Add(txbSituacao);
            Controls.Add(lblSituacao);
            Controls.Add(txtObservacao);
            Controls.Add(lblObservacao);
            Controls.Add(txbAnoFabricacao);
            Controls.Add(lblAno_fabricacao);
            Controls.Add(txtAnoModelo);
            Controls.Add(lblAnoModelo);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(txtMarca);
            Controls.Add(lblMarca);
            Controls.Add(txtPlaca);
            Controls.Add(lblPlaca);
            Controls.Add(txtRenavan);
            Controls.Add(lblRenavan);
            Controls.Add(txtIdEmpresa);
            Controls.Add(lblIDEmpresa);
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
        private TextBox txtMarca;
        private Label lblMarca;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtAnoModelo;
        private Label lblAnoModelo;
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
    }
}
