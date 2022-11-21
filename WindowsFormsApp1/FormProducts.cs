using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppKST.Models.ProductModule;
using AppKST.Service.ProductModule;
using RJCodeUI_M1;
using RJCodeUI_M1.Models;

namespace WindowsFormsApp1
{
    public partial class FormProducts : RJCodeUI_M1.RJForms.RJChildForm
    {
        ProductService serviceAgent = new ProductService();
        List<ProductoDetailDTO> listserach = new List<ProductoDetailDTO>();
        public FormProducts()
        {
            InitializeComponent();
           
            this.GetDemografia();
            this.GetEditorial();
           // rjDgvListProduct.DataSource = new Product().GetProductsList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frmProduct = new FormProductRegister();
            if (frmProduct.ShowDialog() == DialogResult.OK)
            {
                this.Search();
            }

        }
        private void GetDemografia()
        {
            List<DemografiaDTO> _objListDemografia = new List<DemografiaDTO>();
            
            _objListDemografia = serviceAgent.GetDemografia();
            _objListDemografia.Add(new DemografiaDTO() { descDemografia = "TODOS", idDemografia = 0 });
            _objListDemografia.Reverse();
            cboDemografia.DisplayMember = "descDemografia";
            cboDemografia.ValueMember = "idDemografia";
            cboDemografia.DataSource = _objListDemografia;
           
        }
        private void GetEditorial()
        {
            List<EditorialDTO> _objListEditorial= new List<EditorialDTO>();

            _objListEditorial = serviceAgent.GetEditorial();
            _objListEditorial.Add(new EditorialDTO() { descEditorial = "TODOS", idEditorial = 0 });
            _objListEditorial.Reverse();
            cboEditorial.DisplayMember = "descEditorial";
            cboEditorial.ValueMember = "idEditorial";
            cboEditorial.DataSource = _objListEditorial;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int indice =Convert.ToInt32(rjDgvListProduct.CurrentRow?.Index.ToString());
           int id= Convert.ToInt32(rjDgvListProduct.Rows[indice].Cells[0].Value);
            //var product = new Product().GetProductsList().FirstOrDefault(t=>t.Id==id);

           var frmProduct = new FormProductRegister(id,true);
            
            if(frmProduct.ShowDialog() == DialogResult.OK)
            {
                this.Search();
            }
             
        }

        private void Search()
        {
            
            SearchProductDTO dtoSearch = new SearchProductDTO();
            dtoSearch.texto = txtbuscar.Text;
            dtoSearch.demografia = (cboDemografia.SelectedValue?.ToString() != "0" && cboDemografia.SelectedValue?.ToString() != null ? cboDemografia.SelectedValue.ToString() : string.Empty);
            dtoSearch.editorial= (cboEditorial.SelectedValue?.ToString() != "0" && cboDemografia.SelectedValue?.ToString() != null ? cboEditorial.SelectedValue.ToString() : string.Empty);
             listserach = serviceAgent.SearchProduct(dtoSearch);
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
            rjDgvListProduct.Columns["id_prod"].Visible = true;
            rjDgvListProduct.Columns["id_prod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["isbn"].Visible = true;
            rjDgvListProduct.Columns["isbn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            rjDgvListProduct.Columns["precio"].Visible = true;
            rjDgvListProduct.Columns["titulo"].Visible = true;
            rjDgvListProduct.Columns["titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            rjDgvListProduct.Columns["tipo"].Visible = true;
            rjDgvListProduct.Columns["resenia"].Visible = true;
            rjDgvListProduct.Columns["rutaImg"].Visible = true;

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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            int indice = Convert.ToInt32(rjDgvListProduct.CurrentRow?.Index.ToString());
            string id = rjDgvListProduct.Rows[indice].Cells[0].Value.ToString();
            ProductoDTO obj = new ProductoDTO();
            obj.id_prod = id;
            serviceAgent.DeleteProduct(obj);
            this.Search();
            var rptok = RJMessageBox.Show("Se Eliminó Correctamente!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
