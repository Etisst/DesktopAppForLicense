using System;
using Etisst.Desktop.Common;
using System.Windows.Forms;
using AppContext = Etisst.Desktop.Common.AppContext;

namespace Etisst
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            AppContext.UserName = txtUserName.Text;
            AppContext.URL = txtURL.Text;
            AppContext.ClientKey = txtClientKey.Text;
            AppContext.SecretKey = txtSecretKey.Text;
        }
    }
}
