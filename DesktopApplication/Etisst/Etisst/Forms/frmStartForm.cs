using Etisst.Desktop.BusinessLogic.UIConnector;
using Etisst.Desktop.Common;
using System;
using System.Windows.Forms;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;
using AppContext = Etisst.Desktop.Common.AppContext;

namespace Etisst
{
    public partial class frmStartForm : MetroFramework.Forms.MetroForm, IStartFormView
    {
        WCObject _wc;
        public frmStartForm()
        {
            InitializeComponent();
            _wc = AppContext.wc;
        }

        public void AttachPresenter(StartFormPresenter presenter)
        {
            
        }



        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            this.VScroll = false;
        }

        private void mtHome_Click(object sender, EventArgs e)
        {
            this.mpMainMenu.AutoSize = !this.mpMainMenu.AutoSize;
        }

        private void mtLookups_Click(object sender, EventArgs e)
        {
            this.mpMainMenu.AutoSize = false;
            ShowChildForm(sender, new ShowTabFormEventArgs(new frmLookups()));
        }

        private void mtCustomers_Click(object sender, EventArgs e)
        {
            this.mpMainMenu.AutoSize = false;
            ShowChildForm(sender, new ShowTabFormEventArgs(new frmCustomer()));
        }

        private void mtProducts_Click(object sender, EventArgs e)
        {
            this.mpMainMenu.AutoSize = false;
            frmProducts childForm = new frmProducts();
           // childForm.Parent = this;
            ProductListPresenter presenter = new ProductListPresenter(childForm);
            childForm.AttachPresenter(presenter);
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
        }

        private void mtOrders_Click(object sender, EventArgs e)
        {
            this.mpMainMenu.AutoSize = false;
            ShowChildForm(sender, new ShowTabFormEventArgs(new frmOrders()));
        }
        #endregion

        #region delegates
        private void ShowChildForm(object sender, ShowTabFormEventArgs e)
        {
            e.MetFrm.MdiParent = this;
            e.MetFrm.Dock = DockStyle.Fill;
            e.MetFrm.MaximizeBox = false;
            e.MetFrm.MinimizeBox = false;
            e.MetFrm.ShowInTaskbar = false;
            e.MetFrm.Show();
        }

        public delegate void ShowTabFormEventHandler(object sender, ShowTabFormEventArgs e);

        public class ShowTabFormEventArgs : EventArgs
        {
            public MetroFramework.Forms.MetroForm MetFrm { get; set; }

            public ShowTabFormEventArgs(MetroFramework.Forms.MetroForm metFrm)
            {
                this.MetFrm = metFrm;
            }
        }

        #endregion

    }
}
