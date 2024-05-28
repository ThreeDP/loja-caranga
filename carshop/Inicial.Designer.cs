namespace carshop
{
    partial class Inicial
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
            MenuCarro = new Button();
            pictureBox1 = new PictureBox();
            btnMenuCliente = new Button();
            btnMenuCompraVenda = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuCarro
            // 
            MenuCarro.BackColor = SystemColors.InactiveCaptionText;
            MenuCarro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuCarro.ForeColor = SystemColors.Control;
            MenuCarro.Location = new Point(406, 338);
            MenuCarro.Margin = new Padding(3, 4, 3, 4);
            MenuCarro.Name = "MenuCarro";
            MenuCarro.Size = new Size(217, 37);
            MenuCarro.TabIndex = 0;
            MenuCarro.Text = "Menu Carro";
            MenuCarro.UseVisualStyleBackColor = false;
            MenuCarro.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled_design__2_;
            pictureBox1.Location = new Point(-13, -54);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(690, 789);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnMenuCliente
            // 
            btnMenuCliente.BackColor = SystemColors.InactiveCaptionText;
            btnMenuCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuCliente.ForeColor = SystemColors.Control;
            btnMenuCliente.Location = new Point(406, 257);
            btnMenuCliente.Margin = new Padding(3, 4, 3, 4);
            btnMenuCliente.Name = "btnMenuCliente";
            btnMenuCliente.Size = new Size(217, 42);
            btnMenuCliente.TabIndex = 2;
            btnMenuCliente.Text = "Menu Cliente";
            btnMenuCliente.UseVisualStyleBackColor = false;
            btnMenuCliente.Click += btnMenuCliente_Click;
            // 
            // btnMenuCompraVenda
            // 
            btnMenuCompraVenda.BackColor = SystemColors.InactiveCaptionText;
            btnMenuCompraVenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuCompraVenda.ForeColor = SystemColors.Control;
            btnMenuCompraVenda.Location = new Point(406, 407);
            btnMenuCompraVenda.Margin = new Padding(3, 4, 3, 4);
            btnMenuCompraVenda.Name = "btnMenuCompraVenda";
            btnMenuCompraVenda.Size = new Size(217, 52);
            btnMenuCompraVenda.TabIndex = 3;
            btnMenuCompraVenda.Text = "Menu Compra  e Venda";
            btnMenuCompraVenda.UseVisualStyleBackColor = false;
            btnMenuCompraVenda.Click += button2_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.InactiveCaptionText;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.Control;
            btnSair.Location = new Point(406, 609);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(225, 41);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // Inicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 748);
            Controls.Add(btnSair);
            Controls.Add(btnMenuCompraVenda);
            Controls.Add(btnMenuCliente);
            Controls.Add(MenuCarro);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inicial";
            Text = "Inicial";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button MenuCarro;
        private PictureBox pictureBox1;
        private Button btnMenuCliente;
        private Button btnMenuCompraVenda;
        private Button btnSair;
    }
}