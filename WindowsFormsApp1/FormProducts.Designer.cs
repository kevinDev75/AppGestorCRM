using RJCodeUI_M1.RJControls;
using RJCodeUI_M1.Settings;
using RJCodeUI_M1.Utils;

namespace WindowsFormsApp1
 
{
    partial class FormProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEliminar = new RJCodeUI_M1.RJControls.RJButton();
            this.rjButton3 = new RJCodeUI_M1.RJControls.RJButton();
            this.rjButton2 = new RJCodeUI_M1.RJControls.RJButton();
            this.rjLabel3 = new RJCodeUI_M1.RJControls.RJLabel();
            this.rjButton1 = new RJCodeUI_M1.RJControls.RJButton();
            this.txtbuscar = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjDgvListProduct = new RJCodeUI_M1.RJControls.RJDataGridView();
            this.rjLabel2 = new RJCodeUI_M1.RJControls.RJLabel();
            this.cboDemografia = new RJCodeUI_M1.RJControls.RJComboBox();
            this.cboEditorial = new RJCodeUI_M1.RJControls.RJComboBox();
            this.rjLabel1 = new RJCodeUI_M1.RJControls.RJLabel();
            this.pnlClientArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjDgvListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientArea
            // 
            this.pnlClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlClientArea.Controls.Add(this.rjLabel1);
            this.pnlClientArea.Controls.Add(this.cboEditorial);
            this.pnlClientArea.Controls.Add(this.rjDgvListProduct);
            this.pnlClientArea.Controls.Add(this.rjLabel2);
            this.pnlClientArea.Controls.Add(this.cboDemografia);
            this.pnlClientArea.Controls.Add(this.BtnEliminar);
            this.pnlClientArea.Controls.Add(this.rjButton3);
            this.pnlClientArea.Controls.Add(this.rjButton2);
            this.pnlClientArea.Controls.Add(this.rjLabel3);
            this.pnlClientArea.Controls.Add(this.rjButton1);
            this.pnlClientArea.Controls.Add(this.txtbuscar);
            this.pnlClientArea.Location = new System.Drawing.Point(1, 41);
            this.pnlClientArea.Size = new System.Drawing.Size(958, 530);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.BtnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.BtnEliminar.BorderRadius = 10;
            this.BtnEliminar.BorderSize = 1;
            this.BtnEliminar.Design = RJCodeUI_M1.RJControls.ButtonDesign.Delete;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(74)))), ((int)(((byte)(77)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 24;
            this.BtnEliminar.Location = new System.Drawing.Point(387, 444);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(170, 40);
            this.BtnEliminar.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton3.BorderRadius = 10;
            this.rjButton3.BorderSize = 1;
            this.rjButton3.Design = RJCodeUI_M1.RJControls.ButtonDesign.IconButton;
            this.rjButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.rjButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(186)))));
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.rjButton3.IconColor = System.Drawing.Color.White;
            this.rjButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjButton3.IconSize = 24;
            this.rjButton3.Location = new System.Drawing.Point(211, 444);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(170, 40);
            this.rjButton3.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.rjButton3.TabIndex = 19;
            this.rjButton3.Text = "Editar";
            this.rjButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(159)))), ((int)(((byte)(113)))));
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.Design = RJCodeUI_M1.RJControls.ButtonDesign.Custom;
            this.rjButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(159)))), ((int)(((byte)(113)))));
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(106)))));
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.rjButton2.IconColor = System.Drawing.Color.White;
            this.rjButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjButton2.IconSize = 24;
            this.rjButton2.Location = new System.Drawing.Point(35, 444);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(170, 40);
            this.rjButton2.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.rjButton2.TabIndex = 18;
            this.rjButton2.Text = "Agregar nuevo";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // rjLabel3
            // 
            this.rjLabel3.AutoSize = true;
            this.rjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel3.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel3.LinkLabel = false;
            this.rjLabel3.Location = new System.Drawing.Point(359, 24);
            this.rjLabel3.Name = "rjLabel3";
            this.rjLabel3.Size = new System.Drawing.Size(311, 16);
            this.rjLabel3.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel3.TabIndex = 17;
            this.rjLabel3.Text = "Buscar por nombre o descripción del producto";
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.Design = RJCodeUI_M1.RJControls.ButtonDesign.IconButton;
            this.rjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(186)))));
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.rjButton1.IconColor = System.Drawing.Color.White;
            this.rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjButton1.IconSize = 24;
            this.rjButton1.Location = new System.Drawing.Point(797, 43);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(49, 31);
            this.rjButton1.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.rjButton1.TabIndex = 16;
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar._Customizable = false;
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtbuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtbuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.txtbuscar.BorderRadius = 0;
            this.txtbuscar.BorderSize = 1;
            this.txtbuscar.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtbuscar.Location = new System.Drawing.Point(362, 43);
            this.txtbuscar.MultiLine = false;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbuscar.PasswordChar = false;
            this.txtbuscar.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtbuscar.PlaceHolderText = "Buscar";
            this.txtbuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbuscar.Size = new System.Drawing.Size(429, 31);
            this.txtbuscar.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtbuscar.TabIndex = 15;
            this.txtbuscar.onTextChanged += new System.EventHandler(this.txtbuscar_onTextChanged);
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // rjDgvListProduct
            // 
            this.rjDgvListProduct.AllowUserToResizeRows = false;
            this.rjDgvListProduct.AlternatingRowsColor = System.Drawing.Color.Empty;
            this.rjDgvListProduct.AlternatingRowsColorApply = false;
            this.rjDgvListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjDgvListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rjDgvListProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjDgvListProduct.BorderRadius = 13;
            this.rjDgvListProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rjDgvListProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.rjDgvListProduct.ColumnHeaderColor = System.Drawing.Color.MediumPurple;
            this.rjDgvListProduct.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDgvListProduct.ColumnHeaderHeight = 40;
            this.rjDgvListProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rjDgvListProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rjDgvListProduct.ColumnHeadersHeight = 40;
            this.rjDgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rjDgvListProduct.ColumnHeaderTextColor = System.Drawing.Color.White;
            this.rjDgvListProduct.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rjDgvListProduct.Customizable = false;
            this.rjDgvListProduct.DgvBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.rjDgvListProduct.EnableHeadersVisualStyles = false;
            this.rjDgvListProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rjDgvListProduct.Location = new System.Drawing.Point(35, 82);
            this.rjDgvListProduct.Name = "rjDgvListProduct";
            this.rjDgvListProduct.ReadOnly = true;
            this.rjDgvListProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rjDgvListProduct.RowHeaderColor = System.Drawing.Color.WhiteSmoke;
            this.rjDgvListProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rjDgvListProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rjDgvListProduct.RowHeadersVisible = false;
            this.rjDgvListProduct.RowHeadersWidth = 30;
            this.rjDgvListProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rjDgvListProduct.RowHeight = 40;
            this.rjDgvListProduct.RowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            this.rjDgvListProduct.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.rjDgvListProduct.RowsTextColor = System.Drawing.Color.Gray;
            this.rjDgvListProduct.RowTemplate.Height = 40;
            this.rjDgvListProduct.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            this.rjDgvListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rjDgvListProduct.SelectionTextColor = System.Drawing.Color.Gray;
            this.rjDgvListProduct.Size = new System.Drawing.Size(888, 356);
            this.rjDgvListProduct.TabIndex = 14;
            this.rjDgvListProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.rjDgvListProduct_CellFormatting);
            // 
            // rjLabel2
            // 
            this.rjLabel2.AutoSize = true;
            this.rjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel2.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel2.LinkLabel = false;
            this.rjLabel2.Location = new System.Drawing.Point(32, 24);
            this.rjLabel2.Name = "rjLabel2";
            this.rjLabel2.Size = new System.Drawing.Size(87, 16);
            this.rjLabel2.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel2.TabIndex = 22;
            this.rjLabel2.Text = "Demografia:";
            // 
            // cboDemografia
            // 
            this.cboDemografia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboDemografia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboDemografia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cboDemografia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboDemografia.BorderRadius = 0;
            this.cboDemografia.BorderSize = 1;
            this.cboDemografia.Customizable = false;
            this.cboDemografia.DataSource = null;
            this.cboDemografia.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.cboDemografia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboDemografia.DropDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cboDemografia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.cboDemografia.Location = new System.Drawing.Point(35, 43);
            this.cboDemografia.Name = "cboDemografia";
            this.cboDemografia.Padding = new System.Windows.Forms.Padding(1);
            this.cboDemografia.SelectedIndex = -1;
            this.cboDemografia.SelectedValue = null;
            this.cboDemografia.Size = new System.Drawing.Size(152, 33);
            this.cboDemografia.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.cboDemografia.TabIndex = 21;
            this.cboDemografia.Texts = "";
            this.cboDemografia.OnSelectedIndexChanged += new System.EventHandler(this.cboDemografia_OnSelectedIndexChanged);
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
            this.cboEditorial.Location = new System.Drawing.Point(193, 43);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Padding = new System.Windows.Forms.Padding(1);
            this.cboEditorial.SelectedIndex = -1;
            this.cboEditorial.SelectedValue = null;
            this.cboEditorial.Size = new System.Drawing.Size(152, 33);
            this.cboEditorial.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.cboEditorial.TabIndex = 23;
            this.cboEditorial.Texts = "";
            // 
            // rjLabel1
            // 
            this.rjLabel1.AutoSize = true;
            this.rjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel1.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel1.LinkLabel = false;
            this.rjLabel1.Location = new System.Drawing.Point(190, 22);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(71, 16);
            this.rjLabel1.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel1.TabIndex = 24;
            this.rjLabel1.Text = "Editorial :";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.Caption = "Lista de Productos";
            this.ClientSize = new System.Drawing.Size(960, 572);
            this.FormIcon = FontAwesome.Sharp.IconChar.Tags;
            this.Name = "FormProducts";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Lista de Productos";
            this.pnlClientArea.ResumeLayout(false);
            this.pnlClientArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjDgvListProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeUI_M1.RJControls.RJButton BtnEliminar;
        private RJCodeUI_M1.RJControls.RJButton rjButton3;
        private RJCodeUI_M1.RJControls.RJButton rjButton2;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel3;
        private RJCodeUI_M1.RJControls.RJButton rjButton1;
        private RJCodeUI_M1.RJControls.RJTextBox txtbuscar;
        private RJCodeUI_M1.RJControls.RJDataGridView rjDgvListProduct;
        private RJCodeUI_M1.RJControls.RJLabel rjLabel2;
        private RJCodeUI_M1.RJControls.RJComboBox cboDemografia;
        private RJComboBox cboEditorial;
        private RJLabel rjLabel1;
    }
}