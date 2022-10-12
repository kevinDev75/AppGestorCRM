namespace WindowsFormsApp1
{
    partial class FormProductRegister
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
            this.cboEditorial = new RJCodeUI_M1.RJControls.RJComboBox();
            this.rjLabel3 = new RJCodeUI_M1.RJControls.RJLabel();
            this.cboformato = new RJCodeUI_M1.RJControls.RJComboBox();
            this.rjLabel2 = new RJCodeUI_M1.RJControls.RJLabel();
            this.btnSave = new RJCodeUI_M1.RJControls.RJButton();
            this.dpklanzamiento = new RJCodeUI_M1.RJControls.RJDatePicker();
            this.rjLabel11 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtidproduct = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel8 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txttitulo = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel5 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtisbn = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel4 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtId = new RJCodeUI_M1.RJControls.RJLabel();
            this.btnDeletePhoto = new RJCodeUI_M1.RJControls.RJButton();
            this.btnAddPhoto = new RJCodeUI_M1.RJControls.RJButton();
            this.rjLabel12 = new RJCodeUI_M1.RJControls.RJLabel();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.txtprecio = new RJCodeUI_M1.RJControls.RJTextBox();
            this.txtpaginas = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel1 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txttamanio = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel9 = new RJCodeUI_M1.RJControls.RJLabel();
            this.rjLabel10 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtresenia = new RJCodeUI_M1.RJControls.RJTextBox();
            this.cboColeccion = new RJCodeUI_M1.RJControls.RJComboBox();
            this.rjLabel6 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtvaloracion = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel13 = new RJCodeUI_M1.RJControls.RJLabel();
            this.rjButton25 = new RJCodeUI_M1.RJControls.RJButton();
            this.pnlClientArea.SuspendLayout();
            this.rjPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
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
            this.chkestado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkestado.Customizable = false;
            this.chkestado.FlatAppearance.BorderSize = 0;
            this.chkestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkestado.Location = new System.Drawing.Point(341, 287);
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
            this.rjLabel15.Location = new System.Drawing.Point(271, 290);
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
            this.rjPanel7.Controls.Add(this.rjButton25);
            this.rjPanel7.Controls.Add(this.txtvaloracion);
            this.rjPanel7.Controls.Add(this.rjLabel13);
            this.rjPanel7.Controls.Add(this.cboColeccion);
            this.rjPanel7.Controls.Add(this.rjLabel6);
            this.rjPanel7.Controls.Add(this.txtresenia);
            this.rjPanel7.Controls.Add(this.rjLabel10);
            this.rjPanel7.Controls.Add(this.txttamanio);
            this.rjPanel7.Controls.Add(this.rjLabel9);
            this.rjPanel7.Controls.Add(this.txtpaginas);
            this.rjPanel7.Controls.Add(this.rjLabel1);
            this.rjPanel7.Controls.Add(this.txtprecio);
            this.rjPanel7.Controls.Add(this.btnSave);
            this.rjPanel7.Controls.Add(this.dpklanzamiento);
            this.rjPanel7.Controls.Add(this.rjLabel11);
            this.rjPanel7.Controls.Add(this.txtidproduct);
            this.rjPanel7.Controls.Add(this.rjLabel8);
            this.rjPanel7.Controls.Add(this.txttitulo);
            this.rjPanel7.Controls.Add(this.rjLabel5);
            this.rjPanel7.Controls.Add(this.txtisbn);
            this.rjPanel7.Controls.Add(this.rjLabel4);
            this.rjPanel7.Controls.Add(this.txtId);
            this.rjPanel7.Controls.Add(this.btnDeletePhoto);
            this.rjPanel7.Controls.Add(this.btnAddPhoto);
            this.rjPanel7.Controls.Add(this.rjLabel12);
            this.rjPanel7.Controls.Add(this.pbPhoto);
            this.rjPanel7.Controls.Add(this.cboEditorial);
            this.rjPanel7.Controls.Add(this.chkestado);
            this.rjPanel7.Controls.Add(this.rjLabel15);
            this.rjPanel7.Controls.Add(this.rjLabel3);
            this.rjPanel7.Controls.Add(this.cboformato);
            this.rjPanel7.Controls.Add(this.rjLabel2);
            this.rjPanel7.Customizable = false;
            this.rjPanel7.Location = new System.Drawing.Point(14, 16);
            this.rjPanel7.Name = "rjPanel7";
            this.rjPanel7.Size = new System.Drawing.Size(876, 533);
            this.rjPanel7.TabIndex = 58;
            this.rjPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel7_Paint);
            // 
            // cboEditorial
            // 
            this.cboEditorial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboEditorial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cboEditorial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboEditorial.BorderRadius = 0;
            this.cboEditorial.BorderSize = 1;
            this.cboEditorial.Customizable = false;
            this.cboEditorial.DataSource = null;
            this.cboEditorial.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.cboEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboEditorial.DropDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboEditorial.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.cboEditorial.Location = new System.Drawing.Point(576, 160);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Padding = new System.Windows.Forms.Padding(1);
            this.cboEditorial.SelectedIndex = -1;
            this.cboEditorial.Size = new System.Drawing.Size(244, 32);
            this.cboEditorial.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.cboEditorial.TabIndex = 3;
            this.cboEditorial.Texts = "";
            // 
            // rjLabel3
            // 
            this.rjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel3.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel3.LinkLabel = false;
            this.rjLabel3.Location = new System.Drawing.Point(573, 141);
            this.rjLabel3.Name = "rjLabel3";
            this.rjLabel3.Size = new System.Drawing.Size(157, 16);
            this.rjLabel3.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel3.TabIndex = 2;
            this.rjLabel3.Text = "Editorial :";
            // 
            // cboformato
            // 
            this.cboformato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboformato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboformato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cboformato.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboformato.BorderRadius = 0;
            this.cboformato.BorderSize = 1;
            this.cboformato.Customizable = false;
            this.cboformato.DataSource = null;
            this.cboformato.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.cboformato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboformato.DropDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboformato.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.cboformato.Items.AddRange(new object[] {
            "Hoy",
            "Ultimos 7 dias",
            "Este mes",
            "Ultimos 30 dias",
            "Este año",
            "Personalizado"});
            this.cboformato.Location = new System.Drawing.Point(272, 227);
            this.cboformato.Name = "cboformato";
            this.cboformato.Padding = new System.Windows.Forms.Padding(1);
            this.cboformato.SelectedIndex = -1;
            this.cboformato.Size = new System.Drawing.Size(194, 32);
            this.cboformato.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.cboformato.TabIndex = 1;
            this.cboformato.Texts = "";
            // 
            // rjLabel2
            // 
            this.rjLabel2.AutoSize = true;
            this.rjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel2.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel2.LinkLabel = false;
            this.rjLabel2.Location = new System.Drawing.Point(271, 208);
            this.rjLabel2.Name = "rjLabel2";
            this.rjLabel2.Size = new System.Drawing.Size(78, 16);
            this.rjLabel2.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel2.TabIndex = 0;
            this.rjLabel2.Text = "Formato : ";
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
            // dpklanzamiento
            // 
            this.dpklanzamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dpklanzamiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.dpklanzamiento.BorderSize = 1;
            this.dpklanzamiento.CustomFormat = "MMMM dd, yyyy";
            this.dpklanzamiento.Customizable = false;
            this.dpklanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpklanzamiento.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.dpklanzamiento.Location = new System.Drawing.Point(610, 101);
            this.dpklanzamiento.MinimumSize = new System.Drawing.Size(120, 25);
            this.dpklanzamiento.Name = "dpklanzamiento";
            this.dpklanzamiento.Padding = new System.Windows.Forms.Padding(1);
            this.dpklanzamiento.Size = new System.Drawing.Size(210, 32);
            this.dpklanzamiento.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.dpklanzamiento.TabIndex = 80;
            this.dpklanzamiento.Value = new System.DateTime(2020, 12, 22, 20, 8, 28, 493);
            // 
            // rjLabel11
            // 
            this.rjLabel11.AutoSize = true;
            this.rjLabel11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel11.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel11.LinkLabel = false;
            this.rjLabel11.Location = new System.Drawing.Point(607, 82);
            this.rjLabel11.Name = "rjLabel11";
            this.rjLabel11.Size = new System.Drawing.Size(142, 16);
            this.rjLabel11.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel11.TabIndex = 79;
            this.rjLabel11.Text = "Fecha lanzamiento :";
            // 
            // txtidproduct
            // 
            this.txtidproduct._Customizable = false;
            this.txtidproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtidproduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtidproduct.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtidproduct.BorderRadius = 0;
            this.txtidproduct.BorderSize = 1;
            this.txtidproduct.Enabled = false;
            this.txtidproduct.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtidproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtidproduct.Location = new System.Drawing.Point(20, 371);
            this.txtidproduct.MultiLine = false;
            this.txtidproduct.Name = "txtidproduct";
            this.txtidproduct.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtidproduct.PasswordChar = false;
            this.txtidproduct.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtidproduct.PlaceHolderText = null;
            this.txtidproduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtidproduct.Size = new System.Drawing.Size(77, 31);
            this.txtidproduct.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtidproduct.TabIndex = 74;
            // 
            // rjLabel8
            // 
            this.rjLabel8.AutoSize = true;
            this.rjLabel8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel8.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel8.LinkLabel = false;
            this.rjLabel8.Location = new System.Drawing.Point(485, 83);
            this.rjLabel8.Name = "rjLabel8";
            this.rjLabel8.Size = new System.Drawing.Size(59, 16);
            this.rjLabel8.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel8.TabIndex = 73;
            this.rjLabel8.Text = "Precio :";
            // 
            // txttitulo
            // 
            this.txttitulo._Customizable = false;
            this.txttitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txttitulo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txttitulo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txttitulo.BorderRadius = 7;
            this.txttitulo.BorderSize = 1;
            this.txttitulo.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txttitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txttitulo.Location = new System.Drawing.Point(272, 43);
            this.txttitulo.MultiLine = false;
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txttitulo.PasswordChar = false;
            this.txttitulo.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txttitulo.PlaceHolderText = null;
            this.txttitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttitulo.Size = new System.Drawing.Size(548, 31);
            this.txttitulo.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txttitulo.TabIndex = 68;
            // 
            // rjLabel5
            // 
            this.rjLabel5.AutoSize = true;
            this.rjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel5.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel5.LinkLabel = false;
            this.rjLabel5.Location = new System.Drawing.Point(269, 24);
            this.rjLabel5.Name = "rjLabel5";
            this.rjLabel5.Size = new System.Drawing.Size(61, 16);
            this.rjLabel5.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel5.TabIndex = 67;
            this.rjLabel5.Text = "Titulo : ";
            // 
            // txtisbn
            // 
            this.txtisbn._Customizable = false;
            this.txtisbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtisbn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtisbn.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtisbn.BorderRadius = 7;
            this.txtisbn.BorderSize = 1;
            this.txtisbn.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtisbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtisbn.Location = new System.Drawing.Point(274, 102);
            this.txtisbn.MultiLine = false;
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtisbn.PasswordChar = false;
            this.txtisbn.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtisbn.PlaceHolderText = null;
            this.txtisbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtisbn.Size = new System.Drawing.Size(192, 31);
            this.txtisbn.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtisbn.TabIndex = 66;
            // 
            // rjLabel4
            // 
            this.rjLabel4.AutoSize = true;
            this.rjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel4.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel4.LinkLabel = false;
            this.rjLabel4.Location = new System.Drawing.Point(271, 83);
            this.rjLabel4.Name = "rjLabel4";
            this.rjLabel4.Size = new System.Drawing.Size(50, 16);
            this.rjLabel4.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel4.TabIndex = 65;
            this.rjLabel4.Text = "ISBN: ";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtId.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtId.LinkLabel = false;
            this.txtId.Location = new System.Drawing.Point(17, 351);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(33, 16);
            this.txtId.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.txtId.TabIndex = 63;
            this.txtId.Text = "ID :";
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.btnDeletePhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnDeletePhoto.BorderRadius = 0;
            this.btnDeletePhoto.BorderSize = 1;
            this.btnDeletePhoto.Design = RJCodeUI_M1.RJControls.ButtonDesign.Custom;
            this.btnDeletePhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.btnDeletePhoto.FlatAppearance.BorderSize = 0;
            this.btnDeletePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(74)))), ((int)(((byte)(77)))));
            this.btnDeletePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePhoto.ForeColor = System.Drawing.Color.White;
            this.btnDeletePhoto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeletePhoto.IconColor = System.Drawing.Color.White;
            this.btnDeletePhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeletePhoto.IconSize = 15;
            this.btnDeletePhoto.Location = new System.Drawing.Point(219, 302);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(25, 25);
            this.btnDeletePhoto.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.btnDeletePhoto.TabIndex = 62;
            this.btnDeletePhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePhoto.UseVisualStyleBackColor = false;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(159)))), ((int)(((byte)(113)))));
            this.btnAddPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnAddPhoto.BorderRadius = 0;
            this.btnAddPhoto.BorderSize = 1;
            this.btnAddPhoto.Design = RJCodeUI_M1.RJControls.ButtonDesign.Custom;
            this.btnAddPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(159)))), ((int)(((byte)(113)))));
            this.btnAddPhoto.FlatAppearance.BorderSize = 0;
            this.btnAddPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(106)))));
            this.btnAddPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.btnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddPhoto.IconColor = System.Drawing.Color.White;
            this.btnAddPhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPhoto.IconSize = 15;
            this.btnAddPhoto.Location = new System.Drawing.Point(188, 302);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(25, 25);
            this.btnAddPhoto.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.btnAddPhoto.TabIndex = 61;
            this.btnAddPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // rjLabel12
            // 
            this.rjLabel12.AutoSize = true;
            this.rjLabel12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel12.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel12.LinkLabel = false;
            this.rjLabel12.Location = new System.Drawing.Point(33, 304);
            this.rjLabel12.Name = "rjLabel12";
            this.rjLabel12.Size = new System.Drawing.Size(110, 16);
            this.rjLabel12.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel12.TabIndex = 60;
            this.rjLabel12.Text = "cambiar imagen";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(20, 24);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(224, 272);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 58;
            this.pbPhoto.TabStop = false;
            // 
            // txtprecio
            // 
            this.txtprecio._Customizable = false;
            this.txtprecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtprecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtprecio.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtprecio.BorderRadius = 7;
            this.txtprecio.BorderSize = 1;
            this.txtprecio.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtprecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtprecio.Location = new System.Drawing.Point(488, 102);
            this.txtprecio.MultiLine = false;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtprecio.PasswordChar = false;
            this.txtprecio.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtprecio.PlaceHolderText = null;
            this.txtprecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprecio.Size = new System.Drawing.Size(105, 31);
            this.txtprecio.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtprecio.TabIndex = 82;
            // 
            // txtpaginas
            // 
            this.txtpaginas._Customizable = false;
            this.txtpaginas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtpaginas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtpaginas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtpaginas.BorderRadius = 7;
            this.txtpaginas.BorderSize = 1;
            this.txtpaginas.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtpaginas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtpaginas.Location = new System.Drawing.Point(274, 161);
            this.txtpaginas.MultiLine = false;
            this.txtpaginas.Name = "txtpaginas";
            this.txtpaginas.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtpaginas.PasswordChar = false;
            this.txtpaginas.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtpaginas.PlaceHolderText = null;
            this.txtpaginas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpaginas.Size = new System.Drawing.Size(89, 31);
            this.txtpaginas.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtpaginas.TabIndex = 84;
            // 
            // rjLabel1
            // 
            this.rjLabel1.AutoSize = true;
            this.rjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel1.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel1.LinkLabel = false;
            this.rjLabel1.Location = new System.Drawing.Point(271, 142);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(74, 16);
            this.rjLabel1.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel1.TabIndex = 83;
            this.rjLabel1.Text = "Paginas : ";
            // 
            // txttamanio
            // 
            this.txttamanio._Customizable = false;
            this.txttamanio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txttamanio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txttamanio.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txttamanio.BorderRadius = 7;
            this.txttamanio.BorderSize = 1;
            this.txttamanio.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txttamanio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txttamanio.Location = new System.Drawing.Point(392, 160);
            this.txttamanio.MultiLine = false;
            this.txttamanio.Name = "txttamanio";
            this.txttamanio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txttamanio.PasswordChar = false;
            this.txttamanio.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txttamanio.PlaceHolderText = null;
            this.txttamanio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttamanio.Size = new System.Drawing.Size(162, 31);
            this.txttamanio.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txttamanio.TabIndex = 86;
            // 
            // rjLabel9
            // 
            this.rjLabel9.AutoSize = true;
            this.rjLabel9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel9.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel9.LinkLabel = false;
            this.rjLabel9.Location = new System.Drawing.Point(392, 142);
            this.rjLabel9.Name = "rjLabel9";
            this.rjLabel9.Size = new System.Drawing.Size(74, 16);
            this.rjLabel9.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel9.TabIndex = 85;
            this.rjLabel9.Text = "Tamaño : ";
            // 
            // rjLabel10
            // 
            this.rjLabel10.AutoSize = true;
            this.rjLabel10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel10.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel10.LinkLabel = false;
            this.rjLabel10.Location = new System.Drawing.Point(485, 271);
            this.rjLabel10.Name = "rjLabel10";
            this.rjLabel10.Size = new System.Drawing.Size(66, 16);
            this.rjLabel10.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel10.TabIndex = 87;
            this.rjLabel10.Text = "Reseña :";
            // 
            // txtresenia
            // 
            this.txtresenia._Customizable = false;
            this.txtresenia.AllowDrop = true;
            this.txtresenia.AutoScroll = true;
            this.txtresenia.AutoSize = true;
            this.txtresenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtresenia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtresenia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtresenia.BorderRadius = 0;
            this.txtresenia.BorderSize = 1;
            this.txtresenia.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtresenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtresenia.Location = new System.Drawing.Point(487, 290);
            this.txtresenia.MultiLine = true;
            this.txtresenia.Name = "txtresenia";
            this.txtresenia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtresenia.PasswordChar = false;
            this.txtresenia.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtresenia.PlaceHolderText = null;
            this.txtresenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtresenia.Size = new System.Drawing.Size(333, 85);
            this.txtresenia.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtresenia.TabIndex = 89;
            // 
            // cboColeccion
            // 
            this.cboColeccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboColeccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboColeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cboColeccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboColeccion.BorderRadius = 0;
            this.cboColeccion.BorderSize = 1;
            this.cboColeccion.Customizable = false;
            this.cboColeccion.DataSource = null;
            this.cboColeccion.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.cboColeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboColeccion.DropDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboColeccion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.cboColeccion.Items.AddRange(new object[] {
            "Hoy",
            "Ultimos 7 dias",
            "Este mes",
            "Ultimos 30 dias",
            "Este año",
            "Personalizado"});
            this.cboColeccion.Location = new System.Drawing.Point(488, 227);
            this.cboColeccion.Name = "cboColeccion";
            this.cboColeccion.Padding = new System.Windows.Forms.Padding(1);
            this.cboColeccion.SelectedIndex = -1;
            this.cboColeccion.Size = new System.Drawing.Size(216, 32);
            this.cboColeccion.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.cboColeccion.TabIndex = 91;
            this.cboColeccion.Texts = "";
            // 
            // rjLabel6
            // 
            this.rjLabel6.AutoSize = true;
            this.rjLabel6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel6.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel6.LinkLabel = false;
            this.rjLabel6.Location = new System.Drawing.Point(485, 208);
            this.rjLabel6.Name = "rjLabel6";
            this.rjLabel6.Size = new System.Drawing.Size(71, 16);
            this.rjLabel6.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel6.TabIndex = 90;
            this.rjLabel6.Text = "Colección";
            // 
            // txtvaloracion
            // 
            this.txtvaloracion._Customizable = false;
            this.txtvaloracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtvaloracion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtvaloracion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtvaloracion.BorderRadius = 7;
            this.txtvaloracion.BorderSize = 1;
            this.txtvaloracion.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtvaloracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtvaloracion.Location = new System.Drawing.Point(731, 228);
            this.txtvaloracion.MultiLine = false;
            this.txtvaloracion.Name = "txtvaloracion";
            this.txtvaloracion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtvaloracion.PasswordChar = false;
            this.txtvaloracion.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtvaloracion.PlaceHolderText = null;
            this.txtvaloracion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtvaloracion.Size = new System.Drawing.Size(89, 31);
            this.txtvaloracion.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtvaloracion.TabIndex = 93;
            // 
            // rjLabel13
            // 
            this.rjLabel13.AutoSize = true;
            this.rjLabel13.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel13.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel13.LinkLabel = false;
            this.rjLabel13.Location = new System.Drawing.Point(728, 209);
            this.rjLabel13.Name = "rjLabel13";
            this.rjLabel13.Size = new System.Drawing.Size(86, 16);
            this.rjLabel13.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel13.TabIndex = 92;
            this.rjLabel13.Text = "Valoración :";
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
            // FormProductRegister
            // 
            this._DesktopPanelSize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.Caption = "Mantenimiento Producto";
            this.ClientSize = new System.Drawing.Size(910, 606);
            this.Name = "FormProductRegister";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Mantenimiento Producto";
            this.pnlClientArea.ResumeLayout(false);
            this.rjPanel7.ResumeLayout(false);
            this.rjPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeUI_M1.RJControls.RJToggleButton chkestado;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel15;
        private RJCodeUI_M1.RJControls.RJPanel rjPanel7;
        private RJCodeUI_M1.RJControls.RJComboBox cboEditorial;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel3;
        private RJCodeUI_M1.RJControls.RJComboBox cboformato;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel2;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel10;
        private RJCodeUI_M1.RJControls.RJTextBox txttamanio;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel9;
        private RJCodeUI_M1.RJControls.RJTextBox txtpaginas;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel1;
        private RJCodeUI_M1.RJControls.RJTextBox txtprecio;
        private RJCodeUI_M1.RJControls.RJButton btnSave;
        private RJCodeUI_M1.RJControls.RJDatePicker dpklanzamiento;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel11;
        private RJCodeUI_M1.RJControls.RJTextBox txtidproduct;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel8;
        private RJCodeUI_M1.RJControls.RJTextBox txttitulo;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel5;
        private RJCodeUI_M1.RJControls.RJTextBox txtisbn;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel4;
        private RJCodeUI_M1.RJControls.RJLabel txtId;
        private RJCodeUI_M1.RJControls.RJButton btnDeletePhoto;
        private RJCodeUI_M1.RJControls.RJButton btnAddPhoto;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel12;
        private System.Windows.Forms.PictureBox pbPhoto;
        private RJCodeUI_M1.RJControls.RJTextBox txtresenia;
        private RJCodeUI_M1.RJControls.RJTextBox txtvaloracion;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel13;
        private RJCodeUI_M1.RJControls.RJComboBox cboColeccion;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel6;
        private RJCodeUI_M1.RJControls.RJButton rjButton25;
    }
}