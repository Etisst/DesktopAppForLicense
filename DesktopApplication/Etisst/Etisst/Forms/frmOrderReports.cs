using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmOrderReports : frmBaseForm, IOrderReportsView
    {
        #region Private members
        private OrderReportsPresenter _presenter;
        #endregion
        #region Constructor
        public frmOrderReports()
        {
            InitializeComponent();
        }
        #endregion
        #region IORderReportsView members
        public void AttachPresenter(OrderReportsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Events
        private void frmOrderReports_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
