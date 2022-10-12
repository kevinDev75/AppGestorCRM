namespace WindowsFormsApp1
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.rjMenuProduct = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.rjDropdownMenu1 = new RJCodeUI_M1.RJControls.RJDropdownMenu(this.components);
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rjMenuButton1 = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.rjDropdownMenu2 = new RJCodeUI_M1.RJControls.RJDropdownMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rjMenuButton2 = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.rjDropdownMenu3 = new RJCodeUI_M1.RJControls.RJDropdownMenu(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownMenu4 = new RJCodeUI_M1.RJControls.RJDropdownMenu(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.rjMenuButton3 = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.coleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSideMenu.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            this.rjDropdownMenu2.SuspendLayout();
            this.rjDropdownMenu3.SuspendLayout();
            this.rjDropdownMenu4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.rjMenuButton3);
            this.pnlSideMenu.Controls.Add(this.rjMenuButton2);
            this.pnlSideMenu.Controls.Add(this.rjMenuButton1);
            this.pnlSideMenu.Controls.Add(this.rjMenuProduct);
            this.pnlSideMenu.Size = new System.Drawing.Size(220, 487);
            this.pnlSideMenu.Controls.SetChildIndex(this.rjMenuProduct, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.rjMenuButton1, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.rjMenuButton2, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.rjMenuButton3, 0);
            // 
            // pnlSideMenuHeader
            // 
            this.pnlSideMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Location = new System.Drawing.Point(221, 1);
            this.pnlTitleBar.Size = new System.Drawing.Size(766, 60);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Location = new System.Drawing.Point(221, 86);
            this.pnlDesktop.Size = new System.Drawing.Size(766, 462);
            // 
            // pnlDesktopHeader
            // 
            this.pnlDesktopHeader.Location = new System.Drawing.Point(221, 61);
            this.pnlDesktopHeader.Size = new System.Drawing.Size(766, 25);
            // 
            // rjMenuProduct
            // 
            this.rjMenuProduct.AutoSize = true;
            this.rjMenuProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.rjMenuProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjMenuProduct.BackgroundImage")));
            this.rjMenuProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjMenuProduct.DropdownMenu = this.rjDropdownMenu1;
            this.rjMenuProduct.FlatAppearance.BorderSize = 0;
            this.rjMenuProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.rjMenuProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjMenuProduct.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjMenuProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjMenuProduct.IconChar = FontAwesome.Sharp.IconChar.DiceD6;
            this.rjMenuProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjMenuProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuProduct.IconSize = 28;
            this.rjMenuProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjMenuProduct.Location = new System.Drawing.Point(0, 65);
            this.rjMenuProduct.Name = "rjMenuProduct";
            this.rjMenuProduct.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.rjMenuProduct.Size = new System.Drawing.Size(220, 34);
            this.rjMenuProduct.TabIndex = 25;
            this.rjMenuProduct.Text = "   Producto";
            this.rjMenuProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjMenuProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjMenuProduct.UseVisualStyleBackColor = false;
            this.rjMenuProduct.Click += new System.EventHandler(this.rjMenuButton1_Click);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.ActiveMenuItem = false;
            this.rjDropdownMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.coleccionToolStripMenuItem});
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.OwnerIsMenuButton = false;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(181, 92);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // rjMenuButton1
            // 
            this.rjMenuButton1.AutoSize = true;
            this.rjMenuButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.rjMenuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjMenuButton1.BackgroundImage")));
            this.rjMenuButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjMenuButton1.DropdownMenu = this.rjDropdownMenu2;
            this.rjMenuButton1.FlatAppearance.BorderSize = 0;
            this.rjMenuButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.rjMenuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjMenuButton1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjMenuButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjMenuButton1.IconChar = FontAwesome.Sharp.IconChar.DiceD6;
            this.rjMenuButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjMenuButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuButton1.IconSize = 28;
            this.rjMenuButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjMenuButton1.Location = new System.Drawing.Point(0, 99);
            this.rjMenuButton1.Name = "rjMenuButton1";
            this.rjMenuButton1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.rjMenuButton1.Size = new System.Drawing.Size(220, 34);
            this.rjMenuButton1.TabIndex = 26;
            this.rjMenuButton1.Text = "   Cliente";
            this.rjMenuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjMenuButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjMenuButton1.UseVisualStyleBackColor = false;
            // 
            // rjDropdownMenu2
            // 
            this.rjDropdownMenu2.ActiveMenuItem = false;
            this.rjDropdownMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.rjDropdownMenu2.Name = "rjDropdownMenu1";
            this.rjDropdownMenu2.OwnerIsMenuButton = false;
            this.rjDropdownMenu2.Size = new System.Drawing.Size(123, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem1.Text = "Listado";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem2.Text = "Nuevo";
            // 
            // rjMenuButton2
            // 
            this.rjMenuButton2.AutoSize = true;
            this.rjMenuButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.rjMenuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjMenuButton2.BackgroundImage")));
            this.rjMenuButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjMenuButton2.DropdownMenu = this.rjDropdownMenu3;
            this.rjMenuButton2.FlatAppearance.BorderSize = 0;
            this.rjMenuButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.rjMenuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjMenuButton2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjMenuButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjMenuButton2.IconChar = FontAwesome.Sharp.IconChar.DiceD6;
            this.rjMenuButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjMenuButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuButton2.IconSize = 28;
            this.rjMenuButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjMenuButton2.Location = new System.Drawing.Point(0, 133);
            this.rjMenuButton2.Name = "rjMenuButton2";
            this.rjMenuButton2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.rjMenuButton2.Size = new System.Drawing.Size(220, 34);
            this.rjMenuButton2.TabIndex = 27;
            this.rjMenuButton2.Text = "   Pedidos";
            this.rjMenuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjMenuButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjMenuButton2.UseVisualStyleBackColor = false;
            // 
            // rjDropdownMenu3
            // 
            this.rjDropdownMenu3.ActiveMenuItem = false;
            this.rjDropdownMenu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.rjDropdownMenu3.Name = "rjDropdownMenu1";
            this.rjDropdownMenu3.OwnerIsMenuButton = false;
            this.rjDropdownMenu3.Size = new System.Drawing.Size(135, 48);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem3.Text = "Listar";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem4.Text = "Registrar";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // rjDropdownMenu4
            // 
            this.rjDropdownMenu4.ActiveMenuItem = false;
            this.rjDropdownMenu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.rjDropdownMenu4.Name = "rjDropdownMenu1";
            this.rjDropdownMenu4.OwnerIsMenuButton = false;
            this.rjDropdownMenu4.Size = new System.Drawing.Size(123, 48);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem5.Text = "Listado";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem6.Text = "Nuevo";
            // 
            // rjMenuButton3
            // 
            this.rjMenuButton3.AutoSize = true;
            this.rjMenuButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.rjMenuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjMenuButton3.BackgroundImage")));
            this.rjMenuButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjMenuButton3.DropdownMenu = this.rjDropdownMenu4;
            this.rjMenuButton3.FlatAppearance.BorderSize = 0;
            this.rjMenuButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.rjMenuButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjMenuButton3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjMenuButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjMenuButton3.IconChar = FontAwesome.Sharp.IconChar.DiceD6;
            this.rjMenuButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.rjMenuButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjMenuButton3.IconSize = 28;
            this.rjMenuButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjMenuButton3.Location = new System.Drawing.Point(0, 167);
            this.rjMenuButton3.Name = "rjMenuButton3";
            this.rjMenuButton3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.rjMenuButton3.Size = new System.Drawing.Size(220, 34);
            this.rjMenuButton3.TabIndex = 28;
            this.rjMenuButton3.Text = "   Subcripciones";
            this.rjMenuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjMenuButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjMenuButton3.UseVisualStyleBackColor = false;
            // 
            // coleccionToolStripMenuItem
            // 
            this.coleccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem1});
            this.coleccionToolStripMenuItem.Name = "coleccionToolStripMenuItem";
            this.coleccionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coleccionToolStripMenuItem.Text = "coleccion";
            // 
            // listadoToolStripMenuItem1
            // 
            this.listadoToolStripMenuItem1.Name = "listadoToolStripMenuItem1";
            this.listadoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listadoToolStripMenuItem1.Text = "listado";
            this.listadoToolStripMenuItem1.Click += new System.EventHandler(this.listadoToolStripMenuItem1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.ClientSize = new System.Drawing.Size(988, 549);
            this.Name = "FormPrincipal";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Principal";
            this.Controls.SetChildIndex(this.pnlTitleBar, 0);
            this.Controls.SetChildIndex(this.pnlDesktopHeader, 0);
            this.Controls.SetChildIndex(this.pnlDesktop, 0);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            this.rjDropdownMenu1.ResumeLayout(false);
            this.rjDropdownMenu2.ResumeLayout(false);
            this.rjDropdownMenu3.ResumeLayout(false);
            this.rjDropdownMenu4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeUI_M1.RJControls.RJMenuButton rjMenuProduct;
        private RJCodeUI_M1.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private RJCodeUI_M1.RJControls.RJMenuButton rjMenuButton1;
        private RJCodeUI_M1.RJControls.RJMenuButton rjMenuButton2;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private RJCodeUI_M1.RJControls.RJDropdownMenu rjDropdownMenu2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private RJCodeUI_M1.RJControls.RJDropdownMenu rjDropdownMenu3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private RJCodeUI_M1.RJControls.RJMenuButton rjMenuButton3;
        private RJCodeUI_M1.RJControls.RJDropdownMenu rjDropdownMenu4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem coleccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem1;
    }
}