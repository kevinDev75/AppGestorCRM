using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RJCodeUI_M1.Models;
using RJCodeUI_M1.TestAndDemo;
using System.Diagnostics;
using System.IO;

namespace RJCodeUI_M1
{
    public partial class MainForm : RJForms.RJMainForm
    {
        #region -> Campos

        private User userConnected; //Obtiene o establece el usuario que ha iniciado sesión.

        #endregion

        #region -> Constructor

        public MainForm()
        {
            InitializeComponent();
            InitializeItems();

            lblUserName.Text = "No login";
        }

        public MainForm(User user)
        {
            InitializeComponent();
            InitializeItems();
            //
            userConnected = user;
            lblUserName.Text = user.FirstName + " " + user.LastName;
            pbProfilePicture.Image = user.ProfilePicture;

        }
        private void InitializeItems()
        {
            biFormOptions.DropdownMenu = this.dmFormOptions;//Establecer menú desplegable de opciones de formulario
            if (Settings.UIAppearance.Style == Settings.UIStyle.Supernova)
                pbSideMenuLogo.Image = Properties.Resources.RJTitleBarLogoColor;

        }
        #endregion

        #region -> Métodos de evento

        //Cómo utilizar el método OpenChildForm <childForm> (...)

        /// Puede usar el delegado Func <TResult> con Métodos anónimos o expresión lambda,
        /// por ejemplo, podemos llamar a este método de la siguiente manera:
        /// Con método anónimo:
        ///     <see cref="OpenChildForm( delegate () { return new MyForm('MyParameter'); });"/>    
        /// Con expresión lambda
        ///     <see cref="OpenChildForm( () => new MyForm('id', 'username'));"/>


        #region - Abrir formulario secundario
        //(Menú desplegable de opciones de usuario)
        /// Utilizando el método [<see cref="OpenChildForm<childForm>(Func<childForm> _delegate) where childForm : RJChildForm"/>]

        private void miMyProfile_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormUserProfile(userConnected));
            //()=> :Llamar el delegado genérico
        }
        private void miSettings_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new RJForms.RJSettingsForm());
        }

        #endregion

        #region - Abrir formulario secundario desde un botón de menú
        //(Menú lateral)
        /// Utilizando el método [<see cref="OpenChildForm<childForm>(Func<childForm> _delegate, object senderMenuButton) where childForm : RJChildForm"/>]

        private void btnUserControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormUserControls(), sender);
            //()=> : Llamar el delegado genérico
            //sender: btnUserControls (MenuButton)
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormDashboard(), sender);
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormProducts(), sender);
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormCustomer(), sender);
        }
        #endregion

        #region - Abrir formulario secundario desde un elemento del menú desplegable asociado con un botón de menú
        //(Menú lateral)
        /// Utilizando el método [<see cref="OpenChildForm<childForm>(Func<childForm> _delegate, object senderMenuItem, RJMenuButton ownerMenuButton) where childForm : RJChildForm"/>]

        private void miCommonControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormCommonControls(), sender, btnCustomControls);
            //()=> : Llamar el delegado genérico
            //sender: commonToolStripMenuItem (dmCustomControls Menu Item)
            //btnCustomControls: Botón de menú 
        }
        private void miComponentsControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormComponentControls(), sender, btnCustomControls);
        }
        private void miMenuControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormMenuControls(), sender, btnCustomControls);
        }
        private void miContainerControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormContainerControls(), sender, btnCustomControls);
        }
        private void miDataControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormDataControls(), sender, btnCustomControls);
        }
        private void miSpecialControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormSpecialControls(), sender, btnCustomControls);
        }
        private void miSalesList_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormSalesOrder(), sender, btnSales);
        }

        private void formularioBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormRJBaseFormDoc(), sender, btnCustomForms);
        }
        private void formularioPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormRJMainFormDoc(), sender, btnCustomForms);
        }
        private void formularioSecundarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormRJChildFormDoc(), sender, btnCustomForms);
        }
        #endregion

        #region - Opciones de usuario
        //(Menú desplegable de opciones de usuario)

        private void miExit_Click(object sender, EventArgs e)
        {
            this.CloseWindow();
        }
        private void miLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void miHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"Files\Documentacion.pdf");
        }
        private void miTermsCond_Click(object sender, EventArgs e)
        {
            Process.Start(@"Files\Licencia.pdf");
        }

        #endregion

        #endregion

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.youtube.com/rjcodeadvanceen");
        }
        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/RJCodeAdvance");
        }


    }
}
