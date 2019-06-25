using Etisst.Desktop.BusinessLogic.UIConnector;
using System;
using System.Linq;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst
{
    public partial class frmOrderDetails : frmBaseForm, IOrderDetailsView
    {
        #region private members
        private OrderDetailsPresenter _presenter;
        private Order _order;
        #endregion
        #region Constructor
        public frmOrderDetails()
        {
            InitializeComponent();
        }
        #endregion
        #region IOrderDetailsView members
        public int OrderId { get; set; }

        public Order Order
        {
            get { return _order; }

            set
            {
                // General panel
                _order = value;
                mtbOrderKey.Text = _order.order_key;
                mtbDateCreated.Text = _order.date_created != null ? _order.date_created.ToString() : string.Empty;
                mtbDateModified.Text = _order.date_modified != null ? _order.date_modified.ToString() : string.Empty;
                mtbCreatedVia.Text = _order.created_via;
                mtbStatus.Text = _order.status;
                mtbDatePaid.Text = _order.date_paid != null ? _order.date_paid.ToString() : string.Empty;
                mtbDateCompleted.Text = _order.date_completed != null ? _order.date_completed.ToString() : string.Empty;
                // TO DO: mtbCustomer
                mtbCustomerIP.Text = _order.customer_ip_address;
                rtbCustomerNote.Text = _order.customer_note;

                //Products panel
                foreach (WooCommerceNET.WooCommerce.v2.OrderLineItem orderLine in _order.line_items)
                {
                    dgvProducts.Rows.Add(orderLine.name, orderLine.sku, orderLine.price, orderLine.total_tax, orderLine.quantity, orderLine.total);
                }
                if (_order.shipping_lines.Any())
                {
                    mtbShippingMethod.Text = _order.shipping_lines.FirstOrDefault().method_title;
                }
                mtbShippingCost.Text = _order.shipping_total!= null ? _order.shipping_total.ToString() : string.Empty;
                mtbTotalTax.Text = _order.total_tax != null ? _order.total_tax.ToString() : string.Empty ;
                mtbTotalPrice.Text = _order.total != null ? _order.total.ToString() : string.Empty;

                //Billing details panel
                rtbAddressBilling.Text = string.Format("{0} {1}", _order.billing.address_1, _order.billing.address_2);
                mtbCityBilling.Text = _order.billing.city;
                mtbCompanyBilling.Text = _order.billing.company;
                mtbCountryBilling.Text = _order.billing.country;
                mtbEmailBilling.Text = _order.billing.email;
                mtbFirstNameBilling.Text = _order.billing.first_name;
                mtbLastNameBilling.Text = _order.billing.last_name;
                mtbPhoneBilling.Text = _order.billing.phone;
                mtbPostcodeBilling.Text = _order.billing.postcode;
                mtbStateBilling.Text = _order.billing.state;
                
                //Shipping details panel
                if(_order.shipping != null)
                {
                    rtbAddressShipping.Text = string.Format("{0} {1}", _order.shipping.address_1, _order.shipping.address_2);
                    mtbCityShipping.Text = _order.shipping.city;
                    mtbCompanyShipping.Text = _order.shipping.company;
                    mtbCountryShipping.Text = _order.shipping.country;
                    mtbFirstNameShipping.Text = _order.shipping.first_name;
                    mtbLastNameShipping.Text = _order.shipping.last_name;
                    mtbPostcodeShipping.Text = _order.shipping.postcode;
                    mtbStateShipping.Text = _order.shipping.state;
                }

            }
        }

        public void AttachPresenter(OrderDetailsPresenter presenter)
        {
            _presenter = presenter;
        }

        public Customer Customer { set { mtbCustomer.Text = value != null ? value.username : string.Empty; } }

        public bool SetAvailability
        {
            set
            {
                btnConfirm.Enabled = value;
                btnReject.Enabled = value;
            }
        }
        #endregion
        #region Events
        private void btnBillingDetailsPanel_Click(object sender, EventArgs e)
        {
            this.SetHeight(ref panelBillingDetails, 420);
        }
        private void btnShippingDetailsPanel_Click(object sender, EventArgs e)
        {
            this.SetHeight(ref panelShippingDetails, 420);
        }
        private void btnGeneralPanel_Click(object sender, EventArgs e)
        {
            this.SetHeight(ref panelGeneral,440);
        }
        private void btnProductsPanel_Click(object sender, EventArgs e)
        {
            this.SetHeight(ref panelProducts, 400);
        }
        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            _presenter.InitAsync();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _presenter.ConfirmOrderAsync();
            this.Parent.Refresh();
            this.Close();
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            _presenter.RejectOrderAsync();
            this.Parent.Refresh();
            this.Close();
        }
        #endregion
        #region Private Methods
        private bool SetHeight(ref System.Windows.Forms.Panel panel, int height=500)
        {
            if (panel.Height == btnGeneralPanel.Height)
            {
                InitializePanelsHeight();
                while (panel.Height < height)
                {
                    panel.Height += 4;
                }
                return true;
            }
            else
            {
                panel.Height = btnGeneralPanel.Height;
                return false;
            }
        }
        private void InitializePanelsHeight()
        {
            panelGeneral.Height = btnGeneralPanel.Height;
            panelProducts.Height = btnProductsPanel.Height;
            panelBillingDetails.Height = btnBillingDetailsPanel.Height;
            panelShippingDetails.Height = btnShippingDetailsPanel.Height;
        }



        #endregion
    }
}
