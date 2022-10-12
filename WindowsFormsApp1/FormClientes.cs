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

namespace WindowsFormsApp1
{
    public partial class FormClientes : RJCodeUI_M1.RJForms.RJChildForm
    {
        ClientService serviceAgent = new ClientService();
        public FormClientes()
        {
            InitializeComponent();
            
            GetTipoDocumento();
           // rjDgvListProduct.DataSource = new Product().GetProductsList();
        }
        private void GetTipoDocumento()
        {
            List<TipoDocumentoDTO> objList = new List<TipoDocumentoDTO>();

            objList = serviceAgent.GetTipoDocumento();
            objList.Add(new TipoDocumentoDTO() { descripcion = "TODOS", idTipoDocumento   = 0 });
            objList.Reverse();
            cboTipoDocumento.DisplayMember = "descripcion";
            cboTipoDocumento.ValueMember = "idTipoDocumento";
            cboTipoDocumento.DataSource = objList;

        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frmCliente = new FormClienteRegister();
            frmCliente.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = rjDgvListProduct.CurrentRow.Cells[0].Value.ToString();
            string cod = rjDgvListProduct.CurrentRow.Cells[1].Value.ToString();
            //var product = new Product().GetProductsList().FirstOrDefault(t=>t.Id==id);

            var frmProduct = new FormClienteRegister(int.Parse(id), cod,true);
            frmProduct.ShowDialog();
        }

        private void Search()
        {

            SearchClienteDTO dtoSearch = new SearchClienteDTO();
            dtoSearch.nombre = txtnombre.Text;
            dtoSearch.nrodocumento = txtnroDocumento.Text;
            dtoSearch.idTipoDocumento = (cboTipoDocumento.SelectedValue.ToString() != "0" ? Int32.Parse(cboTipoDocumento.SelectedValue.ToString()) : 0);
            dtoSearch.codigo = txtcodigo.Text.ToUpper();
            //dtoSearch.editorial= (cboEditorial.SelectedValue.ToString() != "0" ? cboEditorial.SelectedValue.ToString() : string.Empty);
            List<ClienteDTO> listserach = serviceAgent.SearchCliente(dtoSearch);
            if(listserach.Count > 0)
            {
                //var bindingList = new BindingList<ProductoDetailDTO>(listserach);
                //var source = new BindingSource(bindingList, null);
                
                rjDgvListProduct.DataSource = listserach;
                this.ShowColumns();
            }
            else
            {
                RJMessageBox.Show("No se encontraron resultados", "Message", MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);
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
            rjDgvListProduct.Columns["idCliente"].Visible = true;
            rjDgvListProduct.Columns["idCliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["codigo"].Visible = true;
            rjDgvListProduct.Columns["codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["nombres"].Visible = true;
            rjDgvListProduct.Columns["nombres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["ape_pat"].Visible = true;
            rjDgvListProduct.Columns["ape_pat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["ape_mat"].Visible = true;
            rjDgvListProduct.Columns["ape_mat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["nroDocumento"].Visible = true;
            rjDgvListProduct.Columns["nroDocumento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["celular"].Visible = true;
            rjDgvListProduct.Columns["correo"].Visible = true;
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
