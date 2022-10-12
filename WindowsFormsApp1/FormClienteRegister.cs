using AppKST.Models;
using AppKST.Models.ClientModule;
using AppKST.Models.ProductModule;
using AppKST.Service;
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

  
    public partial class FormClienteRegister : RJCodeUI_M1.RJForms.RJChildForm
    {
        public int indEdit = 0;
        public int idClient = 0;
        ClientService serviceAgent = new ClientService();
        public FormClienteRegister()
        {
            InitializeComponent();
            GetTipoDocumento();
            GetDepartamento();
            ControlsDispose(true);
        }
        public FormClienteRegister(int idcl,string id,bool isEdit)
        {
            InitializeComponent();
            GetTipoDocumento();
            GetDepartamento();
            idClient = idcl;
            if (id != string.Empty)
            {
                indEdit = isEdit ? 1 : 0;
                LlenarCampos(id);
                ControlsDispose(false);
            }

        }
        private void ControlsDispose(bool isEnabled)
        {
            txtCodigo.Enabled = isEnabled;
            
        }
        private void LlenarCampos(string id)
        {

            try
            {
                SearchClienteDTO dt = new SearchClienteDTO();
                dt.codigo = id;
                List<ClienteDTO> dto = serviceAgent.SearchCliente(dt);
                if (dto != null && dto.Count > 0)
                {
                    
                    txtCodigo.Text = id.ToString();
                    txtNombre.Text = dto[0].nombres.Trim();
                    txtApeMaterno.Text = dto[0].ape_mat;
                    txtApePate.Text = dto[0].ape_pat;
                    cboTipoDoc.SelectedValue = dto[0].idTipoDocumento;
                    txtnumdocumento.Text = dto[0].nroDocumento.ToString();
                    txtcelular.Text = dto[0].celular.ToString();
                    cboDepartamento.SelectedValue = dto[0].idDepartamento;
                    getProvincia(dto[0].idDepartamento);
                    cboProvincia.SelectedValue = dto[0].idProvincia;
                    getDistrito(dto[0].idProvincia);
                    cboDistrito.SelectedValue = dto[0].ubigeo;
                    //txtcondicion.Text = dto[0].condicion.ToString();
                    chkestado.Checked =(dto[0].condicion.ToString() == "1" ? true : false);
                    txtfijo.Text  = dto[0].fijo.ToString();
                    txtcorreo.Text = dto[0].correo;
                    txtclientecol.Text = dto[0].clienteCol.ToString();
                }
            }catch(Exception ex)
            {
                RJMessageBox.Show("Ocurrio un error al obtener la información","Cargar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       
        private void GetDepartamento()
        {
            List<DepartamentoDTO> _objList = new List<DepartamentoDTO>();

            _objList = serviceAgent.getDepartamento();
            cboDepartamento.DisplayMember = "descDepa";
            cboDepartamento.ValueMember = "idDepa";
            cboDepartamento.DataSource = _objList;

        }
        private void getProvincia(int idDep)
        {
            List<ProvinciaDTO> _objList = new List<ProvinciaDTO>();

            _objList = serviceAgent.getProvincia(idDep);
            cboProvincia.DisplayMember = "provincia";
            cboProvincia.ValueMember = "idProv";
            cboProvincia.DataSource = _objList;

        }
        private void getDistrito(int idProv)
        {
            List<DistritoDTO> _objList = new List<DistritoDTO>();

            _objList = serviceAgent.getDistrito(idProv);
            cboDistrito.DisplayMember = "distrito";
            cboDistrito.ValueMember = "idDist";
            cboDistrito.DataSource = _objList;

        }
        private void GetTipoDocumento()
        {
            List<TipoDocumentoDTO> _objList = new List<TipoDocumentoDTO>();
            _objList = serviceAgent.GetTipoDocumento();
            cboTipoDoc.DisplayMember = "descripcion";
            cboTipoDoc.ValueMember = "idTipoDocumento";
            cboTipoDoc.DataSource = _objList;
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
                    ClienteDTO dto = new ClienteDTO();
                    dto.codigo = txtCodigo.Text.Trim();
                    dto.idTipoDocumento = Int32.Parse(cboTipoDoc.SelectedValue.ToString());
                    dto.nroDocumento = txtnumdocumento.Text;
                    dto.nombres = txtNombre.Text;
                    dto.ape_mat = txtApeMaterno.Text;
                    dto.ape_pat= txtApePate.Text;
                    dto.celular = Int32.Parse(txtcelular.Text);
                    dto.idDepartamento = Int32.Parse(cboDepartamento.SelectedValue.ToString());
                    dto.idProvincia = Int32.Parse(cboProvincia.SelectedValue.ToString());
                    dto.ubigeo= Int32.Parse(cboDistrito.SelectedValue.ToString());
                    dto.condicion = (chkestado.Checked ? 1 : 0);
                    dto.fijo = Int32.Parse(txtfijo.Text);
                    dto.correo = txtcorreo.Text;
                    dto.clienteCol = txtclientecol.Text;


                    ApiResponseDTO response = new ApiResponseDTO();
                    if (indEdit == 1)
                    {
                        dto.idCliente = idClient;
                        response = serviceAgent.UpdateClient(dto);
                    }
                    else 
                    {
                        response = serviceAgent.InsertClient(dto);
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

        private void cboDepartamento_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedValue != null)
            {
                getProvincia(Int32.Parse(cboDepartamento.SelectedValue.ToString()));
            }
             
        }

        private void cboProvincia_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboProvincia.SelectedValue != null)
            {
                getDistrito(Int32.Parse(cboProvincia.SelectedValue.ToString()));
            }
            
        }
    }
}
