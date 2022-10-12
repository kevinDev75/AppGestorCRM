using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RJCodeUI_M1.Settings;
using System.Diagnostics;

namespace RJCodeUI_M1
{
    public partial class LoginForm : RJForms.RJBaseForm
    {

        #region -> Constructor

        public LoginForm()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            AddControlBox();
            ApplyAppearanceSettings();

            //Agregar una linea
            var line = new Control();
            line.Size = new Size(lblDescription.Width - 10, 1);
            line.BackColor = Color.LightGray;
            line.Location = new Point(lblDescription.Left + 5, lblTitle.Bottom + 15);
            icoBanner.Controls.Add(line);
        }
        #endregion

        #region -> Métodos privados

        private void AddControlBox()
        {//Agregar los botones de control (Maximizar, cerrar y minimizar)
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.btnClose.Height = 20;
            this.btnClose.Location = new Point(this.Width - btnClose.Width, 0);

            this.btnMinimize.Height = 20;
            this.btnMinimize.Location = new Point(this.btnClose.Location.X - btnMinimize.Width, 0);
        }
        private void ApplyAppearanceSettings()
        {//Aplicar las propiedades de apariencia de la configuración.

            this.PrimaryForm = true;//Establecer como formulario primario.
            this.Resizable = false;//Establecer que el formulario no se puede cambiar de tamaño desde los bordes.
            this.BorderSize = 0;//Quitar el borde.
            this.BackColor = UIAppearance.BackgroundColor;//Establecer el color de fondo

            if (UIAppearance.Theme == UITheme.Light)//si el tema es CLARO, establecer los botones de maximizar, minimizar y cerrar en negro.
            {
                this.btnClose.Image = Properties.Resources.CloseDark;
                this.btnMaximize.Image = Properties.Resources.MaximizeDark;
                this.btnMinimize.Image = Properties.Resources.MinimizeDark;
            }

        }
        private void Login()
        {//Metodo para iniciar sesión

            //Validar campos
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                lblMessage.Text = "*Por favor, ingrese su nombre de usuario";
                lblMessage.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMessage.Text = "*Por favor, introduzca su contraseña";
                lblMessage.Visible = true;
                return;
            }
            //Login
            var user = new Models.User().Login(txtUser.Text, txtPassword.Text);

            if (user != null)
            {
                var mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();

                //Volver a mostrar el formulario de inicio de sesión y borrar los campos si el formulario principal es cerrado.
                mainForm.FormClosed += new FormClosedEventHandler(MainForm_Logout);
            }
            else
            {
                lblMessage.Text = "*Nombre de usuario o contraseña incorrecta";
                lblMessage.Visible = true;
            }
        }
        private void Logout()
        {//Metodo para cuando se cierra sesion desde el formulario principal.
            txtPassword.Clear();
            txtUser.Clear();
            lblMessage.Visible = false;
            lblCaption.Select();
            this.Show();//Volver a mostrar el formulario de inicio de sesión.
        }
        #endregion

        #region -> Anulaciones

        protected override void CloseWindow()
        {//Anular el metodo (Para quitar el cuadro de mensaje si se desea salir de la app ) y simplemente salir de aplicación, Esto es opcional.
            Application.Exit();//Salir de aplicacíon.
        }
        #endregion

        #region -> Métodos de evento

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void MainForm_Logout(object sender, FormClosedEventArgs e)
        {//Evento cuando se cierra el formulario principal.
            Logout();
        }
        private void biYoutube_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtube.com/rjcodeadvanceen");
        }
        private void biWebPage_Click(object sender, EventArgs e)
        {
            Process.Start("https://rjcodeadvance.com/");
        }
        private void biGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/rjcodeadvance");
        }
        private void biFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/RJCodeAdvance");
        }
        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
