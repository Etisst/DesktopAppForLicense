
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Etisst.Desktop.BusinessLogic.UIConnector;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmOrders : frmBaseForm, IOrderListView
    {
        #region private members
        private OrderListPresenter _presenter;
        private List<Order> _orders;
        private Order _selectedOrder;
        #endregion
        #region Constructor
        public frmOrders()
        {
            InitializeComponent();
        }
        #endregion

        #region IOrderListView members
        public Order SelectedOrder
        {
            get { return _selectedOrder; }
        }
        public List<Order> Orders
        {
            set
            {
                if (value == null) return;
                gridOrders.DataSource = value;
                _orders = value;

                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "id",
                    "parent_id",
                    "order_key",
                    "version",
                    "date_created_gmt",
                    "date_modified_gmt",
                    "date_paid_gmt",
                    "date_completed_gmt",
                    "set_paid",
                    "transaction_id",
                    "billing",
                    "cart_hash",
                    "customer_ip_address",
                    "customer_user_agent",
                    "payment_method",
                    "shipping",
                    "customer_note",
                    "discount_tax",
                    "shipping_tax",
                    "discount_total",
                    "shipping_total",
                    "cart_tax",
                    "customer_id"
                };
                if (gridOrders.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        gridOrders.Columns[column].Visible = false;
                    }
                }

                gridOrders.ReadOnly = true;
                LoadingGIF.Visible = false;
                gridOrders.Visible = true;
            }
        }

        public void AttachPresenter(OrderListPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion

        #region Events
        private void gridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridOrders.SelectedRows[0];
            if (row != null && row.DataBoundItem != null)
            {
                _selectedOrder = (Order)row.DataBoundItem;
            }
        }

        private void gridOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails childForm = new frmOrderDetails();
            OrderDetailsPresenter presenter = new OrderDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.Order = SelectedOrder;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
        }

        private void frmOrders_Load(object sender, System.EventArgs e)
        {
            _presenter.InitAsync();
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            this.RefreshForm();
        }

        private void btnView_Click(object sender, System.EventArgs e)
        {
            frmOrderDetails childForm = new frmOrderDetails();
            OrderDetailsPresenter presenter = new OrderDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.Order = SelectedOrder;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
        }

        private void btnReport_Click(object sender, System.EventArgs e)
        {
            frmOrderReports childForm = new frmOrderReports();
            OrderReportsPresenter presenter = new OrderReportsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            //childForm.Order = SelectedOrder;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
        }
        #endregion
        #region Private Methods
        private void RefreshForm()
        {
            gridOrders.Visible = false;
            LoadingGIF.Visible = true;
            _presenter.InitAsync();
        }
        #endregion
    }
}
