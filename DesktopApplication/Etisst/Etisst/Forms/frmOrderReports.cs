using DevExpress.XtraEditors;
using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeUntil { get; set; }
        public void AttachPresenter(OrderReportsPresenter presenter)
        {
            _presenter = presenter;
        }

        public void AddGraphSeries(Dictionary<string, decimal?> nodes, string seriesName)
        {
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
            foreach (var item in Enum.GetValues(typeof(System.Windows.Forms.DataVisualization.Charting.SeriesChartType)))
            {
                cbChartModel.Items.Add(item);
            }
            DateTimeFrom = dtpFrom.Value;
            DateTimeUntil = dtpUntil.Value;
        }
        private void clbSeries_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            Chart.Series.Clear();
            string currentItem = clbSeries.Items[e.Index].ToString();
            if (e.NewValue == System.Windows.Forms.CheckState.Checked)
            {
                this.AddSeries(currentItem);
            }
            foreach (string itemChecked in clbSeries.CheckedItems)
            {
                if (itemChecked != currentItem)
                {
                    AddSeries(itemChecked);
                }
            }
        }

        private void cbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chart.Series.Clear();
            clbSeries.Items.Clear();
            switch (cbReports.Text)
            {
                case "Others":
                    clbSeries.Items.Add((object)"Products");
                    clbSeries.Items.Add((object)"Customers");
                    break;
                case "Orders":
                    clbSeries.Items.Add((object)"Status");
                    break;
            }
        }
        private void cbChartModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in Chart.Series)
            {
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType result;
                Enum.TryParse(cbChartModel.Text, out result);
                series.ChartType = result;
            }
        }
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            Chart.Series.Clear();
            DateTimeFrom = dtpFrom.Value;
            foreach (string itemChecked in clbSeries.CheckedItems)
            {
                AddSeries(itemChecked);
            }
        }

        private void dtpUntil_ValueChanged(object sender, EventArgs e)
        {
            Chart.Series.Clear();
            DateTimeUntil = dtpUntil.Value;
            foreach (string itemChecked in clbSeries.CheckedItems)
            {
                AddSeries(itemChecked);
            }
        }
        #endregion
        #region Private methods
        private void AddSeries(string itemChecked)
        {
            switch (itemChecked)
            {
                case "Products":
                    _presenter.AddProductNameReport();
                    break;
                case "Customers":
                    _presenter.AddCustomersReport();
                    break;
                case "Status":
                    _presenter.AddOrderStatusReport();
                    break;
            }
        }
        #endregion
    }
}
