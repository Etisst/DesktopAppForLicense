using System;
using Etisst.Desktop.Common;
using System.Windows.Forms;
using AppContext = Etisst.Desktop.Common.AppContext;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;
using WooCommerceNET;

namespace Etisst
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_ClickAsync(object sender, EventArgs e)
        {
            AppContext.UserName = txtUserName.Text;
            AppContext.URL = "http://www.pidped.com";//txtURL.Text;
            AppContext.ClientKey = "ck_af23fe3c87cf93e5f163b66993764fc8876c00b8";// txtClientKey.Text;
            AppContext.SecretKey = "cs_e6601e16bf8139361947782394aad9e563c28410";// txtSecretKey.Text;
            string url = string.Format("{0}{1}", AppContext.URL, AppTranslations.CONNECT);
            AppContext.rest = new RestAPI(url, AppContext.ClientKey, AppContext.SecretKey);
            AppContext.wc = new WCObject(AppContext.rest);
            frmStartForm startForm = new frmStartForm();
            startForm.Show();
            this.Enabled = false;
            this.Visible = false;
        }

    }
}

