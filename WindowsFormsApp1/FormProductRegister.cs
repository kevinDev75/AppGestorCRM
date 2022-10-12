using AppKST.Models;
using AppKST.Models.ProductModule;
using AppKST.Service.ProductModule;
using RJCodeUI_M1;
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

  
    public partial class FormProductRegister : RJCodeUI_M1.RJForms.RJChildForm
    {
        public int indEdit = 0;
        ProductService serviceAgent = new ProductService();
        public FormProductRegister()
        {
            InitializeComponent();
            GetEditorial();
            GetFormato();
            GetColeccion();
        }
        public FormProductRegister(int id,bool isEdit)
        {
            InitializeComponent();
            GetEditorial();
            GetFormato();
            GetColeccion();
            if(id > 0)
            {
                indEdit = isEdit ? 1 : 0;
                LlenarCampos(id);
                ControlsDispose(isEdit);
            }

        }
        private void ControlsDispose(bool isEnabled)
        {
            btnAddPhoto.Enabled = isEnabled;
            txttitulo.Enabled = isEnabled;
            txtisbn.Enabled = isEnabled;
            txtprecio.Enabled = isEnabled;
            dpklanzamiento.Enabled = isEnabled;
            txtpaginas.Enabled = isEnabled;
            txttamanio.Enabled = isEnabled;
            cboEditorial.Enabled = isEnabled;
            cboformato.Enabled = isEnabled;
            cboColeccion.Enabled = isEnabled;
            txtvaloracion.Enabled = isEnabled;
            chkestado.Enabled = isEnabled;
            txtresenia.Enabled = isEnabled;
            btnSave.Enabled = isEnabled;
        }
        private void LlenarCampos(int id)
        {

            try
            {
                ProductoDetailDTO dto = serviceAgent.getProductxID(id);
                if (dto != null)
                {
                    txtidproduct.Text = id.ToString();
                    txttitulo.Text = dto.titulo.Trim();
                    txtisbn.Text = dto.isbn;
                    txtprecio.Text = dto.precio.ToString();
                    dpklanzamiento.Value = Convert.ToDateTime(dto.fch_lanzamiento.ToString());
                    txtpaginas.Text = dto.paginas;
                    txttamanio.Text = dto.tamanio;
                    cboEditorial.SelectedValue = dto.editorial.idEditorial;
                    cboformato.SelectedValue = dto.formato.idFormato;
                    cboColeccion.SelectedValue = dto.coleccion.idColeccion;
                    txtvaloracion.Text = dto.valoracion.ToString();
                    chkestado.Checked = (dto.estado == "1" ? true : false);
                    txtresenia.Text = dto.resenia;
                }
            }catch(Exception ex)
            {
                RJMessageBox.Show("Ocurrio un error al obtener la información","Cargar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void GetColeccion()
        {
            List<ColeccionDTO> _objListFormato = new List<ColeccionDTO>();

            _objListFormato = serviceAgent.GetColeccion();
            cboColeccion.DisplayMember = "descColeccion";
            cboColeccion.ValueMember = "idColeccion";
            cboColeccion.DataSource = _objListFormato;

        }
        private void GetFormato()
        {
            List<FormatoDTO> _objListFormato = new List<FormatoDTO>();

            _objListFormato = serviceAgent.GetFormato();
            cboformato.DisplayMember = "DescFormato";
            cboformato.ValueMember = "idFormato";
            cboformato.DataSource = _objListFormato;

        }
        private void GetEditorial()
        {
            List<EditorialDTO> _objListEditorial = new List<EditorialDTO>();

            _objListEditorial = serviceAgent.GetEditorial();
            cboEditorial.DisplayMember = "descEditorial";
            cboEditorial.ValueMember = "idEditorial";
            cboEditorial.DataSource = _objListEditorial;

        }
        private void tbColorFormBorder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rjPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool validarRegistro() { return true; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validarRegistro())
            {
                var rpt = RJMessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (rpt == DialogResult.OK)
                {
                    ProductoDTO dto = new ProductoDTO();
                    dto.isbn = txtisbn.Text.Trim();
                    dto.precio = Decimal.Parse(txtprecio.Text.ToString());
                    dto.titulo = txttitulo.Text.ToString();
                    dto.paginas = txtpaginas.Text.Trim();
                    dto.tamanio = txttamanio.Text.Trim();
                    dto.resenia = txtresenia.Text.Trim();
                    dto.foto = "prueba.jpg";
                    dto.tipo = "pruebaa";
                    dto.id_editorial = Int32.Parse(cboEditorial.SelectedValue.ToString());
                    dto.estado = (chkestado.Checked ? "1" : "0");
                    dto.fch_lanzamiento = dpklanzamiento.Text.ToString();
                    dto.valoracion = Int32.Parse(txtvaloracion.Text.Trim());
                    dto.idformato = Int32.Parse(cboformato.SelectedValue.ToString());
                    dto.id_coleccion =  Int32.Parse(cboColeccion.SelectedValue.ToString());

                    ApiResponseDTO response = new ApiResponseDTO();
                    if (indEdit == 1)
                    {
                        dto.id_prod = txtidproduct.Text;
                        response = serviceAgent.UpdateProduct(dto);
                    }
                    else 
                    {
                        response = serviceAgent.RegisterProduct(dto);
                    }

                    if(response.pcode == 0)
                    {
                        var rptok = RJMessageBox.Show("Se " + (indEdit == 0 ? "registro" : "actualizo" )  +" Correctamente!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(rptok == DialogResult.OK){
                            this.Close();
                        }
                    }
                    else 
                    {
                        RJMessageBox.Show(response.pmessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }
            }    
        }

        private void rjButton25_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = openFileDialog1.FileName;
                    pbPhoto.ImageLocation = sr;
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            pbPhoto.ImageLocation = "";
        }
    }
}
