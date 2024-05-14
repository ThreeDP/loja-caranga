﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carshop
{
    public partial class Inicial : Form
    {
        Thread aux;
        public Inicial()
        {
            InitializeComponent();
        }

        private void abrirCadastro(object obj)
        {
            Application.Run(new CadastroDeCarro());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            aux = new Thread(abrirCadastro);
            aux.TrySetApartmentState(ApartmentState.STA);
            aux.Start();
        }
    }
}
