using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
using System.Collections.Generic;
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
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public void AttachPresenter(OrderReportsPresenter presenter)
        {
            _presenter = presenter;
        }

        public void AddGraphSeries(Dictionary<string, decimal?> nodes, string seriesName)
        {
            //Chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            Chart.Series.Add(seriesName);
            foreach (string key in nodes.Keys)
            {
                if (nodes[key].Value != 0)
                {
                    Chart.Series[seriesName].Points.AddXY(key, nodes[key].Value);
                }
            }
        }
        #endregion
        #region Events
        private void frmOrderReports_Load(object sender, EventArgs e)
        {
            _presenter.InitAsync();
        }
        #endregion
    }
}
