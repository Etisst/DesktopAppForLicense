using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmCustomerDetails : frmBaseForm, ICustomerDetailsView
    {
        #region Private Members
        CustomerDetailsPresenter _presenter;
        #endregion
        #region Constructor
        public frmCustomerDetails()
        {
            InitializeComponent();
        }
        #endregion
        #region ICustomerDetailsView Members
        public int CustomerId { get; set; }

        public Customer Customer
        {
            get;
            set;
        }

        public void AttachPresenter(CustomerDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Events
        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
