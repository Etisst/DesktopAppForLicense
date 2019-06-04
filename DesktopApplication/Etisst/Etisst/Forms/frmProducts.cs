using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Etisst.Desktop.BusinessLogic.UIConnector;
using Etisst.Desktop.Common;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;
using AppContext = Etisst.Desktop.Common.AppContext;

namespace Etisst
{
    public partial class frmProducts : MetroFramework.Forms.MetroForm, IProductListView
    {
        ProductListPresenter _presenter;
        public frmProducts()
        {
            InitializeComponent();    
        }


        public void AttachPresenter(ProductListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void SetGrid(List<Product> products)
        {
            gridProducts.DataSource = products;
            gridProducts.Columns["slug"].Visible = false;

            LoadingGIF.Enabled = false;
            LoadingGIF.Visible = false;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            _presenter.InitAsync();
        }
        
            
    }
}
