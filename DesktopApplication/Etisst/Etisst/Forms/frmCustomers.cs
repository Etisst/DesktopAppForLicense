using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmCustomers : frmBaseForm, ICustomerListView
    {
        #region Private members
        private CustomerListPresenter _presenter;
        private List<Customer> _customers;
        #endregion
        #region Constructor
        public frmCustomers()
        {
            InitializeComponent();
        }
        #endregion
        #region ICustomerListView
        public List<Customer> Customers
        {
            set
            {
                if (value == null) return;
                gridCustomers.DataSource = value;
                _customers = value;

                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "shipping",
                    "billing",
                    "password",
                    "date_created_gmt",
                    "date_modified_gmt",
                    "avatar_url",
                    "is_paying_customer"
                };
                if (gridCustomers.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        gridCustomers.Columns[column].Visible = false;
                    }
                }

                gridCustomers.ReadOnly = true;
                LoadingGIF.Visible = false;
                gridCustomers.Visible = true;
            }
        }

        public void AttachPresenter(CustomerListPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Events
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            _presenter.InitAsync();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshForm();
        }
        #endregion
        #region Private Methods
        private void RefreshForm()
        {
            gridCustomers.Visible = false;
            LoadingGIF.Visible = true;
            _presenter.InitAsync();
        }
        #endregion
    }
}
