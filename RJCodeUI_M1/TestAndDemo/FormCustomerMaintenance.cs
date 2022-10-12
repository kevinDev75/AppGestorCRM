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
    public partial class FormCustomerMaintenance : RJForms.RJChildForm
    {
        public FormCustomerMaintenance()
        {
            InitializeComponent();
            lblTitle.Text = "Agregar nuevo cliente";
            btnSave.Text = "Agregar";
            btnSave.BackColor = Settings.RJColors.Confirm;
        }

        public FormCustomerMaintenance(Customer customer)
        {
            InitializeComponent();
            lblTitle.Select();//No enfocar en los cuadros de texto al iniciar el formulario.
            lblTitle.Text = "Editar cliente";
            btnSave.Text = "Guardar";
            btnSave.BackColor = Settings.UIAppearance.StyleColor;

            txtNames.Text = customer.Names;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.PhoneNumber;
            txtAddress.Text = customer.StreetAddres;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
