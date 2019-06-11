using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Etisst.Desktop.BusinessLogic.UIConnector;
using Etisst.Desktop.Common;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;
using AppContext = Etisst.Desktop.Common.AppContext;
using System.Linq;
using Etisst;
using System.Windows.Forms;

namespace Etisst
{
    public partial class frmProducts : frmBaseForm, IProductListView
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
                if (value == null) return;
                gridProducts.DataSource = value;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "id",
                    "permalink",
                    "date_created_gmt",
                    "date_modified_gmt",
                    "featured",
                    "regular_price",
                    "sale_price",
                    "purchase_note",
                    "parent_id",
                    "rating_count",
                    "average_rating",
                    "dimensions",
                    "sold_individually",
                    "backordered",
                    "backorders_allowed",
                    "backorders",
                    "date_on_sale_from",
                    "date_on_sale_from_gmt",
                    "date_on_sale_to",
                    "date_on_sale_to_gmt",
                    "downloadable",
                    "download_limit",
                    "download_expiry",
                    "external_url",
                    "button_text",
                    "shipping_required",
                    "shipping_taxable",
                    "catalog_visibility",
                    "description",
                    "short_description",
                    "price_html",
                    "purchasable",
                    "_virtual",
                    "manage_stock"
                };
                if (gridProducts.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        gridProducts.Columns[column].Visible = false;
                    }
                }

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

        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridProducts.SelectedRows[0];
            if (row != null && row.DataBoundItem != null)
            {
                _selectedProduct = (Product)row.DataBoundItem;
            }
        }

        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetails childForm = new frmProductDetails();
            // childForm.Parent = this;
            ProductDetailsPresenter presenter = new ProductDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.Product = SelectedProduct;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmProductDetails childForm = new frmProductDetails();
            // childForm.Parent = this;
            ProductDetailsPresenter presenter = new ProductDetailsPresenter(childForm);
            childForm.AttachPresenter(presenter);
            childForm.MdiParent = this.ParentForm;
            childForm.Product = SelectedProduct;
            ShowChildForm(sender, new ShowTabFormEventArgs(childForm));
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProduct!= null && _selectedProduct.id > 0)
            {
                if (MessageBox.Show(this, AppTranslations.DELETE_PRODUCT, AppTranslations.PRODUCT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _presenter.DeleteProductAsync(_selectedProduct.id);
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show(this, AppTranslations.MUST_SELECT_PRODUCT, AppTranslations.PRODUCT, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _presenter.InitAsync();
            this.Visible = true;
        }
    }
}
