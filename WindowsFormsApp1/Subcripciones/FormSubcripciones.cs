using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppKST.Models.ClientModule;
using AppKST.Models.ProductModule;
using AppKST.Service;
using AppKST.Service.ProductModule;
using RJCodeUI_M1;
using RJCodeUI_M1.Models;
using WindowsFormsApp1.Subcripciones;

namespace WindowsFormsApp1
{
    public partial class FormSubcripciones : RJCodeUI_M1.RJForms.RJChildForm
    {
        ClientService serviceAgent = new ClientService();
        public FormSubcripciones()
        {
            InitializeComponent();
            
           
           // rjDgvListProduct.DataSource = new Product().GetProductsList();
        }
       
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frmProduct = new FormSubcripcionesRegister();
            frmProduct.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = rjDgvListProduct.CurrentRow.Cells[0].Value.ToString();
            //var product = new Product().GetProductsList().FirstOrDefault(t=>t.Id==id);

           var frmProduct = new FormProductRegister(int.Parse(id),true);
            frmProduct.ShowDialog();
        }

        private void Search()
        {

            SearchClienteSubcripcionesDTO dtoSearch = new SearchClienteSubcripcionesDTO();
            dtoSearch.codigo = txtcodigo.Text.ToUpper();
            

            List<ClienteSubcripcionesDTO> listserach = serviceAgent.getSubcripciones(dtoSearch);

            if(listserach.Count > 0)
            {
                //var bindingList = new BindingList<ProductoDetailDTO>(listserach);
                //var source = new BindingSource(bindingList, null);
            
                foreach(ClienteSubcripcionesDTO dt in listserach)
                {
                    dt.codigo = txtcodigo.Text;
                    dt.nombre = dt.cliente.nombres;
                    dt.apellido_Materno = dt.cliente.ape_mat;
                    dt.apellido_Paterno = dt.cliente.ape_pat;
                    dt.desccoleccion = dt.Coleccion.descColeccion;
                    dt.descEditorial = dt.editorial.descEditorial;
                }
                rjDgvListProduct.DataSource = listserach;
                this.ShowColumns();
            }
            else
            {
                RJMessageBox.Show("No se encontraron subcripciones para este cliente", "Message", MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);
                rjDgvListProduct.DataSource = null;
            }

            
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Search();

        }
        private void ShowColumns()
        {
            for(var i  = 0 ; i< rjDgvListProduct.ColumnCount; i++)
            {
                rjDgvListProduct.Columns[i].Visible = false;
            }
            rjDgvListProduct.Columns["codigo"].Visible = true;
            rjDgvListProduct.Columns["codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            rjDgvListProduct.Columns["nombre"].Visible = true;
            rjDgvListProduct.Columns["nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            rjDgvListProduct.Columns["apellido_Materno"].Visible = true;
            rjDgvListProduct.Columns["apellido_Materno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            rjDgvListProduct.Columns["apellido_Paterno"].Visible = true;
            rjDgvListProduct.Columns["apellido_Paterno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            rjDgvListProduct.Columns["desccoleccion"].Visible = true;
            rjDgvListProduct.Columns["desccoleccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            rjDgvListProduct.Columns["descEditorial"].Visible = true;
            rjDgvListProduct.Columns["descEditorial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            rjDgvListProduct.Columns["fecha_subcripcion"].Visible = true;
            rjDgvListProduct.Columns["fecha_subcripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["fecha_salida"].Visible = true;
            rjDgvListProduct.Columns["fecha_salida"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["flg_estado"].Visible = true;
            rjDgvListProduct.Columns["flg_estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["motivo"].Visible = true;
            rjDgvListProduct.Columns["motivo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["motivo"].Visible = true;
            rjDgvListProduct.Columns["motivo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void txtbuscar_onTextChanged(object sender, EventArgs e)
        {

                
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Search();
            }
        }

        private void rjDgvListProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void cboDemografia_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
