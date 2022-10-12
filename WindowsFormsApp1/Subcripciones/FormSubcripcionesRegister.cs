using AppKST.Models.ProductModule;
using AppKST.Service.ProductModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Subcripciones
{

    public partial class FormSubcripcionesRegister : RJCodeUI_M1.RJForms.RJChildForm
    {
        private void ocultarAnulado()
        {
            txtMotivoSalida.Visible = false;
            rjfechasalida.Visible = false;
            lblfechasalida.Visible = false;
            lblMotivoSalida.Visible = false;
        }
        ProductService serviceAgent = new ProductService();
        public FormSubcripcionesRegister()
        {
            InitializeComponent();
            GetEditorial();
            ocultarAnulado();
        }

        private void GetEditorial()
        {
            List<EditorialDTO> _objListEditorial = new List<EditorialDTO>();

            _objListEditorial = serviceAgent.GetEditorial();
            cboEditorial.DisplayMember = "descEditorial";
            cboEditorial.ValueMember = "idEditorial";
            cboEditorial.DataSource = _objListEditorial;

        }

        private void rjButton25_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
