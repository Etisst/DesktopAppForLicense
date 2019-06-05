using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Etisst.Desktop.BusinessLogic.UIConnector;
using Etisst.Desktop.Common;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;
using AppContext = Etisst.Desktop.Common.AppContext;
using System.Linq;

namespace Etisst
{
    public partial class frmProducts : MetroFramework.Forms.MetroForm, IProductListView
    {
        #region private members
        private ProductListPresenter _presenter;
        private Product _selectedProduct;
        #endregion

        #region Constructor
        public frmProducts()
        {
            InitializeComponent();    
        }
        #endregion

        #region IProductListViewMemers
        public void AttachPresenter(ProductListPresenter presenter)
        {
            _presenter = presenter;
        }

        public Product SelectedProduct
        {
            get
            {
                return _selectedProduct;
            }
        }

        public List<Product> Products
        {
            set
            {
                gridProducts.DataSource = value;
                gridProducts.Columns["slug"].Visible = false;
                gridProducts.ReadOnly = true;
                LoadingGIF.Visible = false;
            }
        }

        #endregion

        #region Events
        private void frmProducts_Load(object sender, EventArgs e)
        {
            _presenter.InitAsync();
        }

        private void gridProducts_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var row = gridProducts.SelectedRows[0];
            if (row != null && row.DataBoundItem != null)
            {
                _selectedProduct = (Product)row.DataBoundItem;
            }
        }

        private void gridProducts_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
        #endregion


    }
}
