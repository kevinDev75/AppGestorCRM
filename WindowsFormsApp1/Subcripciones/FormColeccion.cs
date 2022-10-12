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
    public partial class FormColeccion : RJCodeUI_M1.RJForms.RJChildForm
    {
        ProductService serviceAgent = new ProductService();
        public FormColeccion()
        {
            InitializeComponent();
           // rjDgvListProduct.DataSource = new Product().GetProductsList();
        }
       
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frmProduct = new FormProductRegister();
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


            ColeccionDTO dto = new ColeccionDTO();
            dto.descripcion = txtnombre.Text.ToUpper();

            List<ColeccionDTO> listserach = serviceAgent.getColeccionSearch(dto);

            if(listserach.Count > 0)
            {           
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

        String[] listColumns = new String[] { "idColeccion", "descColeccion", "flgTerminado", "descripcion" , "CantTomos" };
            foreach(String item in listColumns)
            {
                AddColumn(item);
            }
        }

        private void AddColumn(string column)
        {
            rjDgvListProduct.Columns[column].Visible = true;
            rjDgvListProduct.Columns[column].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
