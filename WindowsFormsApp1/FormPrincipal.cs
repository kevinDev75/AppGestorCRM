﻿using RJCodeUI_M1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : RJCodeUI_M1.RJForms.RJMainForm
    {
       
        public FormPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
//            InitializeItems();

        }

        public FormPrincipal(User user)
        {
            InitializeComponent();
           // InitializeItems();
            //
            //userConnected = user;
            //lblUserName.Text = user.FirstName + " " + user.LastName;
            //pbProfilePicture.Image = user.ProfilePicture;

        }

        private void rjMenuButton1_Click(object sender, EventArgs e)
        {

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormProducts());
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormProductRegister());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormClientes());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormPedidoRegister());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormPedido());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormSubcripciones());
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormColeccion());
        }
    }
}
