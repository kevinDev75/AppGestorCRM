using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RJCodeUI_M1.Models;

namespace RJCodeUI_M1.TestAndDemo
{
    public partial class FormProductMaintenance : RJForms.RJChildForm
    {
        public FormProductMaintenance()
        {
            InitializeComponent();
            lblTitle.Text = "Agregar nuevo producto";
            btnSave.Text = "Agregar";
            btnSave.BackColor = Settings.RJColors.Confirm;
            
        }

        public FormProductMaintenance(Product product)
        {
            InitializeComponent();
            lblTitle.Text = "Editar producto";
            btnSave.Text = "Guardar";
            btnSave.BackColor = Settings.UIAppearance.StyleColor; 
            txtID.Text = product.Id.ToString();
            txtProduct.Text = product.Item;
            txtStock.Text = product.Stock.ToString();
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtID.Enabled = false;//Bloquear campo
            lblTitle.Select();//No enfocar un cuadro de texto al iniciar el formulario.
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
