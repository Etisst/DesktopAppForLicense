using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;
using AppContext = Etisst.Desktop.Common.AppContext;

namespace Etisst
{
    public partial class frmStartForm : frmBaseForm, IStartFormView
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
            CloseAllChilderForm();
            this.mpMainMenu.AutoSize = false;
            frmLookups childForm = new frmLookups();
            childForm.MdiParent = this;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
        }

        private void mtCustomers_Click(object sender, EventArgs e)
        {
            CloseAllChilderForm();
            this.mpMainMenu.AutoSize = false;
            frmCustomers childForm = new frmCustomers();
            CustomerListPresenter presenter = new CustomerListPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
        }

        private void mtProducts_Click(object sender, EventArgs e)
        {
            CloseAllChilderForm();
            this.mpMainMenu.AutoSize = false;
            frmProducts childForm = new frmProducts();
            // childForm.Parent = this;
            ProductListPresenter presenter = new ProductListPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
        }

        private void mtOrders_Click(object sender, EventArgs e)
        {
            CloseAllChilderForm();
            this.mpMainMenu.AutoSize = false;
            frmOrders childForm = new frmOrders();
            OrderListPresenter presenter = new OrderListPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
        }

        private void frmStartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Private method
        private void CloseAllChilderForm()
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
        }
        #endregion

    }
}
