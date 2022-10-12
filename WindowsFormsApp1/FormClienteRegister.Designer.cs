namespace WindowsFormsApp1
{
    partial class FormClienteRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkestado = new RJCodeUI_M1.RJControls.RJToggleButton();
            this.rjLabel15 = new RJCodeUI_M1.RJControls.RJLabel();
            this.rjPanel7 = new RJCodeUI_M1.RJControls.RJPanel();
            this.txtclientecol = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel2 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtnumdocumento = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel1 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtcorreo = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel20 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtfijo = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel19 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtcelular = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel18 = new RJCodeUI_M1.RJControls.RJLabel();
            this.cboDistrito = new RJCodeUI_M1.RJControls.RJComboBox();
            this.rjLabel17 = new RJCodeUI_M1.RJControls.RJLabel();
            this.cboProvincia = new RJCodeUI_M1.RJControls.RJComboBox();
            this.rjLabel16 = new RJCodeUI_M1.RJControls.RJLabel();
            this.cboDepartamento = new RJCodeUI_M1.RJControls.RJComboBox();
            this.rjLabel14 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtApeMaterno = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel12 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtApePate = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel7 = new RJCodeUI_M1.RJControls.RJLabel();
            this.rjButton25 = new RJCodeUI_M1.RJControls.RJButton();
            this.txtcondicion = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel13 = new RJCodeUI_M1.RJControls.RJLabel();
            this.btnSave = new RJCodeUI_M1.RJControls.RJButton();
            this.txtCodigo = new RJCodeUI_M1.RJControls.RJTextBox();
            this.txtNombre = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel5 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtId = new RJCodeUI_M1.RJControls.RJLabel();
            this.cboTipoDoc = new RJCodeUI_M1.RJControls.RJComboBox();
            this.rjLabel3 = new RJCodeUI_M1.RJControls.RJLabel();
            this.pnlClientArea.SuspendLayout();
            this.rjPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClientArea
            // 
            this.pnlClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlClientArea.Controls.Add(this.rjPanel7);
            this.pnlClientArea.Location = new System.Drawing.Point(1, 41);
            this.pnlClientArea.Size = new System.Drawing.Size(908, 564);
            // 
            // chkestado
            // 
            this.chkestado.Activated = true;
            this.chkestado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkestado.Checked = true;
            this.chkestado.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkestado.Customizable = false;
            this.chkestado.FlatAppearance.BorderSize = 0;
            this.chkestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkestado.Location = new System.Drawing.Point(753, 344);
            this.chkestado.MinimumSize = new System.Drawing.Size(45, 20);
            this.chkestado.Name = "chkestado";
            this.chkestado.OFF_BackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.chkestado.OFF_Text = "Off";
            this.chkestado.OFF_TextColor = System.Drawing.Color.Gray;
            this.chkestado.OFF_ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.chkestado.ON_BackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.chkestado.ON_Text = "On";
            this.chkestado.ON_TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.chkestado.ON_ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.chkestado.Size = new System.Drawing.Size(50, 23);
            this.chkestado.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.chkestado.TabIndex = 11;
            this.chkestado.Text = "#";
            this.chkestado.UseVisualStyleBackColor = false;
            this.chkestado.CheckedChanged += new System.EventHandler(this.tbColorFormBorder_CheckedChanged);
            // 
            // rjLabel15
            // 
            this.rjLabel15.AutoSize = true;
            this.rjLabel15.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel15.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel15.LinkLabel = false;
            this.rjLabel15.Location = new System.Drawing.Point(683, 347);
            this.rjLabel15.Name = "rjLabel15";
            this.rjLabel15.Size = new System.Drawing.Size(64, 16);
            this.rjLabel15.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel15.TabIndex = 57;
            this.rjLabel15.Text = "Estado :";
            // 
            // rjPanel7
            // 
            this.rjPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjPanel7.BorderRadius = 5;
            this.rjPanel7.Controls.Add(this.txtclientecol);
            this.rjPanel7.Controls.Add(this.rjLabel2);
            this.rjPanel7.Controls.Add(this.txtnumdocumento);
            this.rjPanel7.Controls.Add(this.rjLabel1);
            this.rjPanel7.Controls.Add(this.txtcorreo);
            this.rjPanel7.Controls.Add(this.rjLabel20);
            this.rjPanel7.Controls.Add(this.txtfijo);
            this.rjPanel7.Controls.Add(this.rjLabel19);
            this.rjPanel7.Controls.Add(this.txtcelular);
            this.rjPanel7.Controls.Add(this.rjLabel18);
            this.rjPanel7.Controls.Add(this.cboDistrito);
            this.rjPanel7.Controls.Add(this.rjLabel17);
            this.rjPanel7.Controls.Add(this.cboProvincia);
            this.rjPanel7.Controls.Add(this.rjLabel16);
            this.rjPanel7.Controls.Add(this.cboDepartamento);
            this.rjPanel7.Controls.Add(this.rjLabel14);
            this.rjPanel7.Controls.Add(this.txtApeMaterno);
            this.rjPanel7.Controls.Add(this.rjLabel12);
            this.rjPanel7.Controls.Add(this.txtApePate);
            this.rjPanel7.Controls.Add(this.rjLabel7);
            this.rjPanel7.Controls.Add(this.rjButton25);
            this.rjPanel7.Controls.Add(this.txtcondicion);
            this.rjPanel7.Controls.Add(this.rjLabel13);
            this.rjPanel7.Controls.Add(this.btnSave);
            this.rjPanel7.Controls.Add(this.txtCodigo);
            this.rjPanel7.Controls.Add(this.txtNombre);
            this.rjPanel7.Controls.Add(this.rjLabel5);
            this.rjPanel7.Controls.Add(this.txtId);
            this.rjPanel7.Controls.Add(this.cboTipoDoc);
            this.rjPanel7.Controls.Add(this.chkestado);
            this.rjPanel7.Controls.Add(this.rjLabel15);
            this.rjPanel7.Controls.Add(this.rjLabel3);
            this.rjPanel7.Customizable = false;
            this.rjPanel7.Location = new System.Drawing.Point(14, 16);
            this.rjPanel7.Name = "rjPanel7";
            this.rjPanel7.Size = new System.Drawing.Size(876, 525);
            this.rjPanel7.TabIndex = 58;
            this.rjPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel7_Paint);
            // 
            // txtclientecol
            // 
            this.txtclientecol._Customizable = false;
            this.txtclientecol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtclientecol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtclientecol.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtclientecol.BorderRadius = 7;
            this.txtclientecol.BorderSize = 1;
            this.txtclientecol.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtclientecol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtclientecol.Location = new System.Drawing.Point(604, 265);
            this.txtclientecol.MultiLine = false;
            this.txtclientecol.Name = "txtclientecol";
            this.txtclientecol.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtclientecol.PasswordChar = false;
            this.txtclientecol.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtclientecol.PlaceHolderText = null;
            this.txtclientecol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtclientecol.Size = new System.Drawing.Size(133, 31);
            this.txtclientecol.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtclientecol.TabIndex = 115;
            // 
            // rjLabel2
            // 
            this.rjLabel2.AutoSize = true;
            this.rjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel2.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel2.LinkLabel = false;
            this.rjLabel2.Location = new System.Drawing.Point(605, 235);
            this.rjLabel2.Name = "rjLabel2";
            this.rjLabel2.Size = new System.Drawing.Size(89, 16);
            this.rjLabel2.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel2.TabIndex = 114;
            this.rjLabel2.Text = "Cliente Col :";
            // 
            // txtnumdocumento
            // 
            this.txtnumdocumento._Customizable = false;
            this.txtnumdocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtnumdocumento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtnumdocumento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtnumdocumento.BorderRadius = 7;
            this.txtnumdocumento.BorderSize = 1;
            this.txtnumdocumento.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtnumdocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtnumdocumento.Location = new System.Drawing.Point(296, 42);
            this.txtnumdocumento.MultiLine = false;
            this.txtnumdocumento.Name = "txtnumdocumento";
            this.txtnumdocumento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnumdocumento.PasswordChar = false;
            this.txtnumdocumento.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtnumdocumento.PlaceHolderText = null;
            this.txtnumdocumento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnumdocumento.Size = new System.Drawing.Size(192, 31);
            this.txtnumdocumento.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtnumdocumento.TabIndex = 113;
            // 
            // rjLabel1
            // 
            this.rjLabel1.AutoSize = true;
            this.rjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel1.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel1.LinkLabel = false;
            this.rjLabel1.Location = new System.Drawing.Point(296, 23);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(119, 16);
            this.rjLabel1.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel1.TabIndex = 112;
            this.rjLabel1.Text = "N° Documento : ";
            // 
            // txtcorreo
            // 
            this.txtcorreo._Customizable = false;
            this.txtcorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtcorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtcorreo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtcorreo.BorderRadius = 7;
            this.txtcorreo.BorderSize = 1;
            this.txtcorreo.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtcorreo.Location = new System.Drawing.Point(177, 265);
            this.txtcorreo.MultiLine = false;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtcorreo.PasswordChar = false;
            this.txtcorreo.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtcorreo.PlaceHolderText = null;
            this.txtcorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcorreo.Size = new System.Drawing.Size(380, 31);
            this.txtcorreo.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtcorreo.TabIndex = 111;
            // 
            // rjLabel20
            // 
            this.rjLabel20.AutoSize = true;
            this.rjLabel20.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel20.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel20.LinkLabel = false;
            this.rjLabel20.Location = new System.Drawing.Point(185, 235);
            this.rjLabel20.Name = "rjLabel20";
            this.rjLabel20.Size = new System.Drawing.Size(67, 16);
            this.rjLabel20.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel20.TabIndex = 110;
            this.rjLabel20.Text = "Correo : ";
            // 
            // txtfijo
            // 
            this.txtfijo._Customizable = false;
            this.txtfijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtfijo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtfijo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtfijo.BorderRadius = 7;
            this.txtfijo.BorderSize = 1;
            this.txtfijo.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtfijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtfijo.Location = new System.Drawing.Point(25, 265);
            this.txtfijo.MultiLine = false;
            this.txtfijo.Name = "txtfijo";
            this.txtfijo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtfijo.PasswordChar = false;
            this.txtfijo.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtfijo.PlaceHolderText = null;
            this.txtfijo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfijo.Size = new System.Drawing.Size(133, 31);
            this.txtfijo.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtfijo.TabIndex = 109;
            // 
            // rjLabel19
            // 
            this.rjLabel19.AutoSize = true;
            this.rjLabel19.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel19.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel19.LinkLabel = false;
            this.rjLabel19.Location = new System.Drawing.Point(26, 235);
            this.rjLabel19.Name = "rjLabel19";
            this.rjLabel19.Size = new System.Drawing.Size(42, 16);
            this.rjLabel19.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel19.TabIndex = 108;
            this.rjLabel19.Text = "Fijo :";
            // 
            // txtcelular
            // 
            this.txtcelular._Customizable = false;
            this.txtcelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtcelular.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtcelular.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtcelular.BorderRadius = 7;
            this.txtcelular.BorderSize = 1;
            this.txtcelular.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtcelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtcelular.Location = new System.Drawing.Point(604, 123);
            this.txtcelular.MultiLine = false;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtcelular.PasswordChar = false;
            this.txtcelular.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtcelular.PlaceHolderText = null;
            this.txtcelular.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcelular.Size = new System.Drawing.Size(166, 31);
            this.txtcelular.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtcelular.TabIndex = 107;
            // 
            // rjLabel18
            // 
            this.rjLabel18.AutoSize = true;
            this.rjLabel18.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel18.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel18.LinkLabel = false;
            this.rjLabel18.Location = new System.Drawing.Point(601, 104);
            this.rjLabel18.Name = "rjLabel18";
            this.rjLabel18.Size = new System.Drawing.Size(63, 16);
            this.rjLabel18.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel18.TabIndex = 106;
            this.rjLabel18.Text = "Celular :";
            // 
            // cboDistrito
            // 
            this.cboDistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboDistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cboDistrito.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboDistrito.BorderRadius = 0;
            this.cboDistrito.BorderSize = 1;
            this.cboDistrito.Customizable = false;
            this.cboDistrito.DataSource = null;
            this.cboDistrito.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboDistrito.DropDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboDistrito.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.cboDistrito.Location = new System.Drawing.Point(403, 186);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Padding = new System.Windows.Forms.Padding(1);
            this.cboDistrito.SelectedIndex = -1;
            this.cboDistrito.SelectedValue = null;
            this.cboDistrito.Size = new System.Drawing.Size(169, 32);
            this.cboDistrito.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.cboDistrito.TabIndex = 105;
            this.cboDistrito.Texts = "";
            // 
            // rjLabel17
            // 
            this.rjLabel17.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel17.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel17.LinkLabel = false;
            this.rjLabel17.Location = new System.Drawing.Point(400, 167);
            this.rjLabel17.Name = "rjLabel17";
            this.rjLabel17.Size = new System.Drawing.Size(157, 16);
            this.rjLabel17.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel17.TabIndex = 104;
            this.rjLabel17.Text = "Distrito :";
            // 
            // cboProvincia
            // 
            this.cboProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cboProvincia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboProvincia.BorderRadius = 0;
            this.cboProvincia.BorderSize = 1;
            this.cboProvincia.Customizable = false;
            this.cboProvincia.DataSource = null;
            this.cboProvincia.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboProvincia.DropDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboProvincia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.cboProvincia.Location = new System.Drawing.Point(212, 186);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Padding = new System.Windows.Forms.Padding(1);
            this.cboProvincia.SelectedIndex = -1;
            this.cboProvincia.SelectedValue = null;
            this.cboProvincia.Size = new System.Drawing.Size(169, 32);
            this.cboProvincia.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.cboProvincia.TabIndex = 103;
            this.cboProvincia.Texts = "";
            this.cboProvincia.OnSelectedIndexChanged += new System.EventHandler(this.cboProvincia_OnSelectedIndexChanged);
            // 
            // rjLabel16
            // 
            this.rjLabel16.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel16.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel16.LinkLabel = false;
            this.rjLabel16.Location = new System.Drawing.Point(212, 167);
            this.rjLabel16.Name = "rjLabel16";
            this.rjLabel16.Size = new System.Drawing.Size(157, 16);
            this.rjLabel16.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel16.TabIndex = 102;
            this.rjLabel16.Text = "Provincia :";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cboDepartamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboDepartamento.BorderRadius = 0;
            this.cboDepartamento.BorderSize = 1;
            this.cboDepartamento.Customizable = false;
            this.cboDepartamento.DataSource = null;
            this.cboDepartamento.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboDepartamento.DropDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboDepartamento.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.cboDepartamento.Location = new System.Drawing.Point(29, 186);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Padding = new System.Windows.Forms.Padding(1);
            this.cboDepartamento.SelectedIndex = -1;
            this.cboDepartamento.SelectedValue = null;
            this.cboDepartamento.Size = new System.Drawing.Size(169, 32);
            this.cboDepartamento.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.cboDepartamento.TabIndex = 101;
            this.cboDepartamento.Texts = "";
            this.cboDepartamento.OnSelectedIndexChanged += new System.EventHandler(this.cboDepartamento_OnSelectedIndexChanged);
            // 
            // rjLabel14
            // 
            this.rjLabel14.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel14.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel14.LinkLabel = false;
            this.rjLabel14.Location = new System.Drawing.Point(26, 167);
            this.rjLabel14.Name = "rjLabel14";
            this.rjLabel14.Size = new System.Drawing.Size(157, 16);
            this.rjLabel14.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel14.TabIndex = 100;
            this.rjLabel14.Text = "Departamento :";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno._Customizable = false;
            this.txtApeMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtApeMaterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtApeMaterno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtApeMaterno.BorderRadius = 7;
            this.txtApeMaterno.BorderSize = 1;
            this.txtApeMaterno.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtApeMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtApeMaterno.Location = new System.Drawing.Point(403, 123);
            this.txtApeMaterno.MultiLine = false;
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApeMaterno.PasswordChar = false;
            this.txtApeMaterno.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtApeMaterno.PlaceHolderText = null;
            this.txtApeMaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApeMaterno.Size = new System.Drawing.Size(178, 31);
            this.txtApeMaterno.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtApeMaterno.TabIndex = 99;
            // 
            // rjLabel12
            // 
            this.rjLabel12.AutoSize = true;
            this.rjLabel12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel12.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel12.LinkLabel = false;
            this.rjLabel12.Location = new System.Drawing.Point(412, 104);
            this.rjLabel12.Name = "rjLabel12";
            this.rjLabel12.Size = new System.Drawing.Size(128, 16);
            this.rjLabel12.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel12.TabIndex = 98;
            this.rjLabel12.Text = "Apellido Materno :";
            // 
            // txtApePate
            // 
            this.txtApePate._Customizable = false;
            this.txtApePate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtApePate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtApePate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtApePate.BorderRadius = 7;
            this.txtApePate.BorderSize = 1;
            this.txtApePate.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtApePate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtApePate.Location = new System.Drawing.Point(212, 123);
            this.txtApePate.MultiLine = false;
            this.txtApePate.Name = "txtApePate";
            this.txtApePate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApePate.PasswordChar = false;
            this.txtApePate.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtApePate.PlaceHolderText = null;
            this.txtApePate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApePate.Size = new System.Drawing.Size(175, 31);
            this.txtApePate.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtApePate.TabIndex = 97;
            // 
            // rjLabel7
            // 
            this.rjLabel7.AutoSize = true;
            this.rjLabel7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel7.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel7.LinkLabel = false;
            this.rjLabel7.Location = new System.Drawing.Point(209, 104);
            this.rjLabel7.Name = "rjLabel7";
            this.rjLabel7.Size = new System.Drawing.Size(125, 16);
            this.rjLabel7.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel7.TabIndex = 96;
            this.rjLabel7.Text = "Apellido Paterno :";
            // 
            // rjButton25
            // 
            this.rjButton25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjButton25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.rjButton25.BorderRadius = 20;
            this.rjButton25.BorderSize = 2;
            this.rjButton25.Design = RJCodeUI_M1.RJControls.ButtonDesign.Cancel;
            this.rjButton25.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.rjButton25.FlatAppearance.BorderSize = 2;
            this.rjButton25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.rjButton25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.rjButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.rjButton25.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.rjButton25.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(110)))), ((int)(((byte)(134)))));
            this.rjButton25.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjButton25.IconSize = 24;
            this.rjButton25.Location = new System.Drawing.Point(341, 412);
            this.rjButton25.Name = "rjButton25";
            this.rjButton25.Size = new System.Drawing.Size(229, 40);
            this.rjButton25.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.rjButton25.TabIndex = 95;
            this.rjButton25.Text = "Cancelar";
            this.rjButton25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton25.UseVisualStyleBackColor = false;
            this.rjButton25.Click += new System.EventHandler(this.rjButton25_Click);
            // 
            // txtcondicion
            // 
            this.txtcondicion._Customizable = false;
            this.txtcondicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtcondicion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtcondicion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtcondicion.BorderRadius = 7;
            this.txtcondicion.BorderSize = 1;
            this.txtcondicion.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtcondicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtcondicion.Location = new System.Drawing.Point(604, 187);
            this.txtcondicion.MultiLine = false;
            this.txtcondicion.Name = "txtcondicion";
            this.txtcondicion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtcondicion.PasswordChar = false;
            this.txtcondicion.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtcondicion.PlaceHolderText = null;
            this.txtcondicion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcondicion.Size = new System.Drawing.Size(89, 31);
            this.txtcondicion.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtcondicion.TabIndex = 93;
            // 
            // rjLabel13
            // 
            this.rjLabel13.AutoSize = true;
            this.rjLabel13.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel13.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel13.LinkLabel = false;
            this.rjLabel13.Location = new System.Drawing.Point(601, 168);
            this.rjLabel13.Name = "rjLabel13";
            this.rjLabel13.Size = new System.Drawing.Size(82, 16);
            this.rjLabel13.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel13.TabIndex = 92;
            this.rjLabel13.Text = "Condición :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 1;
            this.btnSave.Design = RJCodeUI_M1.RJControls.ButtonDesign.IconButton;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 24;
            this.btnSave.Location = new System.Drawing.Point(576, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 40);
            this.btnSave.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo._Customizable = false;
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtCodigo.BorderRadius = 0;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtCodigo.Location = new System.Drawing.Point(29, 43);
            this.txtCodigo.MultiLine = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.PlaceHolderText = null;
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.Size = new System.Drawing.Size(91, 31);
            this.txtCodigo.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtCodigo.TabIndex = 74;
            // 
            // txtNombre
            // 
            this.txtNombre._Customizable = false;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtNombre.BorderRadius = 7;
            this.txtNombre.BorderSize = 1;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtNombre.Location = new System.Drawing.Point(25, 123);
            this.txtNombre.MultiLine = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceHolderText = null;
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.Size = new System.Drawing.Size(175, 31);
            this.txtNombre.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtNombre.TabIndex = 68;
            // 
            // rjLabel5
            // 
            this.rjLabel5.AutoSize = true;
            this.rjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel5.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel5.LinkLabel = false;
            this.rjLabel5.Location = new System.Drawing.Point(28, 104);
            this.rjLabel5.Name = "rjLabel5";
            this.rjLabel5.Size = new System.Drawing.Size(75, 16);
            this.rjLabel5.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel5.TabIndex = 67;
            this.rjLabel5.Text = "Nombres :";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtId.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtId.LinkLabel = false;
            this.txtId.Location = new System.Drawing.Point(26, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 16);
            this.txtId.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.txtId.TabIndex = 63;
            this.txtId.Text = "Codigo";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboTipoDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cboTipoDoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboTipoDoc.BorderRadius = 0;
            this.cboTipoDoc.BorderSize = 1;
            this.cboTipoDoc.Customizable = false;
            this.cboTipoDoc.DataSource = null;
            this.cboTipoDoc.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTipoDoc.DropDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboTipoDoc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.cboTipoDoc.Location = new System.Drawing.Point(136, 42);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Padding = new System.Windows.Forms.Padding(1);
            this.cboTipoDoc.SelectedIndex = -1;
            this.cboTipoDoc.SelectedValue = null;
            this.cboTipoDoc.Size = new System.Drawing.Size(137, 32);
            this.cboTipoDoc.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.cboTipoDoc.TabIndex = 3;
            this.cboTipoDoc.Texts = "";
            // 
            // rjLabel3
            // 
            this.rjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel3.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel3.LinkLabel = false;
            this.rjLabel3.Location = new System.Drawing.Point(133, 23);
            this.rjLabel3.Name = "rjLabel3";
            this.rjLabel3.Size = new System.Drawing.Size(157, 16);
            this.rjLabel3.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel3.TabIndex = 2;
            this.rjLabel3.Text = "Tipo Documento :";
            // 
            // FormClienteRegister
            // 
            this._DesktopPanelSize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.Caption = "Mantenimiento Cliente";
            this.ClientSize = new System.Drawing.Size(910, 606);
            this.Name = "FormClienteRegister";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Mantenimiento Cliente";
            this.pnlClientArea.ResumeLayout(false);
            this.rjPanel7.ResumeLayout(false);
            this.rjPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeUI_M1.RJControls.RJToggleButton chkestado;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel15;
        private RJCodeUI_M1.RJControls.RJPanel rjPanel7;
        private RJCodeUI_M1.RJControls.RJComboBox cboTipoDoc;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel3;
        private RJCodeUI_M1.RJControls.RJButton btnSave;
        private RJCodeUI_M1.RJControls.RJTextBox txtCodigo;
        private RJCodeUI_M1.RJControls.RJTextBox txtNombre;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel5;
        private RJCodeUI_M1.RJControls.RJLabel txtId;
        private RJCodeUI_M1.RJControls.RJTextBox txtcondicion;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel13;
        private RJCodeUI_M1.RJControls.RJButton rjButton25;
        private RJCodeUI_M1.RJControls.RJComboBox cboDistrito;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel17;
        private RJCodeUI_M1.RJControls.RJComboBox cboProvincia;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel16;
        private RJCodeUI_M1.RJControls.RJComboBox cboDepartamento;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel14;
        private RJCodeUI_M1.RJControls.RJTextBox txtApeMaterno;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel12;
        private RJCodeUI_M1.RJControls.RJTextBox txtApePate;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel7;
        private RJCodeUI_M1.RJControls.RJTextBox txtclientecol;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel2;
        private RJCodeUI_M1.RJControls.RJTextBox txtnumdocumento;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel1;
        private RJCodeUI_M1.RJControls.RJTextBox txtcorreo;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel20;
        private RJCodeUI_M1.RJControls.RJTextBox txtfijo;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel19;
        private RJCodeUI_M1.RJControls.RJTextBox txtcelular;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel18;
    }
}